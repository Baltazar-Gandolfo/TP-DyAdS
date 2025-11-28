namespace TPIntegrador
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox loginUser;
        private TextBox claveUser;
        private Button btnLogin;
        private ComboBox comboBox1;
        private Label labelUser;
        private Label labelPass;
        private Label labelRol;
        private LinkLabel lbl_registro;
        private Panel underlineUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            loginUser = new TextBox();
            claveUser = new TextBox();
            btnLogin = new Button();
            comboBox1 = new ComboBox();
            labelUser = new Label();
            labelPass = new Label();
            labelRol = new Label();
            lbl_registro = new LinkLabel();
            underlineUser = new Panel();
            panel1 = new Panel();
            underlinePass = new Panel();
            SuspendLayout();
            // 
            // loginUser
            // 
            loginUser.BackColor = Color.FromArgb(240, 240, 240);
            loginUser.BorderStyle = BorderStyle.None;
            loginUser.Font = new Font("Segoe UI", 12F);
            loginUser.Location = new Point(200, 97);
            loginUser.Name = "loginUser";
            loginUser.Size = new Size(350, 32);
            loginUser.TabIndex = 1;
            // 
            // claveUser
            // 
            claveUser.BorderStyle = BorderStyle.None;
            claveUser.Font = new Font("Segoe UI", 12F);
            claveUser.Location = new Point(200, 205);
            claveUser.Name = "claveUser";
            claveUser.Size = new Size(350, 32);
            claveUser.TabIndex = 4;
            claveUser.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.White;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.FromArgb(52, 143, 235);
            btnLogin.Location = new Point(256, 391);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 45);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F);
            comboBox1.ForeColor = Color.Black;
            comboBox1.Location = new Point(200, 310);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(350, 40);
            comboBox1.TabIndex = 7;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.BackColor = Color.Transparent;
            labelUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelUser.ForeColor = Color.Black;
            labelUser.Location = new Point(200, 48);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(238, 32);
            labelUser.TabIndex = 0;
            labelUser.Text = "Nombre de Usuario";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.BackColor = Color.Transparent;
            labelPass.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelPass.ForeColor = Color.Black;
            labelPass.Location = new Point(200, 161);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(143, 32);
            labelPass.TabIndex = 3;
            labelPass.Text = "Contraseña";
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.BackColor = Color.Transparent;
            labelRol.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelRol.ForeColor = Color.Black;
            labelRol.Location = new Point(200, 265);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(51, 32);
            labelRol.TabIndex = 6;
            labelRol.Text = "Rol";
            // 
            // lbl_registro
            // 
            lbl_registro.AutoSize = true;
            lbl_registro.BackColor = Color.Transparent;
            lbl_registro.Font = new Font("Segoe UI", 10F, FontStyle.Underline);
            lbl_registro.ForeColor = Color.White;
            lbl_registro.Location = new Point(306, 456);
            lbl_registro.Name = "lbl_registro";
            lbl_registro.Size = new Size(107, 28);
            lbl_registro.TabIndex = 8;
            lbl_registro.TabStop = true;
            lbl_registro.Text = "Registrarse";
            lbl_registro.LinkClicked += lbl_registro_LinkClicked;
            // 
            // underlineUser
            // 
            underlineUser.BackColor = Color.White;
            underlineUser.Location = new Point(200, 146);
            underlineUser.Name = "underlineUser";
            underlineUser.Size = new Size(350, 2);
            underlineUser.TabIndex = 2;
            underlineUser.Paint += underlineUser_Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(200, 252);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 2);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // underlinePass
            // 
            underlinePass.BackColor = Color.White;
            underlinePass.Location = new Point(200, 255);
            underlinePass.Name = "underlinePass";
            underlinePass.Size = new Size(350, 2);
            underlinePass.TabIndex = 5;
            // 
            // Login
            // 
            BackColor = Color.White;
            ClientSize = new Size(750, 520);
            Controls.Add(labelUser);
            Controls.Add(loginUser);
            Controls.Add(underlineUser);
            Controls.Add(labelPass);
            Controls.Add(claveUser);
            Controls.Add(underlinePass);
            Controls.Add(labelRol);
            Controls.Add(comboBox1);
            Controls.Add(lbl_registro);
            Controls.Add(btnLogin);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        private Panel underlinePass;
    }
}
