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

namespace Funeraria_2._0.Contratos
{
    public partial class SeleccionarContrato : Form
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbConnection cn = new OleDbConnection();
        public static string modificarContrato ="";
        public static bool validar;

        public SeleccionarContrato()
        {
            InitializeComponent();
        }

        private void SeleccionarContrato_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'funerariaBD.Contrato' Puede moverla o quitarla según sea necesario.
            //this.contratoTableAdapter.Fill(this.funerariaBD.Contrato);
            cn.ConnectionString = Login.conexion;
            cmd.Connection = cn;
            OleDbDataReader dr;

            string datos = MenuContratos.datoFiltro;
            int tipoDato= MenuContratos.opcDatos;
            String consulta = "";

            cn.Open();
            try
            {

                switch(tipoDato){
                    case 1 :
                         consulta = "select * from Contrato where rutFallecido='" + datos + "';";
                        //consulta = "SELECT  rutFallecido, nombreFallecido, lugarFallecimiento, fechaFallecimiento, rutContratante, nombreContratante, fonoContratante, folioCertificado, fechaContratacion, valorNeto, iva, totalServicio, vendedor FROM Contrato WHERE (rutFallecido = 'prueba1');";
                        break;
                    case 2:
                        consulta = "select * from Contrato where rutContratante='" + datos + "';";
                        break;
                    case 3:
                        consulta = "select * from Contrato where fechaContratacion='" + datos + "';";
                        break;
                    case 4:
                        consulta = "select * from Contrato where vendedor='" + datos + "';";
                        break;
                    case 5:
                        consulta = "select * from Contrato ;";
                        break;


                }

                

                cmd = new OleDbCommand(consulta, cn);
                dr = cmd.ExecuteReader();

                

                Boolean registros = dr.HasRows;

                if (registros)
                {
                    while (dr.Read())
                    {

                        lbxRutFall.Items.Add(dr[0].ToString());
                        lbxNombrefall.Items.Add(dr[1].ToString());
                        //lbxLugarFall.Items.Add(dr[2].ToString());
                        //lbxFechaFall.Items.Add(dr[3].ToString());
                        lbxRutContra.Items.Add(dr[4].ToString());
                        lbxNombreContr.Items.Add(dr[5].ToString());
                        //lbxFonoContr.Items.Add(dr[6].ToString());
                        //lbxFolio.Items.Add(dr[7].ToString());
                        lbxFechaContr.Items.Add(dr[8].ToString());
                        //lbxValorNeto.Items.Add(dr[9].ToString());
                        //lbxIva.Items.Add(dr[10].ToString());
                        //lbxTotal.Items.Add(dr[11].ToString());
                        lbxVendedor.Items.Add(dr[12].ToString());


                    }
                }
                else
                {
                    MessageBox.Show("No se encuentran contratos con los datos ingresados", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Hide();
                    MenuContratos menu = new MenuContratos();
                    menu.ShowDialog();
                    
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

        public void seleccionarLbx(object sender, EventArgs e)
        {

            ListBox l = sender as ListBox;
            if (l.SelectedIndex != -1)
            {

                lbxRutFall.SelectedIndex = l.SelectedIndex;
                lbxNombrefall.SelectedIndex = l.SelectedIndex;
                //lbxLugarFall.SelectedIndex = l.SelectedIndex;
                //lbxFechaFall.SelectedIndex = l.SelectedIndex;
                lbxRutContra.SelectedIndex = l.SelectedIndex;
                lbxNombreContr.SelectedIndex = l.SelectedIndex;
                //lbxFonoContr.SelectedIndex = l.SelectedIndex;
                //lbxFolio.SelectedIndex = l.SelectedIndex;
                lbxFechaContr.SelectedIndex = l.SelectedIndex;
                //lbxValorNeto.SelectedIndex = l.SelectedIndex;
                //lbxIva.SelectedIndex = l.SelectedIndex;
                //lbxTotal.SelectedIndex = l.SelectedIndex;
                lbxVendedor.SelectedIndex = l.SelectedIndex;
            }
                 
        }

        private void btnSalirSeleccionarContrato_Click(object sender, EventArgs e)
        {

            Contratos.MenuContratos menuCon = new MenuContratos();
            this.Hide();
            menuCon.ShowDialog();
            this.Close();
        }

        private void btnModificarSeleccionarContrato_Click(object sender, EventArgs e)
        {
            if (lbxRutFall.SelectedIndex != -1)
            {

                modificarContrato = lbxRutFall.Text;
                //habilitado = true;

                Contratos.MenuContratos menuCon = new MenuContratos();

                validar = true;
                this.Hide();
                menuCon.ShowDialog();
                this.Close();


            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento.");
            }
        }

        private void btnEliminarSeleccionarContrato_Click(object sender, EventArgs e)
        {
            if (lbxRutFall.SelectedIndex != -1)
            {
                string q = "DELETE FROM Contrato WHERE [rutFallecido] = '" + lbxRutFall.Text + "'";
                try
                {
                    cn.Open();
                    cmd.CommandText = q;
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    cargarDatos();

                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void cargarDatos()
        {

            lbxRutFall.Items.Clear();
            lbxNombrefall.Items.Clear();
            lbxRutContra.Items.Clear();
            lbxNombreContr.Items.Clear();
            lbxFechaContr.Items.Clear();
            lbxVendedor.Items.Clear();
            try
            {

                cn.Open();
                String consulta = "select * from Contrato";

                OleDbDataReader dr;
                cmd = new OleDbCommand(consulta, cn);
                dr = cmd.ExecuteReader();



                Boolean registros = dr.HasRows;

                if (registros)
                {
                    while (dr.Read())
                    {

                        lbxRutFall.Items.Add(dr[0].ToString());
                        lbxNombrefall.Items.Add(dr[1].ToString());
                        //lbxLugarFall.Items.Add(dr[2].ToString());
                        //lbxFechaFall.Items.Add(dr[3].ToString());
                        lbxRutContra.Items.Add(dr[4].ToString());
                        lbxNombreContr.Items.Add(dr[5].ToString());
                        //lbxFonoContr.Items.Add(dr[6].ToString());
                        //lbxFolio.Items.Add(dr[7].ToString());
                        lbxFechaContr.Items.Add(dr[8].ToString());
                        //lbxValorNeto.Items.Add(dr[9].ToString());
                        //lbxIva.Items.Add(dr[10].ToString());
                        //lbxTotal.Items.Add(dr[11].ToString());
                        lbxVendedor.Items.Add(dr[12].ToString());

                    }
                }
                dr.Close();
                cn.Close();

            }
            catch (Exception m)
            {
                MessageBox.Show(" " + m.Message + " ");
            }
        }

    }
}
