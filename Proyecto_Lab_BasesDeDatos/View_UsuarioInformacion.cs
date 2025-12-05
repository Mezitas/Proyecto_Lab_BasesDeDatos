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
        public View_UsuarioInformacion()
        {
            InitializeComponent();
            CargarDatosEjemplo();
        }
        //
        //  Aqui se coloca cosas de la base de datos
        //
        private void CargarDatosEjemplo()
        {
            txtId.Text = "1";
            txtNombre.Text = "Juan Pérez";
            txtFechaNacimiento.Text = "2003-05-10";
            txtGenero.Text = "Masculino";
            txtDireccion.Text = "Calle 123 #45-67";
            txtTelefono.Text = "3001234567";
        }
        //
        //  Aqui se colocan cosas de la base de datos
        //
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Datos guardados correctamente (ejemplo sin base de datos).",
                "Información",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
