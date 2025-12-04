namespace Proyecto_Lab_BasesDeDatos
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_iniciarSesion = new Button();
            btn_CrearUsuario = new Button();
            panelLogin = new Panel();
            SuspendLayout();
            // 
            // btn_iniciarSesion
            // 
            btn_iniciarSesion.BackColor = SystemColors.ActiveCaption;
            btn_iniciarSesion.Location = new Point(177, 12);
            btn_iniciarSesion.Name = "btn_iniciarSesion";
            btn_iniciarSesion.Size = new Size(423, 62);
            btn_iniciarSesion.TabIndex = 0;
            btn_iniciarSesion.Text = "Iniciar Sesión";
            btn_iniciarSesion.UseVisualStyleBackColor = false;
            btn_iniciarSesion.Click += btn_iniciarSesion_Click;
            // 
            // btn_CrearUsuario
            // 
            btn_CrearUsuario.BackColor = SystemColors.ActiveCaption;
            btn_CrearUsuario.Location = new Point(680, 12);
            btn_CrearUsuario.Name = "btn_CrearUsuario";
            btn_CrearUsuario.Size = new Size(423, 62);
            btn_CrearUsuario.TabIndex = 1;
            btn_CrearUsuario.Text = "Crear usuario";
            btn_CrearUsuario.UseVisualStyleBackColor = false;
            btn_CrearUsuario.Click += btn_CrearUsuario_Click;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.RosyBrown;
            panelLogin.Location = new Point(12, 98);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(1256, 610);
            panelLogin.TabIndex = 2;
            panelLogin.TabStop = true;
            panelLogin.Paint += panelLogin_Paint;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelLogin);
            Controls.Add(btn_CrearUsuario);
            Controls.Add(btn_iniciarSesion);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_iniciarSesion;
        private Button btn_CrearUsuario;
        private Panel panelLogin;
    }
}