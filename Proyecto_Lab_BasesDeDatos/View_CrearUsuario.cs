using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Proyecto_Lab_BasesDeDatos
{
    public partial class View_CrearUsuario : UserControl
    {

        private string connectionString = "Data Source=192.168.20.37:1521/XEPDB1;User Id=admin;Password=oracle;";

        public View_CrearUsuario()
        {
            InitializeComponent();
            CargarRoles();
        }

        private void CargarRoles()
        {

            cb_CrearUsuario_Rol.Items.Clear();
            cb_CrearUsuario_Rol.Items.Add("admin");
            cb_CrearUsuario_Rol.Items.Add("empleado");
            cb_CrearUsuario_Rol.Items.Add("entrenador");
            cb_CrearUsuario_Rol.Items.Add("cliente");
            cb_CrearUsuario_Rol.SelectedIndex = 0;
        }

        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CrearUsuario_Usuario.Text) ||
                string.IsNullOrWhiteSpace(txt_CrearUsuario_Contrasenia.Text) ||
                string.IsNullOrWhiteSpace(txt_CrearUsuario_Nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_CrearUsuario_Telefono.Text) ||
                cb_CrearUsuario_Rol.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txt_CrearUsuario_Contrasenia.Text != txt_CrearUsuario_Confirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string usuario = txt_CrearUsuario_Usuario.Text;
            string contrasenia = txt_CrearUsuario_Contrasenia.Text;
            string nombre = txt_CrearUsuario_Nombre.Text;
            string telefono = txt_CrearUsuario_Telefono.Text;
            string rol = cb_CrearUsuario_Rol.SelectedItem.ToString() ?? "cliente";

            DateTime fechaNacimiento = new DateTime(2000, 1, 1);
            string genero = "masculino";
            string direccion = "N/A";
            decimal salario = 1500000.00m;

            OracleConnection connection = null;
            OracleTransaction transaction = null;

            try
            {
                connection = new OracleConnection(connectionString);
                connection.Open();

                transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);

                int newPersonaID = 0;
                string sqlGetPersonaID = "SELECT SEQ_PERSONA_ID.NEXTVAL FROM DUAL";
                using (OracleCommand cmd = new OracleCommand(sqlGetPersonaID, connection))
                {
                    cmd.Transaction = transaction;
                    newPersonaID = Convert.ToInt32(cmd.ExecuteScalar());
                }

                int newUsuarioID = 0;
                string sqlGetUsuarioID = "SELECT SEQ_USUARIO_ID.NEXTVAL FROM DUAL";
                using (OracleCommand cmd = new OracleCommand(sqlGetUsuarioID, connection))
                {
                    cmd.Transaction = transaction;
                    newUsuarioID = Convert.ToInt32(cmd.ExecuteScalar());
                }


                string sqlPersona = @"
                    INSERT INTO PERSONA (ID, NOMBRE, FECHANACIMIENTO, GENERO, DIRECCION) 
                    VALUES (:p_ID, :p_NOMBRE, :p_FECHANACIMIENTO, :p_GENERO, :p_DIRECCION)";

                using (OracleCommand cmd = new OracleCommand(sqlPersona, connection))
                {
                    cmd.Transaction = transaction;
                    cmd.Parameters.Add(":p_ID", newPersonaID);
                    cmd.Parameters.Add(":p_NOMBRE", nombre);
                    cmd.Parameters.Add(":p_FECHANACIMIENTO", fechaNacimiento);
                    cmd.Parameters.Add(":p_GENERO", genero);
                    cmd.Parameters.Add(":p_DIRECCION", direccion);
                    cmd.ExecuteNonQuery();
                }


                string sqlUsuario = @"
                    INSERT INTO USUARIO (USUID, USUNOMBRE, USUROL, USUCONTRASENA, IDPERSONA) 
                    VALUES (:u_USUID, :u_USUNOMBRE, :u_USUROL, :u_USUCONTRASENA, :u_IDPERSONA)";

                using (OracleCommand cmd = new OracleCommand(sqlUsuario, connection))
                {
                    cmd.Transaction = transaction;
                    cmd.Parameters.Add(":u_USUID", newUsuarioID);
                    cmd.Parameters.Add(":u_USUNOMBRE", usuario);
                    cmd.Parameters.Add(":u_USUROL", rol);
                    cmd.Parameters.Add(":u_USUCONTRASENA", contrasenia);
                    cmd.Parameters.Add(":u_IDPERSONA", newPersonaID);
                    cmd.ExecuteNonQuery();
                }


                string sqlEmpleado = "INSERT INTO EMPLEADO (ID, SALARIO) VALUES (:e_ID, :e_SALARIO)";

                using (OracleCommand cmd = new OracleCommand(sqlEmpleado, connection))
                {
                    cmd.Transaction = transaction;
                    cmd.Parameters.Add(":e_ID", newPersonaID);
                    cmd.Parameters.Add(":e_SALARIO", salario);
                    cmd.ExecuteNonQuery();
                }


                if (rol.Equals("tecnico", StringComparison.OrdinalIgnoreCase))
                {
                    string sqlTecnico = "INSERT INTO TECNICO (ID) VALUES (:t_ID)";
                    using (OracleCommand cmd = new OracleCommand(sqlTecnico, connection))
                    {
                        cmd.Transaction = transaction;
                        cmd.Parameters.Add(":t_ID", newPersonaID);
                        cmd.ExecuteNonQuery();
                    }
                }
                else if (rol.Equals("entrenador", StringComparison.OrdinalIgnoreCase))
                {

                    string tipoEntrenador = "cardio";
                    string sqlEntrenador = "INSERT INTO ENTRENADOR (ID, TIPO) VALUES (:e_ID, :e_TIPO)";

                    using (OracleCommand cmd = new OracleCommand(sqlEntrenador, connection))
                    {
                        cmd.Transaction = transaction;
                        cmd.Parameters.Add(":e_ID", newPersonaID);
                        cmd.Parameters.Add(":e_TIPO", tipoEntrenador);
                        cmd.ExecuteNonQuery();
                    }
                }

                string sqlTelefono = "INSERT INTO TELEFONOS (IDPERSONA, TELEFONO) VALUES (:t_IDPERSONA, :t_TELEFONO)";

                using (OracleCommand cmd = new OracleCommand(sqlTelefono, connection))
                {
                    cmd.Transaction = transaction;
                    cmd.Parameters.Add(":t_IDPERSONA", newPersonaID);
                    cmd.Parameters.Add(":t_TELEFONO", telefono);
                    cmd.ExecuteNonQuery();
                }

                
                transaction.Commit();

                MessageBox.Show("Usuario creado con éxito.", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txt_CrearUsuario_Usuario.Clear();
                txt_CrearUsuario_Contrasenia.Clear();
                txt_CrearUsuario_Confirmar.Clear();
                txt_CrearUsuario_Nombre.Clear();
                txt_CrearUsuario_Telefono.Clear();
                cb_CrearUsuario_Rol.SelectedIndex = 0;
            }
            catch (OracleException ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show($"Error de Base de Datos (Código {ex.Number}): {ex.Message}", "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (transaction != null)
                {
                    transaction.Rollback();
                }
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error Inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
