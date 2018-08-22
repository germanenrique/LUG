using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAPPER;
using System.Data;

namespace BLL
{
   public class ReporteBLL
    {
        ReporteMPP rMpp = new ReporteMPP();
        public DataSet ObtenerReporte(string store)
        {
            return rMpp.ObtenerReporte(store);
        }
    }
}
