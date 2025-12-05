using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client; 

namespace Proyecto_Lab_BasesDeDatos
{
    public partial class View_Maquina : UserControl
    {
        private string connectionString = "Data Source=192.168.20.37:1521/XEPDB1;User Id=admin;Password=oracle;";

        public View_Maquina()
        {
            InitializeComponent();
            
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(lblIdM.Text, out int idMaquina))
            {
                MessageBox.Show("Por favor, ingrese un ID de Máquina válido y numérico.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show($"¿Está seguro que desea eliminar la Máquina con ID {idMaquina}? Se eliminarán automáticamente todos los registros de mantenimiento, recomendaciones y proveedores asociados.",
                                "Confirmar Eliminación con CASCADE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            OracleConnection connection = null;

            try
            {
                connection = new OracleConnection(connectionString);
                connection.Open();

                string sqlDeleteMaquina = "DELETE FROM MAQUINA WHERE IDMAQUINA = :id";
                int rowsAffected;

                using (OracleCommand cmd = new OracleCommand(sqlDeleteMaquina, connection))
                {

                    cmd.Parameters.Add(":id", idMaquina);
                    rowsAffected = cmd.ExecuteNonQuery();
                }

                if (rowsAffected > 0)
                {
                    MessageBox.Show($"Máquina con ID {idMaquina} eliminada con éxito.", "Eliminación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    lblIdM.Clear();
 
                }
                else
                {
                    MessageBox.Show($"La Máquina con ID {idMaquina} no fue encontrada o ya ha sido eliminada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (OracleException ex)
            {

                MessageBox.Show($"Error de Base de Datos (Código {ex.Number}): {ex.Message}", "Error de BD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {

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
