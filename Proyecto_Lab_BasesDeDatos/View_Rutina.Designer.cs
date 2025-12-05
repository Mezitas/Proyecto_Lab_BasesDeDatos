namespace Proyecto_Lab_BasesDeDatos
{
    partial class View_Rutina
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
            lblIdRutina = new Label();
            lblIdMRutina = new TextBox();
            lblIdPlan = new Label();
            lblIdMPlan = new TextBox();
            lblDiaSemana = new Label();
            cbDiaSemana = new ComboBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            dgvRutinas = new DataGridView();
            btnCrear = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRutinas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(310, 15);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(178, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Rutinas";
            // 
            // lblIdRutina
            // 
            lblIdRutina.AutoSize = true;
            lblIdRutina.Font = new Font("Segoe UI", 10F);
            lblIdRutina.Location = new Point(40, 70);
            lblIdRutina.Name = "lblIdRutina";
            lblIdRutina.Size = new Size(69, 19);
            lblIdRutina.TabIndex = 1;
            lblIdRutina.Text = "ID Rutina:";
            // 
            // lblIdMRutina
            // 
            lblIdMRutina.Font = new Font("Segoe UI", 10F);
            lblIdMRutina.Location = new Point(180, 68);
            lblIdMRutina.Name = "lblIdMRutina";
            lblIdMRutina.Size = new Size(200, 25);
            lblIdMRutina.TabIndex = 2;
            // 
            // lblIdPlan
            // 
            lblIdPlan.AutoSize = true;
            lblIdPlan.Font = new Font("Segoe UI", 10F);
            lblIdPlan.Location = new Point(40, 115);
            lblIdPlan.Name = "lblIdPlan";
            lblIdPlan.Size = new Size(150, 19);
            lblIdPlan.TabIndex = 3;
            lblIdPlan.Text = "ID Plan Entrenamiento:";
            // 
            // lblIdMPlan
            // 
            lblIdMPlan.Font = new Font("Segoe UI", 10F);
            lblIdMPlan.Location = new Point(240, 113);
            lblIdMPlan.Name = "lblIdMPlan";
            lblIdMPlan.Size = new Size(200, 25);
            lblIdMPlan.TabIndex = 4;
            // 
            // lblDiaSemana
            // 
            lblDiaSemana.AutoSize = true;
            lblDiaSemana.Font = new Font("Segoe UI", 10F);
            lblDiaSemana.Location = new Point(40, 160);
            lblDiaSemana.Name = "lblDiaSemana";
            lblDiaSemana.Size = new Size(103, 19);
            lblDiaSemana.TabIndex = 5;
            lblDiaSemana.Text = "Día de Semana:";
            // 
            // cbDiaSemana
            // 
            cbDiaSemana.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDiaSemana.Font = new Font("Segoe UI", 10F);
            cbDiaSemana.FormattingEnabled = true;
            cbDiaSemana.Items.AddRange(new object[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" });
            cbDiaSemana.Location = new Point(180, 158);
            cbDiaSemana.Name = "cbDiaSemana";
            cbDiaSemana.Size = new Size(200, 25);
            cbDiaSemana.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.Location = new Point(40, 205);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(82, 19);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 10F);
            txtDescripcion.Location = new Point(180, 205);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(300, 80);
            txtDescripcion.TabIndex = 8;
            // 
            // dgvRutinas
            // 
            dgvRutinas.AllowUserToAddRows = false;
            dgvRutinas.AllowUserToDeleteRows = false;
            dgvRutinas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRutinas.Location = new Point(40, 320);
            dgvRutinas.Name = "dgvRutinas";
            dgvRutinas.ReadOnly = true;
            dgvRutinas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRutinas.Size = new Size(720, 250);
            dgvRutinas.TabIndex = 9;
            // 
            // btnCrear
            // 
            btnCrear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCrear.Location = new Point(520, 70);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(150, 40);
            btnCrear.TabIndex = 10;
            btnCrear.Text = "Crear Rutina";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnActualizar.Location = new Point(520, 120);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(150, 40);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminar.Location = new Point(520, 170);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 40);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLimpiar.Location = new Point(520, 220);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(150, 40);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // View_Rutina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnCrear);
            Controls.Add(dgvRutinas);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(cbDiaSemana);
            Controls.Add(lblDiaSemana);
            Controls.Add(lblIdMPlan);
            Controls.Add(lblIdPlan);
            Controls.Add(lblIdMRutina);
            Controls.Add(lblIdRutina);
            Controls.Add(lblTitulo);
            Name = "View_Rutina";
            Size = new Size(957, 650);
            ((System.ComponentModel.ISupportInitialize)dgvRutinas).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Label lblTitulo;
        private Label lblIdRutina;
        private TextBox lblIdMRutina;
        private Label lblIdPlan;
        private TextBox lblIdMPlan;
        private Label lblDiaSemana;
        private ComboBox cbDiaSemana;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private DataGridView dgvRutinas;
        private Button btnCrear;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
    }
}
