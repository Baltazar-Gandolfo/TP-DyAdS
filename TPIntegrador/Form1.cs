using BLL;
using Entities;
using Entities.Models;
using Mapper;

namespace TPIntegrador
{
    public partial class Form1 : Form
    {
        private UsuarioEntity usuarioLogueado;

        public Form1(UsuarioEntity usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;

        }
        private UsuarioBusiness usuarioBusiness = new UsuarioBusiness();

        private void Form1_Load(object sender, EventArgs e)
        {
            switch (usuarioLogueado.Rol.ToLower())
            {
                case "residente":
                    tabControl1.TabPages.Remove(tabPage3);
                    break;

                case "repartidor":
                    tabControl1.TabPages.Remove(tabPage2);
                    button5.Enabled = false;
                    break;
            }
        }
    }
}
