using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using ENTIDADES;
using System.Data;
using System.Collections;

namespace MAPPER
{
   public class ReporteMPP
    {
        Datos data = new Datos();
        public DataSet ObtenerReporte(string store)
        {
            DataSet ds = new DataSet();

            ds = data.LeerDS(store);

            return ds;
        }
    }
}
