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
        }
        private void Login_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Residente");
            comboBox1.Items.Add("Repartidor");

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
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
                //usuarioBusiness.Registrar(textBox1.Text, textBox2.Text, comboBox1.Text);

                MessageBox.Show("Te registraste correctamente!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


    }
}
