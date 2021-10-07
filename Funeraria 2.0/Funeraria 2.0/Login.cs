using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace Funeraria_2._0
{
    public partial class Login : Form
    {
        public static string conexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Respaldo Note\Funeraria 3.0\Funeraria 2.0\Funeraria 2.0\FunerariaBDPrueba.accdb;Persist Security Info=True";
        public static string nombre = "";
        public static bool Admin = false;
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
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
            toolTip1.SetToolTip(this.txtUserLogin, "Rut de usuario");
            toolTip1.SetToolTip(this.txtPassLogin, "Contraseña");

            txtUserLogin.Focus();
            lblFechaLogin.Text = DateTime.Now.ToLongDateString().ToString();
            cn.ConnectionString =conexion;
            cmd.Connection = cn;
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            if (txtUserLogin.TextLength == 0 || txtPassLogin.TextLength == 0)
            {
                if (txtUserLogin.Text.Trim() == "")
                {
                    MessageBox.Show("Asegúrese de ingresar el rut del usuario");
                    txtUserLogin.Focus();
                }
                else if (txtPassLogin.Text.Trim() == "")
                {
                    MessageBox.Show("Asegúrese de ingresar la Contraseña");
                    txtPassLogin.Focus();
                }

            }
            else
            {
                cn.Open();

                String consulta = "select * from Usuario where rut= '" + txtUserLogin.Text + "' and pass= '" + txtPassLogin.Text + "' ; ";

                OleDbCommand cmd = new OleDbCommand(consulta, cn);
                dr = cmd.ExecuteReader();

                Boolean registros = dr.HasRows;

                if (registros)
                {
                    while (dr.Read())
                    {
                        nombre = dr["nombre"].ToString();
                        Admin = Convert.ToBoolean(dr.GetValue(4));

                    }
                    MessageBox.Show("Bienvenido al sistema " + nombre, "Usuario Autorizado ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Menu.MenuPrincipal menu = new Menu.MenuPrincipal();
                    cn.Close();
                    this.Hide();
                    menu.ShowDialog();
                    this.Close();


                }
                else
                {

                    MessageBox.Show("Usuario no registrado");
                    txtPassLogin.Clear();
                    txtUserLogin.Clear();
                    txtUserLogin.Focus();



                    cn.Close();
                }

            }
        }

        private void btnSalirLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO | Funerales Montalván ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        public string formatearRut(string rut)
        {
            int cont = 0;
            string format;
            if (rut.Length < 8)
            {
                return "";
            }
            else
            {
                rut = rut.Replace(".", "");
                rut = rut.Replace("-", "");
                format = "-" + rut.Substring(rut.Length - 1);
                for (int i = rut.Length - 2; i >= 0; i--)
                {
                    format = rut.Substring(i, 1) + format;
                    cont++;
                    if (cont == 3 && i != 0)
                    {
                        format = "." + format;
                        cont = 0;
                    }
                }
                return format;
            }
        }

        public static bool ValidaRut(string rut)
        {
            rut = rut.Replace(".", "").ToUpper();
            Regex expresion = new Regex("^([0-9]+-[0-9K])$");
            string dv = rut.Substring(rut.Length - 1, 1);
            if (!expresion.IsMatch(rut))
            {
                return false;
            }
            char[] charCorte = { '-' };
            string[] rutTemp = rut.Split(charCorte);
            if (dv != Digito(int.Parse(rutTemp[0])))
            {
                return false;
            }
            return true;
        }

        public static string Digito(int rut)
        {
            int suma = 0;
            int multiplicador = 1;
            while (rut != 0)
            {
                multiplicador++;
                if (multiplicador == 8)
                    multiplicador = 2;
                suma += (rut % 10) * multiplicador;
                rut = rut / 10;
            }
            suma = 11 - (suma % 11);
            if (suma == 11)
            {
                return "0";
            }
            else if (suma == 10)
            {
                return "K";
            }
            else
            {
                return suma.ToString();
            }
        }

        private void txtUserLogin_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void txtUserLogin_Leave(object sender, EventArgs e)
        {

            if (txtUserLogin.Text.Trim() == "")
            {
                lblErrorUserLogin.Text = "Campo Obligatorio";
                btnIngresarLogin.Enabled = false;

            }
            else
            {
                if (formatearRut(txtUserLogin.Text) == "")
                {
                    lblErrorUserLogin.Text = "Debe ser mayor a 7 digitos";
                    btnIngresarLogin.Enabled = false;
                }
                else
                {

                    string rut = formatearRut(txtUserLogin.Text);

                    if (ValidaRut(rut))
                    {
                        txtUserLogin.Text = rut;
                        lblErrorUserLogin.Text = "";
                        btnIngresarLogin.Enabled = true;
                    }
                    else
                    {
                        lblErrorUserLogin.Text = "Ingrese un rut valido";
                        btnIngresarLogin.Enabled = false;
                    }


                }
            }
            
        }

        private void txtPassLogin_Leave(object sender, EventArgs e)
        {
            if (txtPassLogin.Text.Trim() == "")
            {
                this.lblErrorPassLogin.AutoSize = true;
                //this.lblErrorRutNuevoContrato.Location = new System.Drawing.Point(320, 120);
                this.lblErrorPassLogin.Size = new System.Drawing.Size(35, 13);
                lblErrorPassLogin.Text = "*Campo obligatorio";
                //btnIngresarLogin.Enabled = false;
            }
            else
            {
                lblErrorPassLogin.Text = "";
                btnIngresarLogin.Enabled = true;
            }
        }
    }
}
