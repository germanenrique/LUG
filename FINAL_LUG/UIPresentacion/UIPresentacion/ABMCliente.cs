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
using System.Text.RegularExpressions;

namespace UIPresentacion
{
    public partial class ABMCliente : Form
    {
        ClienteBLL cBll = new ClienteBLL();
        public ABMCliente()
        {
            InitializeComponent();
        }

        private void ABMCliente_Load(object sender, EventArgs e)
        {
            ObtenerClientes();
        }

        void CambiarIdiomaIngles()
        {


            lblApellido.Text = Resource1.lblApellido;
            lblNombre.Text = Resource1.lblNombre;
            lblDNI.Text = Resource1.lblDNI;
            lblFechaNac.Text = Resource1.lblFechaNac;
            btnAlta.Text = Resource1.btnAlta;
            btnBaja.Text = Resource1.btnBaja;
            btnModificacion.Text = Resource1.btnModificacion;
            btnLimpiar.Text = Resource1.btnLimpiar;




        }
        void CambiarIdiomaEspañol()
        {


            lblApellido.Text = Resource2.lblApellido;
            lblNombre.Text = Resource2.lblNombre;
            lblDNI.Text = Resource2.lblDNI;
            lblFechaNac.Text = Resource2.lblFechaNac;
            btnAlta.Text = Resource2.btnAlta;
            btnBaja.Text = Resource2.btnBaja;
            btnModificacion.Text = Resource2.btnModificacion;
            btnLimpiar.Text = Resource2.btnLimpiar;




        }
        private void ObtenerClientes()
        {
            List<ClsCliente> clientes = cBll.ObtenerClientes();

            grillaClientes.DataSource = null;
            grillaClientes.DataSource = clientes;
        }
        private bool validarCampos()
        {
            bool res = true;
            Regex reg = new Regex("^[a-zA-Z]+$");
            if (!reg.IsMatch(txtNombre.Text))
                return false;

            if (!reg.IsMatch(txtApellido.Text))
                return false;

            reg = new Regex(@"^\d+$");
            if (!reg.IsMatch(txtDNI.Text))
                return false;

            reg = new Regex(@"^[0-9]{2}/[0-9]{2}/[0-9]{4}$");
            string fechaNac = Convert.ToDateTime(dtFechaNac.Text).ToString("dd/MM/yyyy");
            if (!reg.IsMatch(fechaNac))
                return false;

            reg = new Regex(@"[\w+](\w.)?@[a-zA-Z]+\.[a-zA-Z]{3}$");
            if (!reg.IsMatch(txtEmail.Text))
                return false;

            return res;
        }

        private void grillaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = grillaClientes.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtNombre.Text = grillaClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtApellido.Text = grillaClientes.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            txtDNI.Text = grillaClientes.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
            dtFechaNac.Text = grillaClientes.Rows[e.RowIndex].Cells["FechaNac"].Value.ToString();
            txtEmail.Text = grillaClientes.Rows[e.RowIndex].Cells["Email"].Value.ToString();
        }
        private void grillaClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = grillaClientes.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            txtNombre.Text = grillaClientes.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            txtApellido.Text = grillaClientes.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();
            txtDNI.Text = grillaClientes.Rows[e.RowIndex].Cells["DNI"].Value.ToString();
            dtFechaNac.Text = grillaClientes.Rows[e.RowIndex].Cells["FechaNac"].Value.ToString();
            txtEmail.Text = grillaClientes.Rows[e.RowIndex].Cells["Email"].Value.ToString();
        }

        private void Alta_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    ClsCliente c = new ClsCliente();
                    c.Nombre = txtNombre.Text;
                    c.Apellido = txtApellido.Text;
                    c.DNI = Convert.ToInt32(txtDNI.Text);
                    c.FechaNac = Convert.ToDateTime(dtFechaNac.Text);
                    c.Email = txtEmail.Text;

                    cBll.Insertar(c);

                    ObtenerClientes();
                }
                else
                {
                    MessageBox.Show("Datos mal ingresados");
                    return;
                }

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
                if (validarCampos())
                {
                    ClsCliente c = new ClsCliente();
                    c.ID = Convert.ToInt32(txtID.Text);
                    c.Nombre = txtNombre.Text;
                    c.Apellido = txtApellido.Text;
                    c.DNI = Convert.ToInt32(txtDNI.Text);
                    c.FechaNac = Convert.ToDateTime(dtFechaNac.Text);
                    c.Email = txtEmail.Text;

                    cBll.Actualizar(c);

                    ObtenerClientes();
                }
                else
                {
                    MessageBox.Show("Datos mal ingresados");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ClsCliente c = new ClsCliente();
                c.ID = Convert.ToInt32(txtID.Text);

                cBll.Eliminar(c);

                ObtenerClientes();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtID.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            txtEmail.Text = null;
            dtFechaNac.Text = null;
            txtDNI.Text = null;
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
