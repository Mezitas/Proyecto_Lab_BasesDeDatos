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
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.RosyBrown;
            panelContenido.Location = new Point(311, 12);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(957, 696);
            panelContenido.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(1280, 720);
            Controls.Add(panelContenido);
            Name = "FormMain";
            Text = "Gimnasio";
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenido;
    }
}
