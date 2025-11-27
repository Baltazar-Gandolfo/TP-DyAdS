namespace TPIntegrador
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            button1 = new Button();
            loginUser = new TextBox();
            label1 = new Label();
            label2 = new Label();
            claveUser = new TextBox();
            lbl_registro = new LinkLabel();
            label3 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(376, 327);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(203, 60);
            button1.TabIndex = 0;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // loginUser
            // 
            loginUser.Location = new Point(291, 158);
            loginUser.Margin = new Padding(4, 5, 4, 5);
            loginUser.Name = "loginUser";
            loginUser.Size = new Size(285, 31);
            loginUser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 163);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 2;
            label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 218);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            // 
            // claveUser
            // 
            claveUser.Location = new Point(291, 213);
            claveUser.Margin = new Padding(4, 5, 4, 5);
            claveUser.Name = "claveUser";
            claveUser.Size = new Size(285, 31);
            claveUser.TabIndex = 3;
            // 
            // lbl_registro
            // 
            lbl_registro.AutoSize = true;
            lbl_registro.Location = new Point(199, 345);
            lbl_registro.Margin = new Padding(4, 0, 4, 0);
            lbl_registro.Name = "lbl_registro";
            lbl_registro.Size = new Size(90, 25);
            lbl_registro.TabIndex = 6;
            lbl_registro.TabStop = true;
            lbl_registro.Text = "Registrate";
            lbl_registro.LinkClicked += lbl_registro_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 283);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(41, 25);
            label3.TabIndex = 8;
            label3.Text = "Rol:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(291, 270);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 33);
            comboBox1.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 642);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(lbl_registro);
            Controls.Add(label2);
            Controls.Add(claveUser);
            Controls.Add(label1);
            Controls.Add(loginUser);
            Controls.Add(button1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox loginUser;
        private Label label1;
        private Label label2;
        private TextBox claveUser;
        private LinkLabel lbl_registro;
        private Label label3;
        private ComboBox comboBox1;
    }
}