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
    public partial class NuevoContrato : Form
    {

        
        public static bool nuevo = true;
        string totaltxt;
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        OleDbDataReader dr;
        private string agregados;


        public NuevoContrato()
        {
            InitializeComponent();
        }

        private void NuevoContrato_Load(object sender, EventArgs e)
        {
            btnAgregarNuevoContrato.Enabled = false;
            try
            {
                cn.ConnectionString = Login.conexion ;
                cmd.Connection = cn;



                cn.Open();
                String consulta = "select idUrna from Servicios; ";

                cmd = new OleDbCommand(consulta, cn);
                dr = cmd.ExecuteReader();

                Boolean registros = dr.HasRows;

                if (registros)
                {
                    while (dr.Read())
                    {
                        cbxServicioNuevoContrato.Items.Add(dr[0]);

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


        }
        private void ObtenerAgregados()
        {

            if (clbAgregados.GetItemChecked(0).Equals(true))
            {
                agregados = "Arreglo Floral, ";
            }
            else
            {
                agregados = "";
            }
            if (clbAgregados.GetItemChecked(1).Equals(true))
            {
                agregados = agregados + "Libro de Condolencia, ";
            }
            else
            {
                agregados += "";
            }
            if (clbAgregados.GetItemChecked(2).Equals(true))
            {
                agregados = agregados + "Trámite legal interno(Registro Civil), ";
            }
            else
            {
                agregados += "";
            }
            if (clbAgregados.GetItemChecked(3).Equals(true))
            {
                agregados = agregados + "Minibus de acompañamiento, ";
            }
            else
            {
                agregados += "";
            }
            if (clbAgregados.GetItemChecked(4).Equals(true))
            {
                agregados += agregados + "Auto de acompañamiento, ";
            }
            else
            {
                agregados += "";
            }
            if (clbAgregados.GetItemChecked(5).Equals(true))
            {
                agregados = agregados + "Capilla electrónica o capilla ardiente, ";
            }
            else
            {
                agregados += "";
            }
            if (clbAgregados.GetItemChecked(6).Equals(true))
            {
                agregados = agregados + "Capilla con vela, ";
            }
            else
            {
                agregados += "";
            }
            if (clbAgregados.GetItemChecked(7).Equals(true))
            {
                agregados = agregados + "Tarjetero, ";
            }
            else
            {
                agregados += "";
            }
            if (clbAgregados.GetItemChecked(8).Equals(true))
            {
                agregados = agregados + "Cafetería, ";
            }
            else
            {
                agregados += "";
            }
            if (clbAgregados.GetItemChecked(9).Equals(true))
            {
                agregados = agregados + "Carroza Panorámica, ";
            }
            else
            {
                agregados += "";
            }
            if (clbAgregados.GetItemChecked(10).Equals(true))
            {
                agregados = agregados + "Tarjeta de agradecimiento, ";
            }
            else
            {
                agregados += "";
            }
            if (clbAgregados.GetItemChecked(11).Equals(true))
            {
                agregados = agregados + "Coro polifónico, ";
            }
            else
            {
                agregados += "";
            }
            if (clbAgregados.GetItemChecked(12).Equals(true))
            {
                agregados = agregados + "Aviso de defunción en Prensa. ";
            }
            else
            {
                agregados += "";
            }


        }
        private void txtTotalNuevoContrato_TextChanged(object sender, EventArgs e)
        {

            //double supTotal = double.Parse(txtSubtotal.Text);
            //double iva = double.Parse(txtIVA.Text);
            //double ivaTotal = iva / 100;
            //double total = ivaTotal * supTotal;
            //double totalFinal = total + supTotal;
            //txtIVA.Text = Convert.ToString(ivaTotal);
            //txtTotal.Text = Convert.ToString(totalFinal);
            //txtTotalIVA.Text = Convert.ToString(total);



            double nIva = (double.Parse(txtTotalNuevoContrato.Text) * 0.19);
            txtIvaNuevoContrato.Text = Convert.ToString(nIva);
            txtIvaNuevoContrato.Text = string.Format("{0:#,##0.##}", Convert.ToDouble(txtIvaNuevoContrato.Text));


            double nNeto = (double.Parse(txtTotalNuevoContrato.Text) * 0.81);
            txtNetoNuevoContrato.Text = Convert.ToString(nNeto);
            txtNetoNuevoContrato.Text = string.Format("{0:#,##0.##}", Convert.ToDouble(txtNetoNuevoContrato.Text));


        }

        private void cbxServicioNuevoContrato_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = Login.conexion;
                cmd.Connection = cn;




                cn.Open();
                String consulta = "select * from Servicios where [idUrna]='" + cbxServicioNuevoContrato.SelectedItem.ToString() + "';";

                cmd = new OleDbCommand(consulta, cn);
                dr = cmd.ExecuteReader();

                Boolean registros = dr.HasRows;

                if (registros)
                {
                    while (dr.Read())
                    {
                        txtModeloUrnaNuevoContrato.Text = dr["modeloUrna"].ToString();
                        txtNombreUrnaNuevoContrato.Text = dr["nombreUrna"].ToString();

                        if (ckbRebajaNuevoContrato.Checked == true)
                        {
                            txtTotalNuevoContrato.Text = string.Format("{0:#,##0.##}", Convert.ToDouble(dr["precioServRebaja"].ToString()));
                        }
                        else
                        {
                            txtTotalNuevoContrato.Text = string.Format("{0:#,##0.##}", Convert.ToDouble(dr["precioServicio"].ToString()));
                        }



                        if (dr["arregloFloral"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(0, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(0, false);
                        }
                        ///////////////////////////////////////////
                        if (dr["LibroCondolencia"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(1, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(1, false);
                        }
                        ///////////////////////////////////////////
                        if (dr["TramLegal"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(2, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(2, false);
                        }
                        ///////////////////////////////////////////
                        if (dr["MiniBusAcomp"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(3, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(3, false);
                        }
                        ///////////////////////////////////////////
                        if (dr["AutoAcomp"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(4, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(4, false);
                        }
                        ///////////////////////////////////////////
                        if (dr["CapillaArd"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(5, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(5, false);
                        }
                        ///////////////////////////////////////////
                        if (dr["CapillaVela"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(6, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(6, false);
                        }
                        ///////////////////////////////////////////
                        if (dr["Tarjetero"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(7, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(7, false);
                        }
                        ///////////////////////////////////////////
                        if (dr["Cafeteria"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(8, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(8, false);
                        }
                        ///////////////////////////////////////////
                        if (dr["CarrozaPano"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(9, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(9, false);
                        }
                        ///////////////////////////////////////////
                        if (dr["TarjAgrade"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(10, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(10, false);
                        }
                        ///////////////////////////////////////////
                        if (dr["AvisoDiario"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(11, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(11, false);
                        }
                        ///////////////////////////////////////////
                        if (dr["Traslados"].Equals(true))
                        {
                            clbAgregados.SetItemChecked(12, true);
                        }
                        else
                        {
                            clbAgregados.SetItemChecked(12, false);
                        }
                        ///////////////////////////////////////////




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





        }

        private void btnMarcarTodosNuevoContrato_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= clbAgregados.Items.Count - 1; i++)
            {

                clbAgregados.SetItemChecked(i, true);
            }

        }

        private void btnDesmarcarTodosNuevoContrato_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= clbAgregados.Items.Count - 1; i++)
            {

                clbAgregados.SetItemChecked(i, false);
            }
        }



        private void btnSalirNuevoContrato_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

        private void btnAgregarNuevoContrato_Click(object sender, EventArgs e)
        {
            
            
            string servicio, nombreUrna, modeloUrna, valorServicio, iva, valorNeto, total,rut;
            servicio = cbxServicioNuevoContrato.SelectedItem.ToString();
            nombreUrna = txtNombreUrnaNuevoContrato.Text;
            modeloUrna = txtModeloUrnaNuevoContrato.Text;
            valorServicio = txtTotalNuevoContrato.Text;
            iva = txtIvaNuevoContrato.Text;
            valorNeto = txtNetoNuevoContrato.Text;
            total = txtTotal.Text;
            ObtenerAgregados();
            rut = MenuContratos.rutfallecido;
            
            //Abrir la conexión.
            cn.Open();

            //Preparación de consulta para validar
            String consulta = "select * from Contrato where [rutFallecido]= '" + rut + "'; ";
            //Ejecución de consulta.

            OleDbCommand cmd = new OleDbCommand(consulta, cn);
            dr = cmd.ExecuteReader();
            //Asignacion de resultado.
            Boolean registros = dr.HasRows;
            //Verificacion de existencia de usuario.
            if (registros)
            {
                //Despliegue de alerta.
                MessageBox.Show("Contrato ya registrado, por favor, ingrese uno distinto.");
                //Cierre de conexión.
                cn.Close();
                dr.Close();
                //Variable retorno ventana anterior
                nuevo = false;
                //Limpiar variables estaticas
                MenuContratos.rutfallecido = "";
                MenuContratos.nombreFallecido = "";
                MenuContratos.fechaFallecimiento = "";
                MenuContratos.folio = "";
                MenuContratos.lugarFallecimiento = "";
                MenuContratos.horaFallecimiento = "";
                //datos contratante
                MenuContratos.rutContratante = "";
                MenuContratos.nombreContratante = "";
                MenuContratos.fonoContratante = "";
                MenuContratos.direccionContratante = "";
                MenuContratos.fechaContratacion = "";
                //Recarga Pagina
                Contratos.MenuContratos contrato = new MenuContratos();
                this.Hide();
                contrato.ShowDialog();
                this.Close();

            }
            else
            {
                try
                {
                    dr.Close();


                    //Preparación de consulta.
                    String q = "INSERT INTO Contrato ([rutFallecido], nombreFallecido, lugarFallecimiento, fechaFallecimiento, rutContratante, nombreContratante, fonoContratante, folioCertificado, fechaContratacion, valorNeto, iva, totalServicio, vendedor, servicioEntregado, horaFallecimiento, direccionContratante, agregados) values ('" + rut + "','" + MenuContratos.nombreFallecido + "','" + MenuContratos.lugarFallecimiento + "','" + MenuContratos.fechaFallecimiento + "','" + MenuContratos.rutContratante + "','" + MenuContratos.nombreContratante + "','" + MenuContratos.fonoContratante + "','" + MenuContratos.folio + "','" + MenuContratos.fechaContratacion + "','" + valorNeto + "','" + iva + "','" + totaltxt + "','" + Login.nombre + "','" + servicio + "','" + MenuContratos.horaFallecimiento + "','" + MenuContratos.direccionContratante + "','" + agregados + "')";
                    //Ejecución de consulta.
                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                    //mensaje de confirmacion
                    MessageBox.Show("Contrato agregado correctamente.");
                    //Cierre de conexión.
                    cn.Close();
                    //Limpiar variables estaticas
                    MenuContratos.rutfallecido = "";
                    MenuContratos.nombreFallecido = "";
                    MenuContratos.fechaFallecimiento = "";
                    MenuContratos.folio = "";
                    MenuContratos.lugarFallecimiento = "";
                    MenuContratos.horaFallecimiento = "";
                    //datos contratante
                    MenuContratos.rutContratante = "";
                    MenuContratos.nombreContratante = "";
                    MenuContratos.fonoContratante = "";
                    MenuContratos.direccionContratante = "";
                    MenuContratos.fechaContratacion = "";

                    
                    this.Close();

                }
                catch (Exception m)
                {
                    MessageBox.Show(" " + m.Message + " ");
                    cn.Close();
                }

            }




        }

        private void ckbRebajaNuevoContrato_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cn.ConnectionString = Login.conexion;
                cmd.Connection = cn;




                cn.Open();
                String consulta = "select * from Servicios where [idUrna]='" + cbxServicioNuevoContrato.SelectedItem.ToString() + "';";

                cmd = new OleDbCommand(consulta, cn);
                dr = cmd.ExecuteReader();

                Boolean registros = dr.HasRows;

                if (registros)
                {
                    while (dr.Read())
                    {
                       
                        if (ckbRebajaNuevoContrato.Checked == true)
                        {
                            txtTotalNuevoContrato.Text = string.Format("{0:#,##0.##}", Convert.ToDouble(dr["precioServRebaja"].ToString()));
                        }
                        else
                        {
                            txtTotalNuevoContrato.Text = string.Format("{0:#,##0.##}", Convert.ToDouble(dr["precioServicio"].ToString()));
                        }


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
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            else
            {
                e.Handled = true;
            }
            if (txtTotal.Text.Trim() == "")
            {
                lblErrorTotal.Text = "Campo Obligatorio";
                btnAgregarNuevoContrato.Enabled = false;

            }
            else
            {
                lblErrorTotal.Text = "";
                btnAgregarNuevoContrato.Enabled = true;
            }
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            if (txtTotal.Text.Trim() == "")
            {
                lblErrorTotal.Text = "Campo Obligatorio";

                btnAgregarNuevoContrato.Enabled = false;
            }
            else
            {

                if (int.Parse(txtTotal.Text) < 0)
                {
                    lblErrorTotal.Text = "No se admiten numeros negativos";
                    btnAgregarNuevoContrato.Enabled = true;
                }
                else
                {
                    totaltxt = txtTotal.Text;
                    txtTotal.Text = string.Format("{0:#,##0.##}", Convert.ToDouble(txtTotal.Text));

                    lblErrorTotal.Text = "";
                    btnAgregarNuevoContrato.Enabled = true;
                }
            }
        }

        
    }
}

