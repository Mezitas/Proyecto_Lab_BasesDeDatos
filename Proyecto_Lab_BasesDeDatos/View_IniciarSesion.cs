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
            FormMain main = new FormMain();
            this.FindForm().Hide();
            main.Show();
            main.SetUsuario("Admin");
        }
    }
}
