namespace Proyecto_Lab_BasesDeDatos
{
    partial class View_Usuario_Membresia
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
            lblUsuarioMembresia_Titulo = new Label();
            lblUsuarioMembresia_ID = new Label();
            txtUsuarioMembresia_ID = new TextBox();
            lblUsuarioMembresia_IDUsuario = new Label();
            txtUsuarioMembresia_IDUsuario = new TextBox();
            lblUsuarioMembresia_IDMembresia = new Label();
            cmbUsuarioMembresia_IDMembresia = new ComboBox();
            lblUsuarioMembresia_FechaInicio = new Label();
            dtpUsuarioMembresia_FechaInicio = new DateTimePicker();
            lblUsuarioMembresia_FechaFin = new Label();
            dtpUsuarioMembresia_FechaFin = new DateTimePicker();
            lblUsuarioMembresia_Estado = new Label();
            cmbUsuarioMembresia_Estado = new ComboBox();
            lblUsuarioMembresia_Observaciones = new Label();
            txtUsuarioMembresia_Observaciones = new TextBox();
            btnUsuarioMembresia_Guardar = new Button();
            SuspendLayout();
            // 
            // lblUsuarioMembresia_Titulo
            // 
            lblUsuarioMembresia_Titulo.AutoSize = true;
            lblUsuarioMembresia_Titulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblUsuarioMembresia_Titulo.Location = new Point(20, 20);
            lblUsuarioMembresia_Titulo.Name = "lblUsuarioMembresia_Titulo";
            lblUsuarioMembresia_Titulo.Size = new Size(426, 41);
            lblUsuarioMembresia_Titulo.TabIndex = 0;
            lblUsuarioMembresia_Titulo.Text = "Gestión Usuario - Membresía";
            // 
            // lblUsuarioMembresia_ID
            // 
            lblUsuarioMembresia_ID.AutoSize = true;
            lblUsuarioMembresia_ID.Location = new Point(30, 100);
            lblUsuarioMembresia_ID.Name = "lblUsuarioMembresia_ID";
            lblUsuarioMembresia_ID.Size = new Size(104, 15);
            lblUsuarioMembresia_ID.TabIndex = 1;
            lblUsuarioMembresia_ID.Text = "ID Usuario-Memb:";
            // 
            // txtUsuarioMembresia_ID
            // 
            txtUsuarioMembresia_ID.Location = new Point(220, 97);
            txtUsuarioMembresia_ID.Name = "txtUsuarioMembresia_ID";
            txtUsuarioMembresia_ID.ReadOnly = true;
            txtUsuarioMembresia_ID.Size = new Size(180, 23);
            txtUsuarioMembresia_ID.TabIndex = 2;
            // 
            // lblUsuarioMembresia_IDUsuario
            // 
            lblUsuarioMembresia_IDUsuario.AutoSize = true;
            lblUsuarioMembresia_IDUsuario.Location = new Point(30, 150);
            lblUsuarioMembresia_IDUsuario.Name = "lblUsuarioMembresia_IDUsuario";
            lblUsuarioMembresia_IDUsuario.Size = new Size(64, 15);
            lblUsuarioMembresia_IDUsuario.TabIndex = 3;
            lblUsuarioMembresia_IDUsuario.Text = "ID Usuario:";
            // 
            // txtUsuarioMembresia_IDUsuario
            // 
            txtUsuarioMembresia_IDUsuario.Location = new Point(220, 147);
            txtUsuarioMembresia_IDUsuario.Name = "txtUsuarioMembresia_IDUsuario";
            txtUsuarioMembresia_IDUsuario.Size = new Size(180, 23);
            txtUsuarioMembresia_IDUsuario.TabIndex = 4;
            // 
            // lblUsuarioMembresia_IDMembresia
            // 
            lblUsuarioMembresia_IDMembresia.AutoSize = true;
            lblUsuarioMembresia_IDMembresia.Location = new Point(30, 200);
            lblUsuarioMembresia_IDMembresia.Name = "lblUsuarioMembresia_IDMembresia";
            lblUsuarioMembresia_IDMembresia.Size = new Size(83, 15);
            lblUsuarioMembresia_IDMembresia.TabIndex = 5;
            lblUsuarioMembresia_IDMembresia.Text = "ID Membresía:";
            // 
            // cmbUsuarioMembresia_IDMembresia
            // 
            cmbUsuarioMembresia_IDMembresia.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuarioMembresia_IDMembresia.Items.AddRange(new object[] { "Básica", "Premium", "VIP", "Entrenamiento Personal" });
            cmbUsuarioMembresia_IDMembresia.Location = new Point(220, 197);
            cmbUsuarioMembresia_IDMembresia.Name = "cmbUsuarioMembresia_IDMembresia";
            cmbUsuarioMembresia_IDMembresia.Size = new Size(200, 23);
            cmbUsuarioMembresia_IDMembresia.TabIndex = 6;
            // 
            // lblUsuarioMembresia_FechaInicio
            // 
            lblUsuarioMembresia_FechaInicio.AutoSize = true;
            lblUsuarioMembresia_FechaInicio.Location = new Point(30, 250);
            lblUsuarioMembresia_FechaInicio.Name = "lblUsuarioMembresia_FechaInicio";
            lblUsuarioMembresia_FechaInicio.Size = new Size(73, 15);
            lblUsuarioMembresia_FechaInicio.TabIndex = 7;
            lblUsuarioMembresia_FechaInicio.Text = "Fecha Inicio:";
            // 
            // dtpUsuarioMembresia_FechaInicio
            // 
            dtpUsuarioMembresia_FechaInicio.Format = DateTimePickerFormat.Short;
            dtpUsuarioMembresia_FechaInicio.Location = new Point(220, 247);
            dtpUsuarioMembresia_FechaInicio.Name = "dtpUsuarioMembresia_FechaInicio";
            dtpUsuarioMembresia_FechaInicio.Size = new Size(150, 23);
            dtpUsuarioMembresia_FechaInicio.TabIndex = 8;
            // 
            // lblUsuarioMembresia_FechaFin
            // 
            lblUsuarioMembresia_FechaFin.AutoSize = true;
            lblUsuarioMembresia_FechaFin.Location = new Point(30, 300);
            lblUsuarioMembresia_FechaFin.Name = "lblUsuarioMembresia_FechaFin";
            lblUsuarioMembresia_FechaFin.Size = new Size(60, 15);
            lblUsuarioMembresia_FechaFin.TabIndex = 9;
            lblUsuarioMembresia_FechaFin.Text = "Fecha Fin:";
            // 
            // dtpUsuarioMembresia_FechaFin
            // 
            dtpUsuarioMembresia_FechaFin.Format = DateTimePickerFormat.Short;
            dtpUsuarioMembresia_FechaFin.Location = new Point(220, 297);
            dtpUsuarioMembresia_FechaFin.Name = "dtpUsuarioMembresia_FechaFin";
            dtpUsuarioMembresia_FechaFin.Size = new Size(150, 23);
            dtpUsuarioMembresia_FechaFin.TabIndex = 10;
            // 
            // lblUsuarioMembresia_Estado
            // 
            lblUsuarioMembresia_Estado.AutoSize = true;
            lblUsuarioMembresia_Estado.Location = new Point(30, 350);
            lblUsuarioMembresia_Estado.Name = "lblUsuarioMembresia_Estado";
            lblUsuarioMembresia_Estado.Size = new Size(45, 15);
            lblUsuarioMembresia_Estado.TabIndex = 11;
            lblUsuarioMembresia_Estado.Text = "Estado:";
            // 
            // cmbUsuarioMembresia_Estado
            // 
            cmbUsuarioMembresia_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUsuarioMembresia_Estado.Items.AddRange(new object[] { "Activa", "Vencida", "Suspendida" });
            cmbUsuarioMembresia_Estado.Location = new Point(220, 347);
            cmbUsuarioMembresia_Estado.Name = "cmbUsuarioMembresia_Estado";
            cmbUsuarioMembresia_Estado.Size = new Size(180, 23);
            cmbUsuarioMembresia_Estado.TabIndex = 12;
            // 
            // lblUsuarioMembresia_Observaciones
            // 
            lblUsuarioMembresia_Observaciones.AutoSize = true;
            lblUsuarioMembresia_Observaciones.Location = new Point(30, 400);
            lblUsuarioMembresia_Observaciones.Name = "lblUsuarioMembresia_Observaciones";
            lblUsuarioMembresia_Observaciones.Size = new Size(87, 15);
            lblUsuarioMembresia_Observaciones.TabIndex = 13;
            lblUsuarioMembresia_Observaciones.Text = "Observaciones:";
            // 
            // txtUsuarioMembresia_Observaciones
            // 
            txtUsuarioMembresia_Observaciones.Location = new Point(220, 397);
            txtUsuarioMembresia_Observaciones.Multiline = true;
            txtUsuarioMembresia_Observaciones.Name = "txtUsuarioMembresia_Observaciones";
            txtUsuarioMembresia_Observaciones.Size = new Size(300, 80);
            txtUsuarioMembresia_Observaciones.TabIndex = 14;
            // 
            // btnUsuarioMembresia_Guardar
            // 
            btnUsuarioMembresia_Guardar.Location = new Point(220, 500);
            btnUsuarioMembresia_Guardar.Name = "btnUsuarioMembresia_Guardar";
            btnUsuarioMembresia_Guardar.Size = new Size(180, 40);
            btnUsuarioMembresia_Guardar.TabIndex = 15;
            btnUsuarioMembresia_Guardar.Text = "Guardar Cambios";
            btnUsuarioMembresia_Guardar.UseVisualStyleBackColor = true;
            // 
            // View_Usuario_Membresia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(lblUsuarioMembresia_Titulo);
            Controls.Add(lblUsuarioMembresia_ID);
            Controls.Add(txtUsuarioMembresia_ID);
            Controls.Add(lblUsuarioMembresia_IDUsuario);
            Controls.Add(txtUsuarioMembresia_IDUsuario);
            Controls.Add(lblUsuarioMembresia_IDMembresia);
            Controls.Add(cmbUsuarioMembresia_IDMembresia);
            Controls.Add(lblUsuarioMembresia_FechaInicio);
            Controls.Add(dtpUsuarioMembresia_FechaInicio);
            Controls.Add(lblUsuarioMembresia_FechaFin);
            Controls.Add(dtpUsuarioMembresia_FechaFin);
            Controls.Add(lblUsuarioMembresia_Estado);
            Controls.Add(cmbUsuarioMembresia_Estado);
            Controls.Add(lblUsuarioMembresia_Observaciones);
            Controls.Add(txtUsuarioMembresia_Observaciones);
            Controls.Add(btnUsuarioMembresia_Guardar);
            Name = "View_Usuario_Membresia";
            Size = new Size(957, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblUsuarioMembresia_Titulo;
        private Label lblUsuarioMembresia_ID;
        private TextBox txtUsuarioMembresia_ID;
        private Label lblUsuarioMembresia_IDUsuario;
        private TextBox txtUsuarioMembresia_IDUsuario;
        private Label lblUsuarioMembresia_IDMembresia;
        private ComboBox cmbUsuarioMembresia_IDMembresia;
        private Label lblUsuarioMembresia_FechaInicio;
        private DateTimePicker dtpUsuarioMembresia_FechaInicio;
        private Label lblUsuarioMembresia_FechaFin;
        private DateTimePicker dtpUsuarioMembresia_FechaFin;
        private Label lblUsuarioMembresia_Estado;
        private ComboBox cmbUsuarioMembresia_Estado;
        private Label lblUsuarioMembresia_Observaciones;
        private TextBox txtUsuarioMembresia_Observaciones;
        private Button btnUsuarioMembresia_Guardar;
    }
}
