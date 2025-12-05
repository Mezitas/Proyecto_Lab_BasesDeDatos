namespace Proyecto_Lab_BasesDeDatos
{
    partial class View_IniciarSesion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        


        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_IniciarSesion_Usuario = new Label();
            txt_IniciarSesion_Usuario = new TextBox();
            lbl_IniciarSesion_Contrasenia = new Label();
            txt_IniciarSesion_Contrasenia = new TextBox();
            btn_IniciarSesion = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbl_IniciarSesion_Usuario
            // 
            lbl_IniciarSesion_Usuario.AutoSize = true;
            lbl_IniciarSesion_Usuario.Location = new Point(434, 164);
            lbl_IniciarSesion_Usuario.Name = "lbl_IniciarSesion_Usuario";
            lbl_IniciarSesion_Usuario.Size = new Size(47, 15);
            lbl_IniciarSesion_Usuario.TabIndex = 0;
            lbl_IniciarSesion_Usuario.Text = "Usuario";
            // 
            // txt_IniciarSesion_Usuario
            // 
            txt_IniciarSesion_Usuario.Location = new Point(534, 161);
            txt_IniciarSesion_Usuario.Name = "txt_IniciarSesion_Usuario";
            txt_IniciarSesion_Usuario.Size = new Size(200, 23);
            txt_IniciarSesion_Usuario.TabIndex = 1;
            // 
            // lbl_IniciarSesion_Contrasenia
            // 
            lbl_IniciarSesion_Contrasenia.AutoSize = true;
            lbl_IniciarSesion_Contrasenia.Location = new Point(434, 224);
            lbl_IniciarSesion_Contrasenia.Name = "lbl_IniciarSesion_Contrasenia";
            lbl_IniciarSesion_Contrasenia.Size = new Size(67, 15);
            lbl_IniciarSesion_Contrasenia.TabIndex = 2;
            lbl_IniciarSesion_Contrasenia.Text = "Contraseña";
            // 
            // txt_IniciarSesion_Contrasenia
            // 
            txt_IniciarSesion_Contrasenia.Location = new Point(534, 221);
            txt_IniciarSesion_Contrasenia.Name = "txt_IniciarSesion_Contrasenia";
            txt_IniciarSesion_Contrasenia.PasswordChar = '*';
            txt_IniciarSesion_Contrasenia.Size = new Size(200, 23);
            txt_IniciarSesion_Contrasenia.TabIndex = 3;
            // 
            // btn_IniciarSesion
            // 
            btn_IniciarSesion.Location = new Point(534, 284);
            btn_IniciarSesion.Name = "btn_IniciarSesion";
            btn_IniciarSesion.Size = new Size(200, 35);
            btn_IniciarSesion.TabIndex = 4;
            btn_IniciarSesion.Text = "Iniciar Sesión";
            btn_IniciarSesion.UseVisualStyleBackColor = true;
            btn_IniciarSesion.Click += btn_IniciarSesion_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(474, 49);
            label1.Name = "label1";
            label1.Size = new Size(275, 45);
            label1.TabIndex = 14;
            label1.Text = "Iniciar Sesion";
            label1.Click += label1_Click;
            // 
            // View_IniciarSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(label1);
            Controls.Add(lbl_IniciarSesion_Usuario);
            Controls.Add(txt_IniciarSesion_Usuario);
            Controls.Add(lbl_IniciarSesion_Contrasenia);
            Controls.Add(txt_IniciarSesion_Contrasenia);
            Controls.Add(btn_IniciarSesion);
            Name = "View_IniciarSesion";
            Size = new Size(1256, 610);
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
        private Label lbl_IniciarSesion_Usuario;
        private TextBox txt_IniciarSesion_Usuario;
        private Label lbl_IniciarSesion_Contrasenia;
        private TextBox txt_IniciarSesion_Contrasenia;
        private Button btn_IniciarSesion;
        private Label label1;
    }
}
