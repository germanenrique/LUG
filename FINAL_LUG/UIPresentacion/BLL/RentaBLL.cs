using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using MAPPER;


namespace BLL
{
  public  class RentaBLL
    {
        RentaMPP rMpp = new RentaMPP();
        public void Insertar(ClsRenta r)
        {
            rMpp.Insertar(r);
        }

        public List<ClsRenta> ObtenerRentas()
        {
            return rMpp.ObtenerRentas();
        }
    }
}
