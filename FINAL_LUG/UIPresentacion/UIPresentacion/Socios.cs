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
using System.Data;
using ENTIDADES;
using BLL;

namespace UIPresentacion
{
    public partial class Socios : Form
    {
        public Socios()
        {
            InitializeComponent();
        }
        
        DataSet Dset = new DataSet();
        ClsSocio oSocio = new ClsSocio();
        Metodos OBLL = new BLL.Metodos();

        private void Socios_Load(object sender, EventArgs e)
        {
            Cargargrilla();
        }
        const string NombreTabla = "Socios";
        void Cargargrilla()
        {
            if (NombreTabla == "Socios")
            { Dset = oSocio.Listar(); }
          

           
            DesconectadoGrilla.DataSource = null;
            DesconectadoGrilla.DataSource = Dset.Tables[0];
        }
        void CambiarIdiomaIngles()
        {
            btnGrabar.Text = Resource1.btnGrabar;
            btnCargar.Text = Resource1.btnCargar;

        }
        void CambiarIdiomaEspañol()
        {
            btnGrabar.Text = Resource2.btnGrabar;
            btnCargar.Text = Resource2.btnCargar;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (NombreTabla == "Socios")
            {
                OBLL.GrabarCambios("Socios", Dset);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cargargrilla();
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
