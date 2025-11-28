using BLL;
using Entities;
using Mapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPIntegrador
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            this.DoubleBuffered = true;     // Evita parpadeos
            this.Paint += Form_DrawGradient; // Fondo degradado

        }
        private void Login_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Residente");
            comboBox1.Items.Add("Repartidor");
            comboBox1.SelectedIndex = 0;
            comboBox1.BringToFront();
            labelRol.BringToFront();
            underlineUser.BringToFront();
            underlinePass.BringToFront();

        }
        private void Form_DrawGradient(object sender, PaintEventArgs e)
        {
            var rect = this.ClientRectangle;
            using (var brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                   rect,
                   Color.FromArgb(52, 143, 235),
                   Color.FromArgb(86, 180, 235),
                   90f))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }



        private UsuarioBusiness usuarioBusiness = new UsuarioBusiness();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBusiness usuarioBusiness = new UsuarioBusiness();

                var usuario = usuarioBusiness.Login(
                    loginUser.Text,
                    claveUser.Text,
                    comboBox1.Text
                );

                // Mostrar pantalla de bienvenida
                BienvenidaForm bienvenida = new BienvenidaForm(usuario.Nombre_Usuario);
                bienvenida.ShowDialog();

                Form1 juego = new Form1(usuario);
                juego.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void lbl_registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string usuario = loginUser.Text;
                string clave = claveUser.Text;
                string rol = comboBox1.Text;

                if (rol != "Residente")
                {
                    // mensaje advertencia
                    var advertencia = new BienvenidaForm(
                        "⚠ Solo los residentes pueden registrarse desde aquí.",
                        Color.Gold
                    );
                    advertencia.ShowDialog();
                    return;
                }

                // Registrar usuario
                usuarioBusiness.Registrar(usuario, clave, rol);

                // Mensaje de registro exitoso
                var bienvenida = new BienvenidaForm(
                    "🎉 ¡Residente registrado correctamente! 🎉\nAhora iniciá sesión para completar tus datos.",
                    true
                );
                bienvenida.ShowDialog();

                // Limpiar campos
                loginUser.Clear();
                claveUser.Clear();
                comboBox1.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                var errorMsg = new BienvenidaForm(
                    "❌ Error: " + ex.Message,
                    Color.LightCoral
                );
                errorMsg.ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void underlineUser_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
