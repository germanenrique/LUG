using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTIDADES;
using MAPPER;

namespace BLL
{
    public class ClienteBLL
    {
        ClienteMPP cMpp = new ClienteMPP();
        public void Insertar(ClsCliente c)
        {
            cMpp.InsertarActualizar(c);
        }

        public void Actualizar(ClsCliente c)
        {
            cMpp.InsertarActualizar(c);
        }

        public List<ClsCliente> ObtenerClientes()
        {
            return cMpp.ObtenerClientes();
        }

        public void Eliminar(ClsCliente c)
        {
            cMpp.Eliminar(c);
        }
    }
}
