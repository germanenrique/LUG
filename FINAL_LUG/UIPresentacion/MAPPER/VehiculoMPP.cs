using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDADES;
using System.Collections;
using System.Data;

namespace MAPPER
{
   public class VehiculoMPP
    {
        Datos data = new Datos();
        public void InsertarActualizar(ClsVehiculos v)
        {
            try
            {
                Hashtable table = new Hashtable();
                string store = "s_InsertarVehiculo";

                if (v.ID != 0)
                {
                    store = "s_ModificarVehiculo";
                    table.Add("@ID", v.ID);
                }

                table.Add("@Marca", v.Marca);
                table.Add("@Modelo", v.Modelo);
                table.Add("@Patente", v.Patente);
                table.Add("@Tipo", v.Tipo);

                data.Escribir(store, table);
            }
            catch (Exception)
            {
                return;
            }
        }

        public List<ClsVehiculos> ObtenerVehiculos()
        {
            List<ClsVehiculos> vehs = new List<ClsVehiculos>();
            DataTable dt = new DataTable();
            string store = "s_listarVehiculo";

            dt = data.Leer(store);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ClsVehiculos v = new ClsVehiculos();
                    v.ID = Convert.ToInt32(row["ID"].ToString());
                    v.Marca = row["Marca"].ToString();
                    v.Modelo = row["Modelo"].ToString();
                    v.Patente = row["Patente"].ToString();
                    v.Tipo = row["Tipo"].ToString();

                    vehs.Add(v);
                }
            }

            return vehs;
        }

        public void Eliminar(ClsVehiculos v)
        {
            try
            {
                string store = "s_EliminarVehiculo";
                Hashtable table = new Hashtable();
                table.Add("@ID", v.ID);

                data.Escribir(store, table);
            }
            catch (Exception)
            {
                return;
            }
        }
    }
}
