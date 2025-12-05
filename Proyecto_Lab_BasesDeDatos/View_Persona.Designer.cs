namespace Proyecto_Lab_BasesDeDatos
{
    partial class View_Persona
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
            lblPersona_Titulo = new Label();
            lblPersona_ID = new Label();
            txtPersona_ID = new TextBox();
            lblPersona_Nombre = new Label();
            txtPersona_Nombre = new TextBox();
            lblPersona_Apellido = new Label();
            txtPersona_Apellido = new TextBox();
            lblPersona_Cedula = new Label();
            txtPersona_Cedula = new TextBox();
            lblPersona_Telefono = new Label();
            txtPersona_Telefono = new TextBox();
            lblPersona_Direccion = new Label();
            txtPersona_Direccion = new TextBox();
            lblPersona_Tipo = new Label();
            cmbPersona_Tipo = new ComboBox();
            lblPersona_FechaNac = new Label();
            dtpPersona_FechaNac = new DateTimePicker();
            btnPersona_Guardar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // lblPersona_Titulo
            // 
            lblPersona_Titulo.AutoSize = true;
            lblPersona_Titulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPersona_Titulo.Location = new Point(20, 20);
            lblPersona_Titulo.Name = "lblPersona_Titulo";
            lblPersona_Titulo.Size = new Size(243, 41);
            lblPersona_Titulo.TabIndex = 0;
            lblPersona_Titulo.Text = "Gestión Persona";
            // 
            // lblPersona_ID
            // 
            lblPersona_ID.AutoSize = true;
            lblPersona_ID.Location = new Point(30, 100);
            lblPersona_ID.Name = "lblPersona_ID";
            lblPersona_ID.Size = new Size(82, 15);
            lblPersona_ID.TabIndex = 1;
            lblPersona_ID.Text = "ID de Persona:";
            // 
            // txtPersona_ID
            // 
            txtPersona_ID.Location = new Point(200, 97);
            txtPersona_ID.Name = "txtPersona_ID";
            txtPersona_ID.ReadOnly = true;
            txtPersona_ID.Size = new Size(180, 23);
            txtPersona_ID.TabIndex = 2;
            // 
            // lblPersona_Nombre
            // 
            lblPersona_Nombre.AutoSize = true;
            lblPersona_Nombre.Location = new Point(30, 150);
            lblPersona_Nombre.Name = "lblPersona_Nombre";
            lblPersona_Nombre.Size = new Size(54, 15);
            lblPersona_Nombre.TabIndex = 3;
            lblPersona_Nombre.Text = "Nombre:";
            // 
            // txtPersona_Nombre
            // 
            txtPersona_Nombre.Location = new Point(200, 147);
            txtPersona_Nombre.Name = "txtPersona_Nombre";
            txtPersona_Nombre.Size = new Size(250, 23);
            txtPersona_Nombre.TabIndex = 4;
            // 
            // lblPersona_Apellido
            // 
            lblPersona_Apellido.AutoSize = true;
            lblPersona_Apellido.Location = new Point(30, 200);
            lblPersona_Apellido.Name = "lblPersona_Apellido";
            lblPersona_Apellido.Size = new Size(54, 15);
            lblPersona_Apellido.TabIndex = 5;
            lblPersona_Apellido.Text = "Apellido:";
            // 
            // txtPersona_Apellido
            // 
            txtPersona_Apellido.Location = new Point(200, 197);
            txtPersona_Apellido.Name = "txtPersona_Apellido";
            txtPersona_Apellido.Size = new Size(250, 23);
            txtPersona_Apellido.TabIndex = 6;
            // 
            // lblPersona_Cedula
            // 
            lblPersona_Cedula.AutoSize = true;
            lblPersona_Cedula.Location = new Point(30, 250);
            lblPersona_Cedula.Name = "lblPersona_Cedula";
            lblPersona_Cedula.Size = new Size(47, 15);
            lblPersona_Cedula.TabIndex = 7;
            lblPersona_Cedula.Text = "Cédula:";
            // 
            // txtPersona_Cedula
            // 
            txtPersona_Cedula.Location = new Point(200, 247);
            txtPersona_Cedula.Name = "txtPersona_Cedula";
            txtPersona_Cedula.Size = new Size(180, 23);
            txtPersona_Cedula.TabIndex = 8;
            // 
            // lblPersona_Telefono
            // 
            lblPersona_Telefono.AutoSize = true;
            lblPersona_Telefono.Location = new Point(30, 300);
            lblPersona_Telefono.Name = "lblPersona_Telefono";
            lblPersona_Telefono.Size = new Size(56, 15);
            lblPersona_Telefono.TabIndex = 9;
            lblPersona_Telefono.Text = "Teléfono:";
            // 
            // txtPersona_Telefono
            // 
            txtPersona_Telefono.Location = new Point(200, 297);
            txtPersona_Telefono.Name = "txtPersona_Telefono";
            txtPersona_Telefono.Size = new Size(180, 23);
            txtPersona_Telefono.TabIndex = 10;
            // 
            // lblPersona_Direccion
            // 
            lblPersona_Direccion.AutoSize = true;
            lblPersona_Direccion.Location = new Point(30, 350);
            lblPersona_Direccion.Name = "lblPersona_Direccion";
            lblPersona_Direccion.Size = new Size(60, 15);
            lblPersona_Direccion.TabIndex = 11;
            lblPersona_Direccion.Text = "Dirección:";
            // 
            // txtPersona_Direccion
            // 
            txtPersona_Direccion.Location = new Point(200, 347);
            txtPersona_Direccion.Multiline = true;
            txtPersona_Direccion.Name = "txtPersona_Direccion";
            txtPersona_Direccion.Size = new Size(300, 70);
            txtPersona_Direccion.TabIndex = 12;
            // 
            // lblPersona_Tipo
            // 
            lblPersona_Tipo.AutoSize = true;
            lblPersona_Tipo.Location = new Point(30, 440);
            lblPersona_Tipo.Name = "lblPersona_Tipo";
            lblPersona_Tipo.Size = new Size(79, 15);
            lblPersona_Tipo.TabIndex = 13;
            lblPersona_Tipo.Text = "Tipo Persona:";
            // 
            // cmbPersona_Tipo
            // 
            cmbPersona_Tipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPersona_Tipo.Items.AddRange(new object[] { "Administrador", "Empleado", "Cliente" });
            cmbPersona_Tipo.Location = new Point(200, 437);
            cmbPersona_Tipo.Name = "cmbPersona_Tipo";
            cmbPersona_Tipo.Size = new Size(200, 23);
            cmbPersona_Tipo.TabIndex = 14;
            // 
            // lblPersona_FechaNac
            // 
            lblPersona_FechaNac.AutoSize = true;
            lblPersona_FechaNac.Location = new Point(30, 490);
            lblPersona_FechaNac.Name = "lblPersona_FechaNac";
            lblPersona_FechaNac.Size = new Size(122, 15);
            lblPersona_FechaNac.TabIndex = 15;
            lblPersona_FechaNac.Text = "Fecha de Nacimiento:";
            // 
            // dtpPersona_FechaNac
            // 
            dtpPersona_FechaNac.Format = DateTimePickerFormat.Short;
            dtpPersona_FechaNac.Location = new Point(200, 487);
            dtpPersona_FechaNac.Name = "dtpPersona_FechaNac";
            dtpPersona_FechaNac.Size = new Size(150, 23);
            dtpPersona_FechaNac.TabIndex = 16;
            // 
            // btnPersona_Guardar
            // 
            btnPersona_Guardar.Location = new Point(200, 550);
            btnPersona_Guardar.Name = "btnPersona_Guardar";
            btnPersona_Guardar.Size = new Size(150, 40);
            btnPersona_Guardar.TabIndex = 17;
            btnPersona_Guardar.Text = "Guardar Cambios";
            btnPersona_Guardar.UseVisualStyleBackColor = true;
            btnPersona_Guardar.Click += btnPersona_Guardar_Click;
            // 
            // View_Persona
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(lblPersona_Titulo);
            Controls.Add(lblPersona_ID);
            Controls.Add(txtPersona_ID);
            Controls.Add(lblPersona_Nombre);
            Controls.Add(txtPersona_Nombre);
            Controls.Add(lblPersona_Apellido);
            Controls.Add(txtPersona_Apellido);
            Controls.Add(lblPersona_Cedula);
            Controls.Add(txtPersona_Cedula);
            Controls.Add(lblPersona_Telefono);
            Controls.Add(txtPersona_Telefono);
            Controls.Add(lblPersona_Direccion);
            Controls.Add(txtPersona_Direccion);
            Controls.Add(lblPersona_Tipo);
            Controls.Add(cmbPersona_Tipo);
            Controls.Add(lblPersona_FechaNac);
            Controls.Add(dtpPersona_FechaNac);
            Controls.Add(btnPersona_Guardar);
            Name = "View_Persona";
            Size = new Size(957, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPersona_Titulo;
        private Label lblPersona_ID;
        private TextBox txtPersona_ID;
        private Label lblPersona_Nombre;
        private TextBox txtPersona_Nombre;
        private Label lblPersona_Apellido;
        private TextBox txtPersona_Apellido;
        private Label lblPersona_Cedula;
        private TextBox txtPersona_Cedula;
        private Label lblPersona_Telefono;
        private TextBox txtPersona_Telefono;
        private Label lblPersona_Direccion;
        private TextBox txtPersona_Direccion;
        private Label lblPersona_Tipo;
        private ComboBox cmbPersona_Tipo;
        private Label lblPersona_FechaNac;
        private DateTimePicker dtpPersona_FechaNac;
        private Button btnPersona_Guardar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
