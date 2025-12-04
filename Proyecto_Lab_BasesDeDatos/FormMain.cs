using System.Windows.Forms;

namespace Proyecto_Lab_BasesDeDatos
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
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
        public void SetUsuario(string nombre)
        {
            lblUsuario.Text = "Usuario: " + nombre;
        }
    }
}
