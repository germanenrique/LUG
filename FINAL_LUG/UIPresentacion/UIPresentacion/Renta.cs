using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTIDADES;

namespace UIPresentacion
{
    public partial class Renta : Form
    {
        ClienteBLL cBll = new ClienteBLL();
        VehiculoBLL vBll = new VehiculoBLL();
        RentaBLL rBll = new RentaBLL();
        public Renta()
        {
            InitializeComponent();
        }

        private void Renta_Load(object sender, EventArgs e)
        {
            CargarCombos();
            ObtenerRentas();
        }
        void CambiarIdiomaIngles()
        {


            lblCliente.Text = Resource1.lblCliente;
            lblDias.Text = Resource1.lblDias;
            lblImporte.Text = Resource1.lblImporte;
            lblVehiculos.Text = Resource1.lblVehiculos;
            btnAlquilar.Text = Resource1.btnAlquilar;
            btnCalcularImporte.Text = Resource1.btnCalcularImporte;

        }

        void CambiarIdiomaEspañol()
        {


            lblCliente.Text = Resource2.lblCliente;
            lblDias.Text = Resource2.lblDias;
            lblImporte.Text = Resource2.lblImporte;
            lblVehiculos.Text = Resource2.lblVehiculos;
            btnAlquilar.Text = Resource2.btnAlquilar;
            btnCalcularImporte.Text = Resource2.btnCalcularImporte;

        }

        private void CargarCombos()
        {
            cbClientes.DataSource = null;
            cbClientes.DataSource = cBll.ObtenerClientes();
            cbClientes.DisplayMember = "DNI";
            cbClientes.ValueMember = "ID";


            lbVehiculos.DataSource = null;
            lbVehiculos.DataSource = vBll.ObtenerVehiculos();
        }

        private void ObtenerRentas()
        {
            List<ClsRenta> rentas = rBll.ObtenerRentas();

            grillaRentas.DataSource = null;
            grillaRentas.DataSource = rentas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClsVehiculos veh = (ClsVehiculos)lbVehiculos.SelectedItem;

            if (!txtDias.Text.Equals(string.Empty))
            {
                int cantDias = Convert.ToInt32(txtDias.Text);
                int importe = cantDias * 200;

                if (veh.Tipo.Equals("Auto"))
                    importe += cantDias * 50;

                if (veh.Tipo.Equals("Suv"))
                    importe += cantDias * 75;

                if (veh.Tipo.Equals("Camioneta"))
                    importe += cantDias * 125;

                if (veh.Tipo.Equals("Camión"))
                    importe += cantDias * 200;


                txtImporte.Text = importe.ToString();
                btnAlquilar.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClsRenta r = new ClsRenta();
                r.IDCliente = Convert.ToInt32(cbClientes.SelectedValue);
                r.IDVehiculo = Convert.ToInt32(((ClsVehiculos)lbVehiculos.SelectedValue).ID);
                r.Dias = Convert.ToInt32(txtDias.Text);
                r.Importe = Convert.ToInt32(txtImporte.Text);

                rBll.Insertar(r);

                ObtenerRentas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaIngles();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaEspañol();
        }
    }
}
