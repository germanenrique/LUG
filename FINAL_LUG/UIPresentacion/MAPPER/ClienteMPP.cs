using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using DATOS;
using ENTIDADES;

namespace MAPPER
{
    public class ClienteMPP
    {
        public Datos data = new Datos();

        public void InsertarActualizar(ClsCliente c)
        {
            string store = "s_InsertarCliente";
            Hashtable table = new Hashtable();

            if (c.ID != 0)
            {
                store = "s_ModificarCliente";
                table.Add("@ID", c.ID);
            }

            table.Add("@Nombre", c.Nombre);
            table.Add("@Apellido", c.Apellido);
            table.Add("@DNI", c.DNI);
            table.Add("@FechaNac", c.FechaNac);
            table.Add("@Email", c.Email);

            data.Escribir(store, table);
        }
        public List<ClsCliente> ObtenerClientes()
        {
            List<ClsCliente> clientes = new List<ClsCliente>();
            DataTable dt = new DataTable();

            string store = "s_listarCliente";

            dt = data.Leer(store);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ClsCliente c = new ClsCliente();
                    c.ID = Convert.ToInt32(row["ID"].ToString());
                    c.Nombre = row["Nombre"].ToString();
                    c.Apellido = row["Apellido"].ToString();
                    c.DNI = Convert.ToInt32(row["DNI"].ToString());
                    c.FechaNac = Convert.ToDateTime(row["FechaNac"].ToString());
                    c.Email = row["Email"].ToString();

                    clientes.Add(c);
                }
            }

            return clientes;
        }
        public void Eliminar(ClsCliente c)
        {
            try
            {
                string store = "s_EliminarCliente";
                Hashtable table = new Hashtable();
                table.Add("@ID", c.ID);

                data.Escribir(store, table);
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
