using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
  public  class ClsVehiculos
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Patente { get; set; }
        public string Tipo { get; set; }

        public ClsVehiculos() { }

        public override string ToString()
        {
            return Tipo + " - " + Marca + " - " + Modelo;
        }
    }
}
