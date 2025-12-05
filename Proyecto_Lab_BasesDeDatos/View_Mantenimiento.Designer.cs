namespace Proyecto_Lab_BasesDeDatos
{
    partial class View_Mantenimiento
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
            lblIdM = new TextBox();
            lblMaquina = new Label();
            cmbMaquina = new ComboBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblCosto = new Label();
            txtCosto = new TextBox();
            lblTecnico = new Label();
            txtTecnico = new TextBox();
            lblEstado = new Label();
            cmbEstado = new ComboBox();
            dgvMantenimientos = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimientos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(22, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(289, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Mantenimiento";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(22, 60);
            lblId.Name = "lblId";
            lblId.Size = new Size(103, 15);
            lblId.TabIndex = 1;
            lblId.Text = "ID Mantenimiento";
            // 
            // lblIdM
            // 
            lblIdM.BorderStyle = BorderStyle.FixedSingle;
            lblIdM.Location = new Point(25, 80);
            lblIdM.Name = "lblIdM";
            lblIdM.ReadOnly = true;
            lblIdM.Size = new Size(120, 23);
            lblIdM.TabIndex = 2;
            // 
            // lblMaquina
            // 
            lblMaquina.AutoSize = true;
            lblMaquina.Location = new Point(22, 115);
            lblMaquina.Name = "lblMaquina";
            lblMaquina.Size = new Size(54, 15);
            lblMaquina.TabIndex = 3;
            lblMaquina.Text = "Máquina";
            // 
            // cmbMaquina
            // 
            cmbMaquina.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaquina.FormattingEnabled = true;
            cmbMaquina.Location = new Point(25, 135);
            cmbMaquina.Name = "cmbMaquina";
            cmbMaquina.Size = new Size(220, 23);
            cmbMaquina.TabIndex = 4;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(22, 170);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(38, 15);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(25, 190);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(220, 23);
            dtpFecha.TabIndex = 6;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(22, 225);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(31, 15);
            lblTipo.TabIndex = 7;
            lblTipo.Text = "Tipo";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Preventivo", "Correctivo", "Emergente" });
            cmbTipo.Location = new Point(25, 245);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(170, 23);
            cmbTipo.TabIndex = 8;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(22, 280);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 9;
            lblDescripcion.Text = "Descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Location = new Point(25, 300);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(260, 60);
            txtDescripcion.TabIndex = 10;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Location = new Point(22, 370);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(38, 15);
            lblCosto.TabIndex = 11;
            lblCosto.Text = "Costo";
            // 
            // txtCosto
            // 
            txtCosto.BorderStyle = BorderStyle.FixedSingle;
            txtCosto.Location = new Point(25, 390);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(120, 23);
            txtCosto.TabIndex = 12;
            // 
            // lblTecnico
            // 
            lblTecnico.AutoSize = true;
            lblTecnico.Location = new Point(170, 370);
            lblTecnico.Name = "lblTecnico";
            lblTecnico.Size = new Size(48, 15);
            lblTecnico.TabIndex = 13;
            lblTecnico.Text = "Técnico";
            // 
            // txtTecnico
            // 
            txtTecnico.BorderStyle = BorderStyle.FixedSingle;
            txtTecnico.Location = new Point(173, 390);
            txtTecnico.Name = "txtTecnico";
            txtTecnico.Size = new Size(140, 23);
            txtTecnico.TabIndex = 14;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(22, 430);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 15;
            lblEstado.Text = "Estado";
            // 
            // cmbEstado
            // 
            cmbEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Completado", "Pendiente", "En proceso" });
            cmbEstado.Location = new Point(25, 450);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(170, 23);
            cmbEstado.TabIndex = 16;
            // 
            // dgvMantenimientos
            // 
            dgvMantenimientos.AllowUserToAddRows = false;
            dgvMantenimientos.AllowUserToDeleteRows = false;
            dgvMantenimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenimientos.Location = new Point(320, 60);
            dgvMantenimientos.Name = "dgvMantenimientos";
            dgvMantenimientos.ReadOnly = true;
            dgvMantenimientos.Size = new Size(520, 400);
            dgvMantenimientos.TabIndex = 17;
            dgvMantenimientos.CellContentClick += dgvMantenimientos_CellContentClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(25, 500);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(90, 30);
            btnAgregar.TabIndex = 18;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(130, 500);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(90, 30);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(235, 500);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(90, 30);
            btnEliminar.TabIndex = 20;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // View_Mantenimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvMantenimientos);
            Controls.Add(cmbEstado);
            Controls.Add(lblEstado);
            Controls.Add(txtTecnico);
            Controls.Add(lblTecnico);
            Controls.Add(txtCosto);
            Controls.Add(lblCosto);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(cmbMaquina);
            Controls.Add(lblMaquina);
            Controls.Add(lblIdM);
            Controls.Add(lblId);
            Controls.Add(lblTitulo);
            Name = "View_Mantenimiento";
            Size = new Size(957, 650);
            ((System.ComponentModel.ISupportInitialize)dgvMantenimientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox lblIdM;
        private System.Windows.Forms.Label lblMaquina;
        private System.Windows.Forms.ComboBox cmbMaquina;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblTecnico;
        private System.Windows.Forms.TextBox txtTecnico;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DataGridView dgvMantenimientos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
    }
}
