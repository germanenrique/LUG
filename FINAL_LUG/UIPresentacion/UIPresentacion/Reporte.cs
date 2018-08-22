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

namespace UIPresentacion
{
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        ReporteBLL rBll = new ReporteBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            string store = "s_VehiculosMasRentados";
            ObtenerReporteVehiculo(store);
        }
        private void ObtenerReporteVehiculo(string store)
        {
            grillaResultados.DataSource = null;
            DataSet ds = rBll.ObtenerReporte(store);

            grillaResultados.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string store = "s_VehiculosMenosRentados";
            ObtenerReporteVehiculo(store);
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            
        }

        void CambiarIdiomaIngles()
        {


            btnMasRentados.Text = Resource1.btnMasRentados;
            btnMenosRentados.Text = Resource1.btnMenosRentados;


        }

        void CambiarIdiomaEspañol()
        {


            btnMasRentados.Text = Resource2.btnMasRentados;
            btnMenosRentados.Text = Resource2.btnMenosRentados;


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaEspañol();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaIngles();
        }
    }
}
