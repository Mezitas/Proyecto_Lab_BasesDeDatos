using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Lab_BasesDeDatos
{
    public partial class View_UsuarioInformacion : UserControl
    {
        FormMain main;
        public View_UsuarioInformacion()
        {
            main = new FormMain();
            InitializeComponent();
            CargarDatosPersonaAsync();
        }
        //
        //  Aqui se coloca cosas de la base de datos
        //
        private async Task CargarDatosPersonaAsync()
        {
            try
            {
                using (OracleConnection con = main.GetConnection())
                {
                    await con.OpenAsync();

                    string sql = @"SELECT NOMBRE, FECHANACIMIENTO, GENERO, DIRECCION
                           FROM PERSONA
                           WHERE ID = :id";

                    using (OracleCommand cmd = new OracleCommand(sql, con))
                    {
                        cmd.Parameters.Add(":id", main.personaActualId);

                        using (OracleDataReader dr = await cmd.ExecuteReaderAsync())
                        {
                            if (await dr.ReadAsync())
                            {
                                lblIdM.Text = main.personaActualId.ToString();
                                txtNombre.Text = dr["NOMBRE"].ToString();
                                txtFechaNacimiento.Text = Convert.ToDateTime(dr["FECHANACIMIENTO"]).ToString("yyyy-MM-dd");
                                txtGenero.Text = dr["GENERO"].ToString();
                                txtDireccion.Text = dr["DIRECCION"].ToString();
                                txtTelefono.Text = "muchos";
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron datos de la persona.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Datos guardados correctamente (ejemplo sin base de datos).",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
        private async void btnGuardar_Accion(object sender, EventArgs e)
        {
            try
            {
                using (OracleConnection con = main.GetConnection())
                {
                    await con.OpenAsync();

                    string sql = @"UPDATE PERSONA
                           SET NOMBRE = :nombre,
                               FECHANACIMIENTO = :fecha,
                               GENERO = :genero,
                               DIRECCION = :direccion
                           WHERE ID = :id";

                    using (OracleCommand cmd = new OracleCommand(sql, con))
                    {
                        cmd.Parameters.Add(":nombre", txtNombre.Text);

                        // FECHA
                        if (DateTime.TryParse(txtFechaNacimiento.Text, out DateTime fecha))
                            cmd.Parameters.Add(":fecha", fecha);
                        else
                            cmd.Parameters.Add(":fecha", DBNull.Value);

                        cmd.Parameters.Add(":genero", txtGenero.Text);
                        cmd.Parameters.Add(":direccion", txtDireccion.Text);

                        // ID DE LA PERSONA LOGUEADA
                        cmd.Parameters.Add(":id", main.personaActualId);

                        int filas = await cmd.ExecuteNonQueryAsync();

                        if (filas > 0)
                            MessageBox.Show("Datos actualizados correctamente.");
                        else
                            MessageBox.Show("No se encontró la persona o no se actualizó nada.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }
    }
}
