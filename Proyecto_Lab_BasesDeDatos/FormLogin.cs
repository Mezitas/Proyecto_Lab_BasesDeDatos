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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            cargarVista(new View_IniciarSesion());
        }
        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            cargarVista(new View_IniciarSesion());
        }
        private void btn_CrearUsuario_Click(object sender, EventArgs e)
        {
            cargarVista(new View_CrearUsuario());
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
        //Cambiar de "pestañas"

        private void cargarVista(UserControl vista)
        {
            panelLogin.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            panelLogin.Controls.Add(vista);
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
