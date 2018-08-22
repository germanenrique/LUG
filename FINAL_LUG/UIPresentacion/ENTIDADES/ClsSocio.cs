using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATOS;
using System.Data;

namespace ENTIDADES
{
   public class ClsSocio
    {
        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public int DNI { get; set; }

        public int Importe { get; set; }

        public DataSet Listar()
        {
            DATOS.Datos ODatos = new DATOS.Datos();
            dynamic query = "select * From Socios";
            return ODatos.LeerDesconectado(query);
        }
    }
}
