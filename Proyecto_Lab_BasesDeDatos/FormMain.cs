using System.Windows.Forms;

namespace Proyecto_Lab_BasesDeDatos
{
    public partial class FormMain : Form
    {
        private string usuarioActual;
        private string rolActual;

        public FormMain()
        {
            usuarioActual = null;
            rolActual = null;
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
        //
        //  Aqui se colocan cosas de la base de datos
        //
        public void SetUsuario(string rol, string usuario)
        {
            rolActual = rol;
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
                case "Admin":
                    btnView_Empleado.Visible = true;
                    btnView_EmpresaProveedora.Visible = true;
                    btnView_Mantenimiento.Visible = true;
                    btnView_Maquina.Visible = true;
                    btnView_Persona.Visible = true;
                    btnView_PlanEntrenamiento.Visible = true;
                    btnView_Rutina.Visible = true;
                    btnView_Usuario_Membresia.Visible = true;
                    break;

                case "Entrenador":
                    btnView_PlanEntrenamiento.Visible = true;
                    btnView_Rutina.Visible = true;
                    btnView_Maquina.Visible = true;
                    break;

                case "Recepcionista":
                    btnView_Usuario_Membresia.Visible = true;
                    btnView_Persona.Visible = true;
                    break;

                case "Mantenimiento":
                    btnView_Mantenimiento.Visible = true;
                    btnView_Maquina.Visible = true;
                    break;

                case "Usuario":
                    btnView_PlanEntrenamiento.Visible = true;
                    btnView_Rutina.Visible = true;
                    break;
            }
        }

    }
}
