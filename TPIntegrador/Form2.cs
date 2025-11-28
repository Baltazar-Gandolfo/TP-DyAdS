using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPIntegrador
{
    public partial class BienvenidaForm : Form
    {
        private System.Windows.Forms.Timer cerrarTimer;

        public BienvenidaForm()
        {
            InitializeComponent();
        }

        // Constructor para LOGIN
        public BienvenidaForm(string nombre)
        {
            InitializeComponent();
            MostrarMensaje($"¡Bienvenido {nombre}! 🎉");
        }

        //Constructor para REGISTRO
        public BienvenidaForm(string mensaje, bool esRegistro)
        {
            InitializeComponent();
            MostrarMensaje(mensaje);
        }

        // Constructor para ADVERTENCIA
        public BienvenidaForm(string mensaje, Color colorFondo)
        {
            InitializeComponent();
            this.BackColor = colorFondo;
            MostrarMensaje(mensaje);
        }

        private void MostrarMensaje(string mensaje)
        {
            lblMensaje.Text = mensaje;

            this.Opacity = 0;
            var fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 15;
            fadeTimer.Tick += (s, e) =>
            {
                if (this.Opacity < 1)
                    this.Opacity += 0.05;
                else
                    fadeTimer.Stop();
            };
            fadeTimer.Start();

            cerrarTimer = new System.Windows.Forms.Timer();
            cerrarTimer.Interval = 2000;
            cerrarTimer.Tick += (s, e) =>
            {
                cerrarTimer.Stop();
                this.Close();
            };
            cerrarTimer.Start();
        }

        private void BienvenidaForm_Load(object sender, EventArgs e)
        {

        }
    }
}
