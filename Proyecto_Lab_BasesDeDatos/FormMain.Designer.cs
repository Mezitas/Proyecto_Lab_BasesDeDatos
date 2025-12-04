namespace Proyecto_Lab_BasesDeDatos
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelContenido = new Panel();
            panelMenu = new Panel();
            btnView_Empleado = new Button();
            btnView_EmpresaProveedora = new Button();
            btnView_Mantenimiento = new Button();
            btnView_Maquina = new Button();
            btnView_Persona = new Button();
            btnView_PlanEntrenamiento = new Button();
            btnView_Rutina = new Button();
            btnView_Usuario_Membresia = new Button();
            panelUsuario = new Panel();
            btnCerrarSesion = new Button();
            lblUsuario = new Label();
            panelMenu.SuspendLayout();
            panelUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.RosyBrown;
            panelContenido.Location = new Point(311, 58);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(957, 650);
            panelContenido.TabIndex = 0;
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.Silver;
            panelMenu.Controls.Add(btnView_Empleado);
            panelMenu.Controls.Add(btnView_EmpresaProveedora);
            panelMenu.Controls.Add(btnView_Mantenimiento);
            panelMenu.Controls.Add(btnView_Maquina);
            panelMenu.Controls.Add(btnView_Persona);
            panelMenu.Controls.Add(btnView_PlanEntrenamiento);
            panelMenu.Controls.Add(btnView_Rutina);
            panelMenu.Controls.Add(btnView_Usuario_Membresia);
            panelMenu.ForeColor = Color.DarkSlateGray;
            panelMenu.Location = new Point(12, 58);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(288, 650);
            panelMenu.TabIndex = 0;
            // 
            // panelUsuario
            // 
            panelUsuario.BackColor = Color.Thistle;
            panelUsuario.Controls.Add(lblUsuario);
            panelUsuario.Controls.Add(btnCerrarSesion);
            panelUsuario.Location = new Point(12, 12);
            panelUsuario.Name = "panelUsuario";
            panelUsuario.Size = new Size(1256, 40);
            panelUsuario.TabIndex = 1;
            // 
            // btnView_Empleado
            // 
            btnView_Empleado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnView_Empleado.Location = new Point(20, 20);
            btnView_Empleado.Name = "btnView_Empleado";
            btnView_Empleado.Size = new Size(260, 45);
            btnView_Empleado.TabIndex = 0;
            btnView_Empleado.Text = "Empleado";
            btnView_Empleado.Click += BtnView_Empleado_Click;
            // 
            // btnView_EmpresaProveedora
            // 
            btnView_EmpresaProveedora.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnView_EmpresaProveedora.Location = new Point(20, 75);
            btnView_EmpresaProveedora.Name = "btnView_EmpresaProveedora";
            btnView_EmpresaProveedora.Size = new Size(260, 45);
            btnView_EmpresaProveedora.TabIndex = 1;
            btnView_EmpresaProveedora.Text = "Empresa Proveedora";
            btnView_EmpresaProveedora.Click += BtnView_EmpresaProveedora_Click;
            // 
            // btnView_Mantenimiento
            // 
            btnView_Mantenimiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnView_Mantenimiento.Location = new Point(20, 130);
            btnView_Mantenimiento.Name = "btnView_Mantenimiento";
            btnView_Mantenimiento.Size = new Size(260, 45);
            btnView_Mantenimiento.TabIndex = 2;
            btnView_Mantenimiento.Text = "Mantenimiento";
            btnView_Mantenimiento.Click += BtnView_Mantenimiento_Click;
            // 
            // btnView_Maquina
            // 
            btnView_Maquina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnView_Maquina.Location = new Point(20, 185);
            btnView_Maquina.Name = "btnView_Maquina";
            btnView_Maquina.Size = new Size(260, 45);
            btnView_Maquina.TabIndex = 3;
            btnView_Maquina.Text = "Máquina";
            btnView_Maquina.Click += BtnView_Maquina_Click;
            // 
            // btnView_Persona
            // 
            btnView_Persona.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnView_Persona.Location = new Point(20, 240);
            btnView_Persona.Name = "btnView_Persona";
            btnView_Persona.Size = new Size(260, 45);
            btnView_Persona.TabIndex = 4;
            btnView_Persona.Text = "Persona";
            btnView_Persona.Click += BtnView_Persona_Click;
            // 
            // btnView_PlanEntrenamiento
            // 
            btnView_PlanEntrenamiento.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnView_PlanEntrenamiento.Location = new Point(20, 295);
            btnView_PlanEntrenamiento.Name = "btnView_PlanEntrenamiento";
            btnView_PlanEntrenamiento.Size = new Size(260, 45);
            btnView_PlanEntrenamiento.TabIndex = 5;
            btnView_PlanEntrenamiento.Text = "Plan Entrenamiento";
            btnView_PlanEntrenamiento.Click += BtnView_PlanEntrenamiento_Click;
            // 
            // btnView_Rutina
            // 
            btnView_Rutina.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnView_Rutina.Location = new Point(20, 350);
            btnView_Rutina.Name = "btnView_Rutina";
            btnView_Rutina.Size = new Size(260, 45);
            btnView_Rutina.TabIndex = 6;
            btnView_Rutina.Text = "Rutina";
            btnView_Rutina.Click += BtnView_Rutina_Click;
            // 
            // btnView_Usuario_Membresia
            // 
            btnView_Usuario_Membresia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnView_Usuario_Membresia.Location = new Point(20, 405);
            btnView_Usuario_Membresia.Name = "btnView_Usuario_Membresia";
            btnView_Usuario_Membresia.Size = new Size(260, 45);
            btnView_Usuario_Membresia.TabIndex = 7;
            btnView_Usuario_Membresia.Text = "Usuario - Membresía";
            btnView_Usuario_Membresia.Click += BtnView_Usuario_Membresia_Click;
            
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(220, 72, 20);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(810, 8);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(130, 28);
            btnCerrarSesion.TabIndex = 0;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblUsuario.Location = new Point(15, 10);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(400, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario: (sin iniciar sesión)";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelUsuario);
            Controls.Add(panelMenu);
            Controls.Add(panelContenido);
            Name = "FormMain";
            Text = "Gimnasio";
            panelMenu.ResumeLayout(false);
            panelUsuario.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        //Paneles
        private Panel panelContenido;
        private Panel panelMenu;
        private Panel panelUsuario;
        //Botones panelMenu
        private Button btnView_Empleado;
        private Button btnView_EmpresaProveedora;
        private Button btnView_Mantenimiento;
        private Button btnView_Maquina;
        private Button btnView_Persona;
        private Button btnView_PlanEntrenamiento;
        private Button btnView_Rutina;
        private Button btnView_Usuario_Membresia;

        //botones y texto panelUsuario
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}
