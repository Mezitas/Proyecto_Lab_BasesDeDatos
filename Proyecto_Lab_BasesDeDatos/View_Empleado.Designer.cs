namespace Proyecto_Lab_BasesDeDatos
{
    partial class View_Empleado
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
            this.lblEmpleado_Titulo = new Label();
            this.lblEmpleado_ID = new Label();
            this.txtEmpleado_ID = new TextBox();
            this.lblEmpleado_IDPersona = new Label();
            this.txtEmpleado_IDPersona = new TextBox();
            this.lblEmpleado_Cargo = new Label();
            this.txtEmpleado_Cargo = new TextBox();
            this.lblEmpleado_Salario = new Label();
            this.txtEmpleado_Salario = new TextBox();
            this.lblEmpleado_FechaIngreso = new Label();
            this.dtpEmpleado_FechaIngreso = new DateTimePicker();
            this.lblEmpleado_Estado = new Label();
            this.cmbEmpleado_Estado = new ComboBox();
            this.btnEmpleado_Guardar = new Button();

            this.SuspendLayout();

            //
            // lblEmpleado_Titulo
            //
            this.lblEmpleado_Titulo.AutoSize = true;
            this.lblEmpleado_Titulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblEmpleado_Titulo.Location = new Point(20, 20);
            this.lblEmpleado_Titulo.Name = "lblEmpleado_Titulo";
            this.lblEmpleado_Titulo.Size = new Size(310, 50);
            this.lblEmpleado_Titulo.Text = "Gestión Empleado";

            //
            // lblEmpleado_ID
            //
            this.lblEmpleado_ID.AutoSize = true;
            this.lblEmpleado_ID.Location = new Point(30, 100);
            this.lblEmpleado_ID.Name = "lblEmpleado_ID";
            this.lblEmpleado_ID.Size = new Size(113, 20);
            this.lblEmpleado_ID.Text = "ID Empleado:";

            //
            // txtEmpleado_ID
            //
            this.txtEmpleado_ID.Location = new Point(200, 97);
            this.txtEmpleado_ID.Name = "txtEmpleado_ID";
            this.txtEmpleado_ID.Size = new Size(180, 27);
            this.txtEmpleado_ID.ReadOnly = true;

            //
            // lblEmpleado_IDPersona
            //
            this.lblEmpleado_IDPersona.AutoSize = true;
            this.lblEmpleado_IDPersona.Location = new Point(30, 150);
            this.lblEmpleado_IDPersona.Name = "lblEmpleado_IDPersona";
            this.lblEmpleado_IDPersona.Size = new Size(89, 20);
            this.lblEmpleado_IDPersona.Text = "ID Persona:";

            //
            // txtEmpleado_IDPersona
            //
            this.txtEmpleado_IDPersona.Location = new Point(200, 147);
            this.txtEmpleado_IDPersona.Name = "txtEmpleado_IDPersona";
            this.txtEmpleado_IDPersona.Size = new Size(180, 27);

            //
            // lblEmpleado_Cargo
            //
            this.lblEmpleado_Cargo.AutoSize = true;
            this.lblEmpleado_Cargo.Location = new Point(30, 200);
            this.lblEmpleado_Cargo.Name = "lblEmpleado_Cargo";
            this.lblEmpleado_Cargo.Size = new Size(55, 20);
            this.lblEmpleado_Cargo.Text = "Cargo:";

            //
            // txtEmpleado_Cargo
            //
            this.txtEmpleado_Cargo.Location = new Point(200, 197);
            this.txtEmpleado_Cargo.Name = "txtEmpleado_Cargo";
            this.txtEmpleado_Cargo.Size = new Size(250, 27);

            //
            // lblEmpleado_Salario
            //
            this.lblEmpleado_Salario.AutoSize = true;
            this.lblEmpleado_Salario.Location = new Point(30, 250);
            this.lblEmpleado_Salario.Name = "lblEmpleado_Salario";
            this.lblEmpleado_Salario.Size = new Size(59, 20);
            this.lblEmpleado_Salario.Text = "Salario:";

            //
            // txtEmpleado_Salario
            //
            this.txtEmpleado_Salario.Location = new Point(200, 247);
            this.txtEmpleado_Salario.Name = "txtEmpleado_Salario";
            this.txtEmpleado_Salario.Size = new Size(180, 27);

            //
            // lblEmpleado_FechaIngreso
            //
            this.lblEmpleado_FechaIngreso.AutoSize = true;
            this.lblEmpleado_FechaIngreso.Location = new Point(30, 300);
            this.lblEmpleado_FechaIngreso.Name = "lblEmpleado_FechaIngreso";
            this.lblEmpleado_FechaIngreso.Size = new Size(119, 20);
            this.lblEmpleado_FechaIngreso.Text = "Fecha Ingreso:";

            //
            // dtpEmpleado_FechaIngreso
            //
            this.dtpEmpleado_FechaIngreso.Format = DateTimePickerFormat.Short;
            this.dtpEmpleado_FechaIngreso.Location = new Point(200, 297);
            this.dtpEmpleado_FechaIngreso.Name = "dtpEmpleado_FechaIngreso";
            this.dtpEmpleado_FechaIngreso.Size = new Size(150, 27);

            //
            // lblEmpleado_Estado
            //
            this.lblEmpleado_Estado.AutoSize = true;
            this.lblEmpleado_Estado.Location = new Point(30, 350);
            this.lblEmpleado_Estado.Name = "lblEmpleado_Estado";
            this.lblEmpleado_Estado.Size = new Size(59, 20);
            this.lblEmpleado_Estado.Text = "Estado:";

            //
            // cmbEmpleado_Estado
            //
            this.cmbEmpleado_Estado.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbEmpleado_Estado.Location = new Point(200, 347);
            this.cmbEmpleado_Estado.Name = "cmbEmpleado_Estado";
            this.cmbEmpleado_Estado.Size = new Size(180, 28);
            this.cmbEmpleado_Estado.Items.AddRange(new object[] {
                "Activo",
                "Inactivo"
            });

            //
            // btnEmpleado_Guardar
            //
            this.btnEmpleado_Guardar.Location = new Point(200, 410);
            this.btnEmpleado_Guardar.Name = "btnEmpleado_Guardar";
            this.btnEmpleado_Guardar.Size = new Size(150, 40);
            this.btnEmpleado_Guardar.Text = "Guardar Cambios";
            this.btnEmpleado_Guardar.UseVisualStyleBackColor = true;
            // 
            // View_Empleado
            // 
            this.Controls.Add(this.lblEmpleado_Titulo);
            this.Controls.Add(this.lblEmpleado_ID);
            this.Controls.Add(this.txtEmpleado_ID);
            this.Controls.Add(this.lblEmpleado_IDPersona);
            this.Controls.Add(this.txtEmpleado_IDPersona);
            this.Controls.Add(this.lblEmpleado_Cargo);
            this.Controls.Add(this.txtEmpleado_Cargo);
            this.Controls.Add(this.lblEmpleado_Salario);
            this.Controls.Add(this.txtEmpleado_Salario);
            this.Controls.Add(this.lblEmpleado_FechaIngreso);
            this.Controls.Add(this.dtpEmpleado_FechaIngreso);
            this.Controls.Add(this.lblEmpleado_Estado);
            this.Controls.Add(this.cmbEmpleado_Estado);
            this.Controls.Add(this.btnEmpleado_Guardar);
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            Name = "View_Empleado";
            Size = new Size(957, 650);
            ResumeLayout(false);

        }

        #endregion
        private Label lblEmpleado_Titulo;
        private Label lblEmpleado_ID;
        private TextBox txtEmpleado_ID;
        private Label lblEmpleado_IDPersona;
        private TextBox txtEmpleado_IDPersona;
        private Label lblEmpleado_Cargo;
        private TextBox txtEmpleado_Cargo;
        private Label lblEmpleado_Salario;
        private TextBox txtEmpleado_Salario;
        private Label lblEmpleado_FechaIngreso;
        private DateTimePicker dtpEmpleado_FechaIngreso;
        private Label lblEmpleado_Estado;
        private ComboBox cmbEmpleado_Estado;
        private Button btnEmpleado_Guardar;
    }
}
