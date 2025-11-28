namespace TPIntegrador
{
    partial class BienvenidaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblMensaje;

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
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.Dock = DockStyle.Fill;
            lblMensaje.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblMensaje.ForeColor = Color.White;
            lblMensaje.Location = new Point(0, 0);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(525, 225);
            lblMensaje.TabIndex = 0;
            lblMensaje.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BienvenidaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(525, 225);
            Controls.Add(lblMensaje);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "BienvenidaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido";
            ResumeLayout(false);
        }

        #endregion

    }
}