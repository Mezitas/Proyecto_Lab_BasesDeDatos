using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace Proyecto_Lab_BasesDeDatos
{
    public partial class FormMain : Form
    {
        public int personaActualId;
        private string usuarioActual;
        private string rolActual;
        private string connectionString;
        public FormMain()
        {
            connectionString="Data Source=192.168.20.37:1521/XEPDB1;User Id=admin;Password=oracle;";
            usuarioActual = "";
            rolActual = "";
            InitializeComponent();
        }
        //Base de datos conexion universal XD
        public OracleConnection GetConnection()
        {
            return new OracleConnection(connectionString);
        }
        private async Task<bool> ProbarUsuarioAsync(string contrasenia, string usuario)
        {
            try
            {
                using (OracleConnection con = GetConnection())
                {
                    await con.OpenAsync();

                    string sqlRol = @"SELECT USUROL 
                              FROM USUARIO 
                              WHERE USUNOMBRE = :usuario 
                              AND USUCONTRASENA = :contrasena";

                    using (OracleCommand cmd = new OracleCommand(sqlRol, con))
                    {
                        cmd.BindByName = true;
                        cmd.Parameters.Add("usuario", OracleDbType.Varchar2).Value = usuario;
                        cmd.Parameters.Add("contrasena", OracleDbType.Varchar2).Value = contrasenia;

                        var rol = await cmd.ExecuteScalarAsync();

                        if (rol == null || rol == DBNull.Value)
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                            return false;
                        }

                        rolActual = rol.ToString();
                    }

                    string sqlId = @"SELECT IDPERSONA 
                             FROM USUARIO 
                             WHERE USUNOMBRE = :usuario 
                             AND USUCONTRASENA = :contrasenia";

                    using (OracleCommand cmd1 = new OracleCommand(sqlId, con))
                    {
                        cmd1.BindByName = true;
                        cmd1.Parameters.Add("usuario", OracleDbType.Varchar2).Value = usuario;
                        cmd1.Parameters.Add("contrasenia", OracleDbType.Varchar2).Value = contrasenia;

                        var id = await cmd1.ExecuteScalarAsync();

                        if (id != null && id != DBNull.Value)
                        {
                            personaActualId = Convert.ToInt32(id);
                        }
                        else
                        {
                            MessageBox.Show("Error interno: este usuario no tiene persona asociada.");
                            return false;
                        }
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
                return false;
            }
        }
        private void cargarVista(UserControl vista)
        {
            panelContenido.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(vista);
        }
        //Funcionalidad botones PanelMenu
        private void BtnView_Empleado_Click(object sender, EventArgs e)
        {
            cargarVista(new View_Empleado());
        }

        private void BtnView_EmpresaProveedora_Click(object sender, EventArgs e)
        {
            cargarVista(new View_EmpresaProovedora());
        }

        private void BtnView_Mantenimiento_Click(object sender, EventArgs e)
        {
            cargarVista(new View_Mantenimiento());
        }

        private void BtnView_Maquina_Click(object sender, EventArgs e)
        {
            cargarVista(new View_Maquina());
        }

        private void BtnView_Persona_Click(object sender, EventArgs e)
        {
            cargarVista(new View_Persona());
        }

        private void BtnView_PlanEntrenamiento_Click(object sender, EventArgs e)
        {
            cargarVista(new View_PlanEntrenamiento());
        }

        private void BtnView_Rutina_Click(object sender, EventArgs e)
        {
            cargarVista(new View_Rutina());
        }

        private void BtnView_Usuario_Membresia_Click(object sender, EventArgs e)
        {
            cargarVista(new View_Usuario_Membresia());
        }
        private void lblUsuario_Click(object sender, EventArgs e)
        {
            cargarVista(new View_UsuarioInformacion());
        }
        //
        //  Aqui se colocan cosas de la base de datos
        //
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Seguro que deseas cerrar sesión?",
                "Cerrar sesion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.Yes)
            {
                FormLogin login = new FormLogin();
                login.Show();
                this.Hide();
            }
        }
        public async Task<bool> verificarUsuario(string contrasenia, string usuario)
        {
            bool esValido = await ProbarUsuarioAsync(contrasenia, usuario);

            if (esValido)
            {
                SetUsuario(usuario);
                return true;
            }
            else
            {
                return false;
            }
        }
        public void SetUsuario(string usuario)
        {
            usuarioActual = usuario;
            lblUsuario.Text = "Usuario: " + usuarioActual;
            VerificarRol();
        }
        private void VerificarRol()
        {
            
            btnView_Empleado.Visible = false;
            btnView_EmpresaProveedora.Visible = false;
            btnView_Mantenimiento.Visible = false;
            btnView_Maquina.Visible = false;
            btnView_Persona.Visible = false;
            btnView_PlanEntrenamiento.Visible = false;
            btnView_Rutina.Visible = false;
            btnView_Usuario_Membresia.Visible = false;

            switch (rolActual)
            {
                case "admin":
                    btnView_Empleado.Visible = true;
                    btnView_EmpresaProveedora.Visible = true;
                    btnView_Mantenimiento.Visible = true;
                    btnView_Maquina.Visible = true;
                    btnView_Persona.Visible = true;
                    btnView_PlanEntrenamiento.Visible = true;
                    btnView_Rutina.Visible = true;
                    btnView_Usuario_Membresia.Visible = true;
                    break;

                case "entrenador":
                    btnView_PlanEntrenamiento.Visible = true;
                    btnView_Rutina.Visible = true;
                    btnView_Maquina.Visible = true;
                    break;

                case "empleado":
                    btnView_Usuario_Membresia.Visible = true;
                    btnView_Persona.Visible = true;
                    btnView_Mantenimiento.Visible = true;
                    btnView_Maquina.Visible = true;
                    break;

                case "cliente":
                    btnView_PlanEntrenamiento.Visible = true;
                    btnView_Rutina.Visible = true;
                    break;
            }
        }

    }
}
