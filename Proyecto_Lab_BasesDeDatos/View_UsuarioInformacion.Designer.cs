namespace Proyecto_Lab_BasesDeDatos
{
    partial class View_UsuarioInformacion
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
            lblTitulo = new Label();
            lblId = new Label();
            lblNombre = new Label();
            lblFechaNac = new Label();
            lblGenero = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblIdM = new Label();
            txtNombre = new TextBox();
            txtFechaNacimiento = new TextBox();
            txtGenero = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(289, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(232, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Información Personal";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 11F);
            lblId.Location = new Point(309, 89);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 1;
            lblId.Text = "ID";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 11F);
            lblNombre.Location = new Point(309, 134);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(132, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre completo";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Font = new Font("Segoe UI", 11F);
            lblFechaNac.Location = new Point(309, 179);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(128, 20);
            lblFechaNac.TabIndex = 5;
            lblFechaNac.Text = "Fecha Nacimiento";
            // 
            // lblGenero
            // 
            lblGenero.AutoSize = true;
            lblGenero.Font = new Font("Segoe UI", 11F);
            lblGenero.Location = new Point(309, 224);
            lblGenero.Name = "lblGenero";
            lblGenero.Size = new Size(57, 20);
            lblGenero.TabIndex = 7;
            lblGenero.Text = "Género";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 11F);
            lblDireccion.Location = new Point(309, 269);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(72, 20);
            lblDireccion.TabIndex = 9;
            lblDireccion.Text = "Dirección";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 11F);
            lblTelefono.Location = new Point(309, 314);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 11;
            lblTelefono.Text = "Teléfono";
            // 
            // lblIdM
            // 
            lblIdM.Font = new Font("Segoe UI", 11F);
            lblIdM.Location = new Point(489, 86);
            lblIdM.Name = "lblIdM";
            lblIdM.Size = new Size(280, 27);
            lblIdM.TabIndex = 2;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11F);
            txtNombre.Location = new Point(489, 131);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(280, 27);
            txtNombre.TabIndex = 4;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Font = new Font("Segoe UI", 11F);
            txtFechaNacimiento.Location = new Point(489, 176);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(280, 27);
            txtFechaNacimiento.TabIndex = 6;
            // 
            // txtGenero
            // 
            txtGenero.Font = new Font("Segoe UI", 11F);
            txtGenero.Location = new Point(489, 221);
            txtGenero.Name = "txtGenero";
            txtGenero.Size = new Size(280, 27);
            txtGenero.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Font = new Font("Segoe UI", 11F);
            txtDireccion.Location = new Point(489, 266);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(280, 27);
            txtDireccion.TabIndex = 10;
            // 
            // txtTelefono
            // 
            txtTelefono.Font = new Font("Segoe UI", 11F);
            txtTelefono.Location = new Point(489, 311);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(280, 27);
            txtTelefono.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnGuardar.Location = new Point(408, 374);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(140, 40);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // View_UsuarioInformacion
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.RosyBrown;
            Controls.Add(btnGuardar);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtGenero);
            Controls.Add(lblGenero);
            Controls.Add(txtFechaNacimiento);
            Controls.Add(lblFechaNac);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblIdM);
            Controls.Add(lblId);
            Controls.Add(lblTitulo);
            Name = "View_UsuarioInformacion";
            Size = new Size(957, 650);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTitulo;
        private Label lblId;
        private Label lblNombre;
        private Label lblFechaNac;
        private Label lblGenero;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblIdM;
        private TextBox txtNombre;
        private TextBox txtFechaNacimiento;
        private TextBox txtGenero;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private Button btnGuardar;
    }
}
