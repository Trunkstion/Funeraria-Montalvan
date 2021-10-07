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

namespace Funeraria_2._0.Contratos
{
    public partial class MenuContratos : Form
    {
        //variables de paso fallecido
        public static string rutfallecido, nombreFallecido, fechaFallecimiento, folio, lugarFallecimiento, horaFallecimiento;
        //variables de paso contratante
        public static string rutContratante, nombreContratante, fonoContratante, direccionContratante, fechaContratacion;

        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        public static String datoFiltro = "";
        public static int opcDatos;
        Boolean validador = true;

        public MenuContratos()
        {
            InitializeComponent();
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

        private void MenuContratos_Load(object sender, EventArgs e)
        {

            try
            {
                cn.ConnectionString = Login.conexion;
                cmd.Connection = cn;



                cn.Open();
                String consulta = "select nombre from Usuario; ";
                OleDbDataReader dr;
                cmd = new OleDbCommand(consulta, cn);
                dr = cmd.ExecuteReader();

                Boolean registros = dr.HasRows;

                if (registros)
                {
                    while (dr.Read())
                    {
                        cbxVendedorBuscarContrato.Items.Add(dr[0]);

                    }
                    cn.Close();
                    dr.Close();
                }
                cn.Close();
                dr.Close();
            }
            catch (Exception m)
            {
                MessageBox.Show(" " + m.Message + " ");
            }


            if (SeleccionarContrato.validar == true)
            {

                groupBoxFiltrosListar.Visible = false;
                groupBoxContratante.Visible = true;
                groupBoxFallecido.Visible = true;
                groupBoxServicios.Visible = true;
                groupBox5Valores.Visible = true;
                btnBuscarNuevoBuscarContratos.Visible = true;
                btnImprimirBuscarContratos.Visible = true;
                btnGuardarCambiosVerContratos.Visible = true;
                txtRutFallecidoBuscarContratos.Clear();
                txtRutContratanteBuscarContratos.Clear();
                tabContratos.SelectedTab = tabPage1;
                cn.ConnectionString = Login.conexion;
                cn.Open();
                try
                {


                    string consulta = "select * from Contrato where rutFallecido='" + SeleccionarContrato.modificarContrato + "';";

                    OleDbDataReader dr;
                    cmd = new OleDbCommand(consulta, cn);
                    dr = cmd.ExecuteReader();



                    Boolean registros = dr.HasRows;

                    if (registros)
                    {
                        while (dr.Read())
                        {

                            txtRutFallecidoMostrarContrato.Text = dr["rutFallecido"].ToString();
                            txtNombreFallecidoMostrarContratos.Text = dr["nombreFallecido"].ToString();
                            txtLugarFallecimientoMostrarContratos.Text = dr["lugarFallecimiento"].ToString();
                            dtpFechaFallecimientoMostrarContratos.Text = dr["fechaFallecimiento"].ToString();
                            txtHoraMostrarContrato.Text = dr["horaFallecimiento"].ToString();
                            txtFolioMostrarContrato.Text = dr["folioCertificado"].ToString();


                            txtRutContratanteMostrarContratos.Text = dr["rutContratante"].ToString();
                            txtNombreContratanteMostrarContratos.Text = dr["nombreContratante"].ToString();
                            txtFonoContratanteMostrarContrato.Text = dr["fonoContratante"].ToString();
                            dtpFechaContratoMostrarContrato.Text = dr["fechaContratacion"].ToString();
                            txtDireccionContratanteMostrarContrato.Text = dr["direccionContratante"].ToString();


                            txtServicioContratadoMostrarContrato.Text = dr["servicioEntregado"].ToString();
                            txtAgregadosMostrarContrato.Text = dr["agregados"].ToString();


                            txtValorNetoMostrarContratos.Text = dr["valorNeto"].ToString();
                            txtIvaMostrarContratos.Text = dr["iva"].ToString();
                            txtTotalMostrarContrato.Text = dr["totalServicio"].ToString();
                            txtVendedorMostrarContrato.Text = dr["vendedor"].ToString();


                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encuentran contratos con los datos ingresados", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.Close();
                    }
                    dr.Close();
                    cn.Close();

                }
                catch (Exception m)
                {
                    MessageBox.Show(" " + m.Message + " ");
                }
            }

            btnSiguienteNuevoContrato.Enabled = false;
            dtpHoraFallecimientoNuevoContrato.ShowUpDown = true;

            dtpHoraFallecimientoNuevoContrato.Width = 50;

            dtpHoraFallecimientoNuevoContrato.Format = DateTimePickerFormat.Custom;
            dtpHoraFallecimientoNuevoContrato.CustomFormat = "HH:mm";


            // TODO: esta línea de código carga datos en la tabla 'funerariaBD.Usuario' Puede moverla o quitarla según sea necesario.
            //Nombre testthis.usuarioTableAdapter.Fill(this.funerariaBD.Usuario);

            txtRutFallecidoBuscarContratos.Enabled = false;
            txtRutContratanteBuscarContratos.Enabled = false;
            dtpFechaContratoBuscarContrato.Enabled = false;
            cbxVendedorBuscarContrato.Enabled = false;
            btnBuscarContratos.Enabled = false;


        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

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

        private void txtRutFallecido_Validated(object sender, EventArgs e)
        {
            if (txtRutFallecidoContratos.Text.Trim() == "")
            {
                lblErrorRutFallecidoNuevoContrato.Text = "Campo Obligatorio";
                btnSiguienteNuevoContrato.Enabled = false;

            }
            else
            {
                if (formatearRut(txtRutFallecidoContratos.Text) == "")
                {
                    lblErrorRutFallecidoNuevoContrato.Text = "Debe ser mayor a 7 digitos";
                    btnSiguienteNuevoContrato.Enabled = false;
                }
                else
                {

                    string rut = formatearRut(txtRutFallecidoContratos.Text);

                    if (ValidaRut(rut))
                    {
                        txtRutFallecidoContratos.Text = rut;
                        lblErrorRutFallecidoNuevoContrato.Text = "";
                        btnSiguienteNuevoContrato.Enabled = true;
                    }
                    else
                    {
                        lblErrorRutFallecidoNuevoContrato.Text = "Ingrese un rut valido";
                        btnSiguienteNuevoContrato.Enabled = false;
                    }


                }
            }

        }

        private void txtRutFallecidoBuscar_Validated(object sender, EventArgs e)
        {

            txtRutFallecidoBuscarContratos.Text = formatearRut(txtRutFallecidoBuscarContratos.Text);

        }

        private void txtRutContratante_Validated(object sender, EventArgs e)
        {

            if (txtRutContratanteContratos.Text.Trim() == "")
            {
                lblErrorRutContratanteNuevoContrato.Text = "Campo Obligatorio";
                btnSiguienteNuevoContrato.Enabled = false;

            }
            else
            {
                if (formatearRut(txtRutContratanteContratos.Text) == "")
                {
                    lblErrorRutContratanteNuevoContrato.Text = "Debe ser mayor a 7 digitos";
                    btnSiguienteNuevoContrato.Enabled = false;
                }
                else
                {

                    string rut = formatearRut(txtRutContratanteContratos.Text);

                    if (ValidaRut(rut))
                    {
                        txtRutContratanteContratos.Text = rut;
                        lblErrorRutContratanteNuevoContrato.Text = "";
                        btnSiguienteNuevoContrato.Enabled = true;
                    }
                    else
                    {
                        lblErrorRutContratanteNuevoContrato.Text = "Ingrese un rut valido";
                        btnSiguienteNuevoContrato.Enabled = false;
                    }


                }
            }

        }

        private void txtRutContratanteBuscar_Validated(object sender, EventArgs e)
        {

            txtRutContratanteBuscarContratos.Text = formatearRut(txtRutContratanteBuscarContratos.Text);

        }

        private void btnSalirContratos_Click(object sender, EventArgs e)
        {
            Menu.MenuPrincipal menu = new Menu.MenuPrincipal();
            this.Hide();
            menu.ShowDialog();
            this.Close();

        }

        private void btnIngresarContratosContratos_Click(object sender, EventArgs e)
        {
            if (txtRutContratanteContratos.Text.Trim() == "" || txtNombreContratanteContratos.Text.Trim() == "" || txtFolioNuevoContrato.Text.Trim() == "" || txtNombreContratos.Text.Trim() == "" || txtLugarFallecimientoContratos.Text.Trim() == "" || txtFonoContratanteContrato.Text.Trim() == "" || txtRutFallecidoContratos.Text.Trim() == "" || txtDireccionContratanteNuevoContrato.Text.Trim() == "")
            {



                btnSiguienteNuevoContrato.Enabled = false;
                MessageBox.Show("Datos faltantes");

            }
            else
            {
                btnSiguienteNuevoContrato.Enabled = true;
                //datos fallecido
                rutfallecido = txtRutFallecidoContratos.Text;
                nombreFallecido = txtNombreContratos.Text;
                fechaFallecimiento = dtpFechaFallecimientoContrato.Text;
                folio = txtFolioNuevoContrato.Text;
                lugarFallecimiento = txtLugarFallecimientoContratos.Text;
                horaFallecimiento = dtpHoraFallecimientoNuevoContrato.Text;
                //datos contratante
                rutContratante = txtRutContratanteContratos.Text;
                nombreContratante = txtNombreContratanteContratos.Text;
                fonoContratante = txtFonoContratanteContrato.Text;
                direccionContratante = txtDireccionContratanteNuevoContrato.Text;
                fechaContratacion = dtpFechaContratacionContratos.Text;

                txtRutFallecidoContratos.Clear();
                txtNombreContratos.Clear();
                txtFolioNuevoContrato.Clear();
                txtLugarFallecimientoContratos.Clear();
                txtRutContratanteContratos.Clear();
                txtNombreContratanteContratos.Clear();
                txtFonoContratanteContrato.Clear();
                txtDireccionContratanteNuevoContrato.Clear();

                NuevoContrato contratoSig = new NuevoContrato();
                contratoSig.ShowDialog();

            }

        }

        private void rbRutFallecidoBuscarContrato_CheckedChanged(object sender, EventArgs e)
        {

            txtRutFallecidoBuscarContratos.Enabled = true;
            txtRutContratanteBuscarContratos.Enabled = false;
            txtRutContratanteBuscarContratos.Clear();
            dtpFechaContratoBuscarContrato.Enabled = false;
            cbxVendedorBuscarContrato.Enabled = false;
            btnBuscarContratos.Enabled = true;
        }

        private void rbRutContratanteBuscarContrato_CheckedChanged(object sender, EventArgs e)
        {
            txtRutFallecidoBuscarContratos.Enabled = false;
            txtRutFallecidoBuscarContratos.Clear();
            txtRutContratanteBuscarContratos.Enabled = true;
            dtpFechaContratoBuscarContrato.Enabled = false;
            cbxVendedorBuscarContrato.Enabled = false;
            btnBuscarContratos.Enabled = true;
        }

        private void rbFechaContratoBuscarContrato_CheckedChanged(object sender, EventArgs e)
        {
            txtRutFallecidoBuscarContratos.Enabled = false;
            txtRutContratanteBuscarContratos.Enabled = false;
            dtpFechaContratoBuscarContrato.Enabled = true;
            cbxVendedorBuscarContrato.Enabled = false;
            txtRutFallecidoBuscarContratos.Clear();
            txtRutContratanteBuscarContratos.Clear();
            btnBuscarContratos.Enabled = true;
        }

        private void rbVendedorBuscarContrato_CheckedChanged(object sender, EventArgs e)
        {
            txtRutFallecidoBuscarContratos.Enabled = false;
            txtRutContratanteBuscarContratos.Enabled = false;
            dtpFechaContratoBuscarContrato.Enabled = false;
            cbxVendedorBuscarContrato.Enabled = true;
            txtRutFallecidoBuscarContratos.Clear();
            txtRutContratanteBuscarContratos.Clear();
            btnBuscarContratos.Enabled = true;
        }

        private void btnBuscarContratos_Click(object sender, EventArgs e)
        {


            if (txtRutFallecidoBuscarContratos.Enabled == true)
            {
                if (string.IsNullOrEmpty(txtRutFallecidoBuscarContratos.Text))
                {
                    MessageBox.Show("Debe escribir algun parametro para buscar", "No ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    groupBoxFiltrosListar.Visible = true;
                    groupBoxContratante.Visible = false;
                    groupBoxFallecido.Visible = false;
                    groupBoxServicios.Visible = false;
                    groupBox5Valores.Visible = false;
                    btnBuscarNuevoBuscarContratos.Visible = false;
                    btnImprimirBuscarContratos.Visible = false;
                    btnGuardarCambiosVerContratos.Visible = false;
                    txtRutFallecidoBuscarContratos.Clear();
                    txtRutContratanteBuscarContratos.Clear();



                    validador = false;

                    datoFiltro = "null";
                    opcDatos = 1;
                }
                else
                {
                    datoFiltro = txtRutFallecidoBuscarContratos.Text; ;
                    opcDatos = 1;
                    validador = true;
                }
            }


            if (txtRutContratanteBuscarContratos.Enabled == true)
            {
                if (string.IsNullOrEmpty(txtRutContratanteBuscarContratos.Text))
                {
                    MessageBox.Show("Debe escribir algun parametro para buscar", "No ingresado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    groupBoxFiltrosListar.Visible = true;
                    groupBoxContratante.Visible = false;
                    groupBoxFallecido.Visible = false;
                    groupBoxServicios.Visible = false;
                    groupBox5Valores.Visible = false;
                    btnBuscarNuevoBuscarContratos.Visible = false;
                    btnImprimirBuscarContratos.Visible = false;
                    btnGuardarCambiosVerContratos.Visible = false;
                    txtRutFallecidoBuscarContratos.Clear();
                    txtRutContratanteBuscarContratos.Clear();

                    validador = false;


                    datoFiltro = "null";
                    opcDatos = 2;
                }
                else
                {
                    datoFiltro = txtRutContratanteBuscarContratos.Text;
                    opcDatos = 2;
                    validador = true;
                }
            }


            if (dtpFechaContratoBuscarContrato.Enabled == true)
            {
                datoFiltro = dtpFechaContratoBuscarContrato.Text;
                opcDatos = 3;
                validador = true;
            }
            else if (cbxVendedorBuscarContrato.Enabled == true)
            {
                datoFiltro = cbxVendedorBuscarContrato.Text;
                opcDatos = 4;
                validador = true;
            }
            else if (rbBuscarTodosBuscarContratos.Checked == true)
            {

                opcDatos = 5;
                validador = true;
            }


            if (validador == true)
            {

                Contratos.SeleccionarContrato selCont = new SeleccionarContrato();


                this.Hide();
                selCont.ShowDialog();
                this.Close();


                this.Close();

                groupBoxFiltrosListar.Visible = false;
                groupBoxContratante.Visible = true;
                groupBoxFallecido.Visible = true;
                groupBoxServicios.Visible = true;
                groupBox5Valores.Visible = true;
                btnBuscarNuevoBuscarContratos.Visible = true;
                btnImprimirBuscarContratos.Visible = true;
                btnGuardarCambiosVerContratos.Visible = true;

            }





        }

        private void tabContratos_Selecting(object sender, TabControlCancelEventArgs e)
        {

        }





        private void btnBuscarNuevoBuscarContratos_Click(object sender, EventArgs e)
        {


            groupBoxFiltrosListar.Visible = true;
            groupBoxContratante.Visible = false;
            groupBoxFallecido.Visible = false;
            groupBoxServicios.Visible = false;
            groupBox5Valores.Visible = false;
            btnBuscarNuevoBuscarContratos.Visible = false;
            btnImprimirBuscarContratos.Visible = false;
            btnGuardarCambiosVerContratos.Visible = false;
            txtRutFallecidoBuscarContratos.Clear();
            txtRutContratanteBuscarContratos.Clear();
        }

        private void btnSalirMostrarContratos_Click(object sender, EventArgs e)
        {
            Menu.MenuPrincipal menu = new Menu.MenuPrincipal();

            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void groupBoxFiltrosListar_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxFallecido_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombreContratos_Leave(object sender, EventArgs e)
        {
            if (txtNombreContratos.Text.Trim() == "")
            {
                lblErrorNombreFallecidoNuevoContrato.Text = "Campo Obligatorio";
                btnSiguienteNuevoContrato.Enabled = false;

            }
            else
            {
                lblErrorNombreFallecidoNuevoContrato.Text = "";
                btnSiguienteNuevoContrato.Enabled = true;
            }
        }

        private void dtpFechaFallecimientoContrato_Leave(object sender, EventArgs e)
        {
            if (dtpFechaFallecimientoContrato.Value > System.DateTime.Now)
            {
                lblErrorFechaFallecimientoNuevoContrato.Text = "La fecha no puede ser posterior a la fecha actual";
                btnSiguienteNuevoContrato.Enabled = false;
            }
            else
            {
                lblErrorFechaFallecimientoNuevoContrato.Text = "";
                btnSiguienteNuevoContrato.Enabled = true;
            }
        }

        private void txtNombreContratos_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtLugarFallecimientoContratos_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtFonoContratanteContrato_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtNombreContratanteContratos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dtpFechaContratacionContratos_Leave(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void txtFolioNuevoContrato_Leave(object sender, EventArgs e)
        {
            if (txtFolioNuevoContrato.Text.Trim() == "")
            {
                lblErrorFolioNuevoContrato.Text = "Campo Obligatorio";
                btnSiguienteNuevoContrato.Enabled = false;

            }
            else
            {
                lblErrorFolioNuevoContrato.Text = "";
                btnSiguienteNuevoContrato.Enabled = true;
            }
        }

        private void txtLugarFallecimientoContratos_Leave(object sender, EventArgs e)
        {
            if (txtLugarFallecimientoContratos.Text.Trim() == "")
            {
                lblErrorLugarNuevoContrato.Text = "Campo Obligatorio";
                btnSiguienteNuevoContrato.Enabled = false;

            }
            else
            {
                lblErrorLugarNuevoContrato.Text = "";
                btnSiguienteNuevoContrato.Enabled = true;
            }
        }

        private void txtNombreContratanteContratos_Leave(object sender, EventArgs e)
        {
            if (txtNombreContratanteContratos.Text.Trim() == "")
            {
                lblErrorNombreContratanteNuevoContrato.Text = "Campo Obligatorio";
                btnSiguienteNuevoContrato.Enabled = false;

            }
            else
            {
                lblErrorNombreContratanteNuevoContrato.Text = "";
                btnSiguienteNuevoContrato.Enabled = true;
            }
        }

        private void txtFonoContratanteContrato_Leave(object sender, EventArgs e)
        {
            if (txtFonoContratanteContrato.Text.Trim() == "")
            {
                lblErrorFonoNuevoContrato.Text = "Campo Obligatorio";
                btnSiguienteNuevoContrato.Enabled = false;

            }
            else
            {
                lblErrorFonoNuevoContrato.Text = "";
                btnSiguienteNuevoContrato.Enabled = true;
            }
        }

        private void txtDireccionContratanteNuevoContrato_Leave(object sender, EventArgs e)
        {
            if (txtDireccionContratanteNuevoContrato.Text.Trim() == "")
            {
                lblErrorDireccionNuevoContrato.Text = "Campo Obligatorio";
                btnSiguienteNuevoContrato.Enabled = false;

            }
            else
            {
                lblErrorDireccionNuevoContrato.Text = "";
                btnSiguienteNuevoContrato.Enabled = true;
            }
        }

        private void txtFonoContratanteContrato_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxServicios_Enter(object sender, EventArgs e)
        {

        }

        private void btnModificarContratoBuscarContratos_Click(object sender, EventArgs e)
        {
            cn.Close();
            cn.Open();

            try
            {


                String q = "UPDATE Contrato set  nombreFallecido='" + txtNombreFallecidoMostrarContratos.Text + "', lugarFallecimiento='" + txtLugarFallecimientoMostrarContratos.Text + "', fechaFallecimiento='" + dtpFechaFallecimientoMostrarContratos.Text + "', rutContratante='" + txtRutContratanteMostrarContratos.Text + "', nombreContratante='" + txtNombreContratanteMostrarContratos.Text + "', fonoContratante='" + txtFonoContratanteMostrarContrato.Text + "', folioCertificado='" + txtFolioMostrarContrato.Text + "', fechaContratacion='" + dtpFechaFallecimientoMostrarContratos.Text + "', valorNeto='" + txtValorNetoMostrarContratos.Text + "', iva='" + txtIvaMostrarContratos.Text + "', totalServicio='" + txtTotalMostrarContrato.Text + "', vendedor='" + txtVendedorMostrarContrato.Text + "', servicioEntregado='" + txtServicioContratadoMostrarContrato.Text + "', horaFallecimiento='" + txtHoraMostrarContrato.Text + "', direccionContratante='" + txtDireccionContratanteMostrarContrato.Text + "', agregados='" + txtAgregadosMostrarContrato.Text + "'where [rut]='" + txtRutFallecidoMostrarContrato.Text + "';";
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                cn.Close();

              

                MessageBox.Show("Modificacion exitosa");


            }
            catch (Exception m)
            {
                MessageBox.Show(" " + m.Message + " ");
            }
        }




        private void rbBuscarTodosBuscarContratos_CheckedChanged(object sender, EventArgs e)
        {
            txtRutFallecidoBuscarContratos.Enabled = false;
            txtRutContratanteBuscarContratos.Enabled = false;
            dtpFechaContratoBuscarContrato.Enabled = false;
            cbxVendedorBuscarContrato.Enabled = false;
            txtRutFallecidoBuscarContratos.Clear();
            txtRutContratanteBuscarContratos.Clear();
            btnBuscarContratos.Enabled = true;
        }




    }
}


