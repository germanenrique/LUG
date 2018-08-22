using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS;
using System.Data.SqlClient;
using System.Resources;
using System.Globalization;
using System.Threading;


namespace UIPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        int count = 0;
        SqlConnection conexion = new SqlConnection();
        private void Login_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';

        }
      void CambiarIdiomaIngles(string Cultura)
        {
           

            lblContraseña.Text = Resource1.lblContraseña;
            lblUsuario.Text = Resource1.lblUsuario;
            btnEntrar.Text = Resource1.btnEntrar;
            radioEspañol.Text = Resource1.radioEspañol;
            radioIngles.Text = Resource1.radioIngles;
          

        }
        void CambiarIdiomaEspañol(string Cultura)
        {


            lblContraseña.Text = Resource2.lblContraseña;
            lblUsuario.Text = Resource2.lblUsuario;
            btnEntrar.Text = Resource2.btnEntrar;
            radioEspañol.Text = Resource2.radioEspañol;
            radioIngles.Text = Resource2.radioIngles;


        }



        private void button1_Click(object sender, EventArgs e)
        {
            conexion.ConnectionString = "Data Source=DESKTOP-Q67CN4Q\\SQLEXPRESS; Initial Catalog=FINAL_LUG; Integrated Security=Yes";

            SqlCommand cmd = new SqlCommand("Select usuario, password from Usuarios where usuario ='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conexion);
            conexion.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            count++;
            if (count == 4)
            {
                MessageBox.Show("Intento mas de 3 veces, se bloquea el programa");
                btnEntrar.Enabled = false;
                return;
            }
            if (dr.Read() == true)
            {
                MessageBox.Show("Bienvenido " + textBox1.Text);
                Form1 FORM1 = new Form1();
                FORM1.Show();
                
            }
           

            textBox1.Text = null;
            textBox2.Text = null;
            
            
            conexion.Close();






        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaIngles("Resource1");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaEspañol("Resource2");
        }
    }
}
