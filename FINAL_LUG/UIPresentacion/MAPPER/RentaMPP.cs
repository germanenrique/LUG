using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using DATOS;
using System.Collections;
using System.Data;

namespace MAPPER
{
   public class RentaMPP
    {
        Datos data = new Datos();

        public void Insertar(ClsRenta r)
        {
            string store = "s_InsertarRenta";
            Hashtable table = new Hashtable();

            table.Add("@IDCliente", r.IDCliente);
            table.Add("@IDVehiculo", r.IDVehiculo);
            table.Add("@Dias", r.Dias);
            table.Add(@"Importe", r.Importe);

            data.Escribir(store, table);
        }

        public List<ClsRenta> ObtenerRentas()
        {
            List<ClsRenta> rentas = new List<ClsRenta>();
            DataTable dt = new DataTable();

            string store = "s_ObtenerRentas";

            dt = data.Leer(store);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ClsRenta r = new ClsRenta();
                    r.IDCliente = Convert.ToInt32(row["IDCliente"].ToString());
                    r.IDVehiculo = Convert.ToInt32(row["IDVehiculo"].ToString());
                    r.Dias = Convert.ToInt32(row["Dias"].ToString());
                    r.Importe = Convert.ToInt32(row["Importe"].ToString());

                    rentas.Add(r);
                }
            }

            return rentas;
        }
    }
}
