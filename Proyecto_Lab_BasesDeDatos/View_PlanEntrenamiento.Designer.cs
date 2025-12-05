namespace Proyecto_Lab_BasesDeDatos
{
    partial class View_PlanEntrenamiento
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
            labelTitulo = new Label();
            labelCodigo = new Label();
            txtCodigoPlan = new TextBox();
            labelObjetivo = new Label();
            txtObjetivo = new TextBox();
            labelIntensidad = new Label();
            cmbIntensidad = new ComboBox();
            labelEntrenador = new Label();
            cmbEntrenador = new ComboBox();
            labelFechaInicio = new Label();
            dtpFechaInicio = new DateTimePicker();
            labelFechaFin = new Label();
            dtpFechaFin = new DateTimePicker();
            btnCrear = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvPlanes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            labelTitulo.Location = new Point(20, 20);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(215, 25);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Plan de Entrenamiento";
            // 
            // labelCodigo
            // 
            labelCodigo.AutoSize = true;
            labelCodigo.Location = new Point(20, 80);
            labelCodigo.Name = "labelCodigo";
            labelCodigo.Size = new Size(94, 15);
            labelCodigo.TabIndex = 1;
            labelCodigo.Text = "Código del Plan:";
            // 
            // txtCodigoPlan
            // 
            txtCodigoPlan.Location = new Point(160, 77);
            txtCodigoPlan.Name = "txtCodigoPlan";
            txtCodigoPlan.Size = new Size(200, 23);
            txtCodigoPlan.TabIndex = 2;
            // 
            // labelObjetivo
            // 
            labelObjetivo.AutoSize = true;
            labelObjetivo.Location = new Point(20, 125);
            labelObjetivo.Name = "labelObjetivo";
            labelObjetivo.Size = new Size(55, 15);
            labelObjetivo.TabIndex = 3;
            labelObjetivo.Text = "Objetivo:";
            // 
            // txtObjetivo
            // 
            txtObjetivo.Location = new Point(160, 122);
            txtObjetivo.Name = "txtObjetivo";
            txtObjetivo.Size = new Size(300, 23);
            txtObjetivo.TabIndex = 4;
            // 
            // labelIntensidad
            // 
            labelIntensidad.AutoSize = true;
            labelIntensidad.Location = new Point(20, 170);
            labelIntensidad.Name = "labelIntensidad";
            labelIntensidad.Size = new Size(65, 15);
            labelIntensidad.TabIndex = 5;
            labelIntensidad.Text = "Intensidad:";
            // 
            // cmbIntensidad
            // 
            cmbIntensidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIntensidad.FormattingEnabled = true;
            cmbIntensidad.Items.AddRange(new object[] { "Baja", "Media", "Alta" });
            cmbIntensidad.Location = new Point(160, 167);
            cmbIntensidad.Name = "cmbIntensidad";
            cmbIntensidad.Size = new Size(200, 23);
            cmbIntensidad.TabIndex = 6;
            // 
            // labelEntrenador
            // 
            labelEntrenador.AutoSize = true;
            labelEntrenador.Location = new Point(20, 215);
            labelEntrenador.Name = "labelEntrenador";
            labelEntrenador.Size = new Size(68, 15);
            labelEntrenador.TabIndex = 7;
            labelEntrenador.Text = "Entrenador:";
            // 
            // cmbEntrenador
            // 
            cmbEntrenador.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEntrenador.FormattingEnabled = true;
            cmbEntrenador.Location = new Point(160, 212);
            cmbEntrenador.Name = "cmbEntrenador";
            cmbEntrenador.Size = new Size(250, 23);
            cmbEntrenador.TabIndex = 8;
            // 
            // labelFechaInicio
            // 
            labelFechaInicio.AutoSize = true;
            labelFechaInicio.Location = new Point(20, 260);
            labelFechaInicio.Name = "labelFechaInicio";
            labelFechaInicio.Size = new Size(73, 15);
            labelFechaInicio.TabIndex = 9;
            labelFechaInicio.Text = "Fecha Inicio:";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(160, 257);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 23);
            dtpFechaInicio.TabIndex = 10;
            // 
            // labelFechaFin
            // 
            labelFechaFin.AutoSize = true;
            labelFechaFin.Location = new Point(20, 305);
            labelFechaFin.Name = "labelFechaFin";
            labelFechaFin.Size = new Size(60, 15);
            labelFechaFin.TabIndex = 11;
            labelFechaFin.Text = "Fecha Fin:";
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(160, 302);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(250, 23);
            dtpFechaFin.TabIndex = 12;
            // 
            // btnCrear
            // 
            btnCrear.BackColor = Color.FromArgb(46, 204, 113);
            btnCrear.FlatStyle = FlatStyle.Flat;
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(20, 360);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(120, 35);
            btnCrear.TabIndex = 13;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = false;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(52, 152, 219);
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(160, 360);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(120, 35);
            btnActualizar.TabIndex = 14;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(231, 76, 60);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(300, 360);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(120, 35);
            btnEliminar.TabIndex = 15;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(149, 165, 166);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(440, 360);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 35);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvPlanes
            // 
            dgvPlanes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanes.Location = new Point(20, 420);
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.RowHeadersWidth = 51;
            dgvPlanes.Size = new Size(900, 350);
            dgvPlanes.TabIndex = 17;
            // 
            // View_PlanEntrenamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(labelTitulo);
            Controls.Add(labelCodigo);
            Controls.Add(txtCodigoPlan);
            Controls.Add(labelObjetivo);
            Controls.Add(txtObjetivo);
            Controls.Add(labelIntensidad);
            Controls.Add(cmbIntensidad);
            Controls.Add(labelEntrenador);
            Controls.Add(cmbEntrenador);
            Controls.Add(labelFechaInicio);
            Controls.Add(dtpFechaInicio);
            Controls.Add(labelFechaFin);
            Controls.Add(dtpFechaFin);
            Controls.Add(btnCrear);
            Controls.Add(btnActualizar);
            Controls.Add(btnEliminar);
            Controls.Add(btnLimpiar);
            Controls.Add(dgvPlanes);
            Name = "View_PlanEntrenamiento";
            Size = new Size(957, 650);
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitulo;
        private Label labelCodigo;
        private TextBox txtCodigoPlan;
        private Label labelObjetivo;
        private TextBox txtObjetivo;
        private Label labelIntensidad;
        private ComboBox cmbIntensidad;
        private Label labelEntrenador;
        private ComboBox cmbEntrenador;
        private Label labelFechaInicio;
        private DateTimePicker dtpFechaInicio;
        private Label labelFechaFin;
        private DateTimePicker dtpFechaFin;
        private Button btnCrear;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvPlanes;
    }
}
