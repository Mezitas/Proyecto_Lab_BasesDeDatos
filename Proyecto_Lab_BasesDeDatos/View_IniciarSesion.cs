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
    public partial class View_IniciarSesion : UserControl
    {
        public View_IniciarSesion()
        {
            InitializeComponent();
        }
        public void btn_IniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txt_IniciarSesion_Usuario.Text;
            string contrasenia = txt_IniciarSesion_Contrasenia.Text;
            if (txt_IniciarSesion_Usuario.Text=="")
            {
                DialogResult advertencia = MessageBox.Show(
                    "¡Advertencia! Necesitas ingresar un usuario",
                    "Campos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }else if(txt_IniciarSesion_Contrasenia.Text == "")
            {
                DialogResult advertencia = MessageBox.Show(
                    "¡Advertencia! Necesitas ingresar una contraseña",
                    "Campos incompletos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            else
            { 
                FormMain main = new FormMain();
                //Problema de FormMain minimizandose por el FindForm().Hide();
                main.Show();
                FindForm().Hide();
                //
                //  Aqui se colocan cosas de la base de datos
                //
                main.SetUsuario("Admin", usuario);
                main.Show();
            }
                
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
