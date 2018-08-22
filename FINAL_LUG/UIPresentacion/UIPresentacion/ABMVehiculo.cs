using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTIDADES;
using BLL;
using System.IO;
using System.Xml.Linq;

namespace UIPresentacion
{
    public partial class ABMVehiculo : Form
    {
        VehiculoBLL vBll = new VehiculoBLL();
        public ABMVehiculo()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void ABMVehiculo_Load(object sender, EventArgs e)
        {
            CargarTipos();
            ObtenerVehiculos();
            CrearXML();
            CargarDatosXML();
        }
        void CargarDatosXML()
        {
            
            DataSet DS = new DataSet();
            DS.ReadXml("Vehiculos.xml");
            chart1.DataSource = DS;
            chart1.Series[0].XValueMember = "Marca";
            chart1.Series[0].YValueMembers = "Modelo";
            chart1.ChartAreas[0].Area3DStyle.Enable3D = true;
            chart1.DataBind();
        }
        void CambiarIdiomaIngles()
        {


            lblID.Text = Resource1.lblID;
            lblMarca.Text = Resource1.lblMarca;
            lblModelo.Text = Resource1.lblModelo;
            lblPatente.Text = Resource1.lblPatente;
            lblTipo.Text = Resource1.lblTipo;
            btnAlta.Text = Resource1.btnAlta;
            btnBaja.Text = Resource1.btnBaja;
            btnModificacion.Text = Resource1.btnModificacion;
            btnLimpiar.Text = Resource1.btnLimpiar;
            


        }
        void CambiarIdiomaEspañol()
        {


            lblID.Text = Resource2.lblID;
            lblMarca.Text = Resource2.lblMarca;
            lblModelo.Text = Resource2.lblModelo;
            lblPatente.Text = Resource2.lblPatente;
            lblTipo.Text = Resource2.lblTipo;
            btnAlta.Text = Resource2.btnAlta;
            btnBaja.Text = Resource2.btnBaja;
            btnModificacion.Text = Resource2.btnModificacion;
            btnLimpiar.Text = Resource2.btnLimpiar;



        }
        private void CargarTipos()
        {
            cbTipos.Items.Add("Auto");
            cbTipos.Items.Add("Suv");
            cbTipos.Items.Add("Camioneta");
            cbTipos.Items.Add("Camión");
        }
        private void CrearXML()
        {
            if (!File.Exists("Vehiculos"))
            {
                XDocument doc = new XDocument(new XElement("Vehiculos"));
                doc.Save("Vehiculos.xml");
            }
        }

        private void ObtenerVehiculos()
        {
            List<ClsVehiculos> vehs = vBll.ObtenerVehiculos();

            grillaVehiculos.DataSource = null;
            grillaVehiculos.DataSource = vehs;
        }
        private void AgregarXML(ClsVehiculos v)
        {
            XDocument doc = XDocument.Load("Vehiculos.xml");
            doc.Element("Vehiculos").Add(new XElement("Vehiculo", new XAttribute("Tipo", v.Tipo),
                                        new XElement("Marca", v.Marca),
                                        new XElement("Modelo", v.Modelo),
                                        new XElement("Patente", v.Patente)));

            doc.Save("Vehiculos.xml");

            txtXml.Text = doc.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClsVehiculos v = new ClsVehiculos();
                v.Marca = txtMarca.Text;
                v.Modelo = txtModelo.Text;
                v.Patente = txtPatente.Text;
                v.Tipo = cbTipos.SelectedItem.ToString();

                vBll.Insertar(v);

                ObtenerVehiculos();
                AgregarXML(v);
                CargarDatosXML();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ClsVehiculos v = new ClsVehiculos();
                v.ID = Convert.ToInt32(txtID.Text);
                v.Marca = txtMarca.Text;
                v.Modelo = txtModelo.Text;
                v.Patente = txtPatente.Text;
                v.Tipo = cbTipos.SelectedItem.ToString();

                vBll.Actualizar(v);

                ObtenerVehiculos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ClsVehiculos v = new ClsVehiculos();
                v.ID = Convert.ToInt32(txtID.Text);

                vBll.Eliminar(v);

                ObtenerVehiculos();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
        }

        private void grillaVehiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = grillaVehiculos.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtMarca.Text = grillaVehiculos.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
            txtModelo.Text = grillaVehiculos.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();
            txtPatente.Text = grillaVehiculos.Rows[e.RowIndex].Cells["Patente"].Value.ToString();
            cbTipos.SelectedItem = grillaVehiculos.Rows[e.RowIndex].Cells["tipo"].Value.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaEspañol();
        }

        private void Español_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaIngles();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtMarca.Text = null;
            txtModelo.Text = null;
            txtPatente.Text = null;
            
        
        }
    }
}
