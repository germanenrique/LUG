using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using MAPPER;

namespace BLL
{
   public class VehiculoBLL
    {
        VehiculoMPP vMpp = new VehiculoMPP();
        public void Insertar(ClsVehiculos v)
        {
            vMpp.InsertarActualizar(v);
        }

        public void Actualizar(ClsVehiculos v)
        {
            vMpp.InsertarActualizar(v);
        }

        public void Eliminar(ClsVehiculos v)
        {
            vMpp.Eliminar(v);
        }

        public List<ClsVehiculos> ObtenerVehiculos()
        {
            return vMpp.ObtenerVehiculos();
        }
    }
}
