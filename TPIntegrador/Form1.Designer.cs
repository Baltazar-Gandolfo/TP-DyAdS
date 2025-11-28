namespace TPIntegrador
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            comboLockerDelete = new ComboBox();
            label19 = new Label();
            label14 = new Label();
            label7 = new Label();
            pictureQr = new PictureBox();
            GenerarQR = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBoxLockers = new ComboBox();
            button5 = new Button();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            tabPage2 = new TabPage();
            button4 = new Button();
            label21 = new Label();
            label20 = new Label();
            comboResidente = new ComboBox();
            dataGridViewResidentes = new DataGridView();
            asociarLocker = new Button();
            label3 = new Label();
            comboTipoEnvio = new ComboBox();
            label2 = new Label();
            txtEmail = new TextBox();
            buttonEliminar = new Button();
            button7 = new Button();
            button8 = new Button();
            txtTelefono = new TextBox();
            txtDepto = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            tabPage3 = new TabPage();
            comboRepartidor = new ComboBox();
            label23 = new Label();
            label22 = new Label();
            button1 = new Button();
            textBoxNombreR = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtTelefonoR = new TextBox();
            checkBoxR = new CheckBox();
            buttonAltaRepartidor = new Button();
            buttonEditarRepartidor = new Button();
            buttonEliminarRepartidor = new Button();
            txtLegajoR = new TextBox();
            txtEmpresaR = new TextBox();
            txtApellidoR = new TextBox();
            label8 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            dataGridView3 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureQr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidentes).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(11, 1);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(896, 570);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(comboLockerDelete);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(pictureQr);
            tabPage1.Controls.Add(GenerarQR);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(comboBoxLockers);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(888, 542);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Lockers";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(742, 483);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(142, 55);
            button2.TabIndex = 33;
            button2.Text = "Cerrar Sesion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboLockerDelete
            // 
            comboLockerDelete.FormattingEnabled = true;
            comboLockerDelete.Location = new Point(89, 435);
            comboLockerDelete.Margin = new Padding(2);
            comboLockerDelete.Name = "comboLockerDelete";
            comboLockerDelete.Size = new Size(106, 23);
            comboLockerDelete.TabIndex = 63;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(26, 436);
            label19.Margin = new Padding(2, 0, 2, 0);
            label19.Name = "label19";
            label19.Size = new Size(42, 15);
            label19.TabIndex = 62;
            label19.Text = "Locker";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(26, 382);
            label14.Name = "label14";
            label14.Size = new Size(137, 25);
            label14.TabIndex = 61;
            label14.Text = "Eliminar Locker";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 214);
            label7.Name = "label7";
            label7.Size = new Size(108, 25);
            label7.TabIndex = 60;
            label7.Text = "Generar QR";
            // 
            // pictureQr
            // 
            pictureQr.Location = new Point(518, 215);
            pictureQr.Margin = new Padding(2);
            pictureQr.Name = "pictureQr";
            pictureQr.Size = new Size(185, 154);
            pictureQr.SizeMode = PictureBoxSizeMode.Zoom;
            pictureQr.TabIndex = 59;
            pictureQr.TabStop = false;
            // 
            // GenerarQR
            // 
            GenerarQR.Location = new Point(26, 331);
            GenerarQR.Margin = new Padding(2);
            GenerarQR.Name = "GenerarQR";
            GenerarQR.Size = new Size(314, 38);
            GenerarQR.TabIndex = 34;
            GenerarQR.Text = "Generar QR";
            GenerarQR.UseVisualStyleBackColor = true;
            GenerarQR.Click += GenerarQR_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 292);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(106, 23);
            textBox1.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 294);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 23;
            label1.Text = "Pin";
            // 
            // comboBoxLockers
            // 
            comboBoxLockers.FormattingEnabled = true;
            comboBoxLockers.Location = new Point(89, 254);
            comboBoxLockers.Margin = new Padding(2);
            comboBoxLockers.Name = "comboBoxLockers";
            comboBoxLockers.Size = new Size(106, 23);
            comboBoxLockers.TabIndex = 20;
            // 
            // button5
            // 
            button5.Location = new Point(26, 474);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Size = new Size(314, 38);
            button5.TabIndex = 19;
            button5.Text = "Eliminar";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 254);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 6;
            label6.Text = "Lockers";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 4);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(880, 198);
            dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label21);
            tabPage2.Controls.Add(label20);
            tabPage2.Controls.Add(comboResidente);
            tabPage2.Controls.Add(dataGridViewResidentes);
            tabPage2.Controls.Add(asociarLocker);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(comboTipoEnvio);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(txtEmail);
            tabPage2.Controls.Add(buttonEliminar);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(txtTelefono);
            tabPage2.Controls.Add(txtDepto);
            tabPage2.Controls.Add(txtApellido);
            tabPage2.Controls.Add(txtNombre);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label13);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(888, 542);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Residentes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(742, 483);
            button4.Name = "button4";
            button4.Size = new Size(142, 55);
            button4.TabIndex = 63;
            button4.Text = "Cerrar Sesion";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label21.Location = new Point(336, 211);
            label21.Name = "label21";
            label21.Size = new Size(163, 25);
            label21.TabIndex = 62;
            label21.Text = "Eliminar Residente";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label20.Location = new Point(12, 211);
            label20.Name = "label20";
            label20.Size = new Size(218, 25);
            label20.TabIndex = 61;
            label20.Text = "Guardar/Editar Residente";
            // 
            // comboResidente
            // 
            comboResidente.FormattingEnabled = true;
            comboResidente.Location = new Point(370, 247);
            comboResidente.Margin = new Padding(2);
            comboResidente.Name = "comboResidente";
            comboResidente.Size = new Size(148, 23);
            comboResidente.TabIndex = 49;
            // 
            // dataGridViewResidentes
            // 
            dataGridViewResidentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResidentes.Location = new Point(4, 4);
            dataGridViewResidentes.Margin = new Padding(2);
            dataGridViewResidentes.Name = "dataGridViewResidentes";
            dataGridViewResidentes.RowHeadersWidth = 62;
            dataGridViewResidentes.Size = new Size(880, 198);
            dataGridViewResidentes.TabIndex = 1;
            // 
            // asociarLocker
            // 
            asociarLocker.Location = new Point(312, 414);
            asociarLocker.Margin = new Padding(2);
            asociarLocker.Name = "asociarLocker";
            asociarLocker.Size = new Size(120, 88);
            asociarLocker.TabIndex = 48;
            asociarLocker.Text = "Asociar Lockers";
            asociarLocker.UseVisualStyleBackColor = true;
            asociarLocker.Click += asociarLocker_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 385);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 47;
            label3.Text = "Tipo Envio:";
            // 
            // comboTipoEnvio
            // 
            comboTipoEnvio.FormattingEnabled = true;
            comboTipoEnvio.Location = new Point(131, 381);
            comboTipoEnvio.Margin = new Padding(2);
            comboTipoEnvio.Name = "comboTipoEnvio";
            comboTipoEnvio.Size = new Size(106, 23);
            comboTipoEnvio.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 250);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 45;
            label2.Text = "ID:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(131, 352);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(106, 23);
            txtEmail.TabIndex = 41;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(541, 244);
            buttonEliminar.Margin = new Padding(2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(111, 33);
            buttonEliminar.TabIndex = 38;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            buttonEliminar.Click += buttonEliminar_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 464);
            button7.Margin = new Padding(2);
            button7.Name = "button7";
            button7.Size = new Size(279, 38);
            button7.TabIndex = 37;
            button7.Text = "Editar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(12, 414);
            button8.Margin = new Padding(2);
            button8.Name = "button8";
            button8.Size = new Size(279, 38);
            button8.TabIndex = 36;
            button8.Text = "Guardar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(131, 324);
            txtTelefono.Margin = new Padding(2);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(106, 23);
            txtTelefono.TabIndex = 33;
            // 
            // txtDepto
            // 
            txtDepto.Location = new Point(131, 295);
            txtDepto.Margin = new Padding(2);
            txtDepto.Name = "txtDepto";
            txtDepto.Size = new Size(106, 23);
            txtDepto.TabIndex = 32;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(131, 270);
            txtApellido.Margin = new Padding(2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(106, 23);
            txtApellido.TabIndex = 31;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 244);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(106, 23);
            txtNombre.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 352);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 27;
            label9.Text = "Email:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 324);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(55, 15);
            label10.TabIndex = 26;
            label10.Text = "Telefono:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 300);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(86, 15);
            label11.TabIndex = 25;
            label11.Text = "Departamento:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 274);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(54, 15);
            label12.TabIndex = 24;
            label12.Text = "Apellido:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 247);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(54, 15);
            label13.TabIndex = 23;
            label13.Text = "Nombre:";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(comboRepartidor);
            tabPage3.Controls.Add(label23);
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(textBoxNombreR);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(txtTelefonoR);
            tabPage3.Controls.Add(checkBoxR);
            tabPage3.Controls.Add(buttonAltaRepartidor);
            tabPage3.Controls.Add(buttonEditarRepartidor);
            tabPage3.Controls.Add(buttonEliminarRepartidor);
            tabPage3.Controls.Add(txtLegajoR);
            tabPage3.Controls.Add(txtEmpresaR);
            tabPage3.Controls.Add(txtApellidoR);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label15);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(888, 542);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Repartidores";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboRepartidor
            // 
            comboRepartidor.FormattingEnabled = true;
            comboRepartidor.Location = new Point(381, 253);
            comboRepartidor.Name = "comboRepartidor";
            comboRepartidor.Size = new Size(130, 23);
            comboRepartidor.TabIndex = 67;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label23.Location = new Point(341, 214);
            label23.Name = "label23";
            label23.Size = new Size(170, 25);
            label23.TabIndex = 66;
            label23.Text = "Eliminar Repartidor";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label22.Location = new Point(18, 214);
            label22.Name = "label22";
            label22.Size = new Size(202, 25);
            label22.TabIndex = 65;
            label22.Text = "Crear/Editar Repartidor";
            // 
            // button1
            // 
            button1.Location = new Point(742, 483);
            button1.Name = "button1";
            button1.Size = new Size(142, 55);
            button1.TabIndex = 64;
            button1.Text = "Cerrar Sesion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxNombreR
            // 
            textBoxNombreR.Location = new Point(138, 251);
            textBoxNombreR.Margin = new Padding(2);
            textBoxNombreR.Name = "textBoxNombreR";
            textBoxNombreR.Size = new Size(106, 23);
            textBoxNombreR.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(341, 259);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(21, 15);
            label5.TabIndex = 62;
            label5.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 362);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 61;
            label4.Text = "Telefono:";
            // 
            // txtTelefonoR
            // 
            txtTelefonoR.Location = new Point(138, 359);
            txtTelefonoR.Margin = new Padding(2);
            txtTelefonoR.Name = "txtTelefonoR";
            txtTelefonoR.Size = new Size(106, 23);
            txtTelefonoR.TabIndex = 60;
            // 
            // checkBoxR
            // 
            checkBoxR.AutoSize = true;
            checkBoxR.Location = new Point(138, 388);
            checkBoxR.Margin = new Padding(2);
            checkBoxR.Name = "checkBoxR";
            checkBoxR.Size = new Size(15, 14);
            checkBoxR.TabIndex = 59;
            checkBoxR.UseVisualStyleBackColor = true;
            // 
            // buttonAltaRepartidor
            // 
            buttonAltaRepartidor.Location = new Point(18, 416);
            buttonAltaRepartidor.Margin = new Padding(2);
            buttonAltaRepartidor.Name = "buttonAltaRepartidor";
            buttonAltaRepartidor.Size = new Size(279, 38);
            buttonAltaRepartidor.TabIndex = 57;
            buttonAltaRepartidor.Text = "Alta";
            buttonAltaRepartidor.UseVisualStyleBackColor = true;
            buttonAltaRepartidor.Click += buttonAltaRepartidor_Click;
            // 
            // buttonEditarRepartidor
            // 
            buttonEditarRepartidor.Location = new Point(18, 463);
            buttonEditarRepartidor.Margin = new Padding(2);
            buttonEditarRepartidor.Name = "buttonEditarRepartidor";
            buttonEditarRepartidor.Size = new Size(279, 38);
            buttonEditarRepartidor.TabIndex = 56;
            buttonEditarRepartidor.Text = "Editar";
            buttonEditarRepartidor.UseVisualStyleBackColor = true;
            buttonEditarRepartidor.Click += buttonEditarRepartidor_Click_1;
            // 
            // buttonEliminarRepartidor
            // 
            buttonEliminarRepartidor.Location = new Point(548, 247);
            buttonEliminarRepartidor.Margin = new Padding(2);
            buttonEliminarRepartidor.Name = "buttonEliminarRepartidor";
            buttonEliminarRepartidor.Size = new Size(111, 33);
            buttonEliminarRepartidor.TabIndex = 55;
            buttonEliminarRepartidor.Text = "Eliminar";
            buttonEliminarRepartidor.UseVisualStyleBackColor = true;
            buttonEliminarRepartidor.Click += buttonEliminarRepartidor_Click_1;
            // 
            // txtLegajoR
            // 
            txtLegajoR.Location = new Point(138, 329);
            txtLegajoR.Margin = new Padding(2);
            txtLegajoR.Name = "txtLegajoR";
            txtLegajoR.Size = new Size(106, 23);
            txtLegajoR.TabIndex = 53;
            // 
            // txtEmpresaR
            // 
            txtEmpresaR.Location = new Point(138, 301);
            txtEmpresaR.Margin = new Padding(2);
            txtEmpresaR.Name = "txtEmpresaR";
            txtEmpresaR.Size = new Size(106, 23);
            txtEmpresaR.TabIndex = 52;
            // 
            // txtApellidoR
            // 
            txtApellidoR.Location = new Point(138, 275);
            txtApellidoR.Margin = new Padding(2);
            txtApellidoR.Name = "txtApellidoR";
            txtApellidoR.Size = new Size(106, 23);
            txtApellidoR.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(19, 386);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 48;
            label8.Text = "Credencial:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(19, 329);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(62, 15);
            label15.TabIndex = 47;
            label15.Text = "Legajo N°:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(19, 305);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(55, 15);
            label16.TabIndex = 46;
            label16.Text = "Empresa:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(18, 279);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(54, 15);
            label17.TabIndex = 45;
            label17.Text = "Apellido:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(18, 253);
            label18.Margin = new Padding(2, 0, 2, 0);
            label18.Name = "label18";
            label18.Size = new Size(54, 15);
            label18.TabIndex = 44;
            label18.Text = "Nombre:";
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 4);
            dataGridView3.Margin = new Padding(2);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(880, 198);
            dataGridView3.TabIndex = 42;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 582);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureQr).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResidentes).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView dataGridView1;
        private Button button5;
        private Button button1;
        private TextBox txtEmail;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox txtTelefono;
        private TextBox txtDepto;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private DataGridView dataGridViewResidentes;
        private CheckBox checkBoxR;
        private PictureBox pictureQr;
        private Button button10;
        private Button buttonEditarRepartidor;
        private Button buttonEliminarRepartidor;
        private Button button13;
        private TextBox txtLegajoR;
        private TextBox txtEmpresaR;
        private TextBox txtApellidoR;
        private Label label8;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private DataGridView dataGridView3;
        private ComboBox comboBoxLockers;
        private Label label6;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboTipoEnvio;
        private Button button2;
        private Button buttonEliminar;
        private Button asociarLocker;
        private Button button3;
        private Button GenerarQR;
        private Label label4;
        private TextBox txtTelefonoR;
        private Button buttonAltaRepartidor;
        private Label label5;
        private TextBox textBoxNombreR;
        private ComboBox comboResidente;
        private Label label14;
        private Label label7;
        private ComboBox comboLockerDelete;
        private Label label19;
        private Label label20;
        private Label label21;
        private Button button4;
        private Label label22;
        private Label label23;
        private ComboBox comboRepartidor;
    }
}
