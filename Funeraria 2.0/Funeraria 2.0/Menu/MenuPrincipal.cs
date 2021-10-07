using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funeraria_2._0.Menu
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 2500;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.btnContratosMenu, "Opciones de contratos");
            toolTip1.SetToolTip(this.btnServiciosMenu, "Opciones de servicios");
            toolTip1.SetToolTip(this.btnAdminPerfilesMenu, "Opciones de perfil");
            toolTip1.SetToolTip(this.lblCerrarSesionMenu, "Cierra sesion");
            toolTip1.SetToolTip(this.btnSalirMenu, "Salir del sistema");


            lblUserMenu.Text = "Conectado como: " + Login.nombre;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea cerrar su sesion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            }
        }

        private void btnSalirMenu_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir del sistema?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnContratosMenu_Click(object sender, EventArgs e)
        {
            Contratos.MenuContratos menuContratos = new Contratos.MenuContratos();

            this.Hide();
            menuContratos.ShowDialog();
            this.Close();
        }

        private void btnServiciosMenu_Click(object sender, EventArgs e)
        {
            Servicios.MenuServicios menuServ = new Servicios.MenuServicios();
             this.Hide();
            menuServ.ShowDialog();
            this.Close();
        }

        private void btnAdminPerfilesMenu_Click(object sender, EventArgs e)
        {
            Perfil.MenuPerfil menuPerfil = new Perfil.MenuPerfil();
             this.Hide();
            menuPerfil.ShowDialog();
            this.Close();
        }
    }
}
