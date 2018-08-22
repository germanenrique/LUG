using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void aBMClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMCliente formCliente = new ABMCliente();
            formCliente.Show();
        }

        private void aBMVehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMVehiculo formVehiculo = new ABMVehiculo();
            formVehiculo.Show();
        }

        private void rentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Renta formRenta = new UIPresentacion.Renta();
            formRenta.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte formReporte = new Reporte();
            formReporte.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login formLogin = new UIPresentacion.Login();
            formLogin.Show();
        }

        private void sociosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Socios formSocios = new UIPresentacion.Socios();
            formSocios.Show();
        }
    }
}
