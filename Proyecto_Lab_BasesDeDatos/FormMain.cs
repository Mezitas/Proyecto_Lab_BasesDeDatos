using System.Windows.Forms;

namespace Proyecto_Lab_BasesDeDatos
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            cargarVista(new View_Empleado());
        }
        private void cargarVista(UserControl vista)
        {
            panelContenido.Controls.Clear();
            vista.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(vista);
        }
    }
}
