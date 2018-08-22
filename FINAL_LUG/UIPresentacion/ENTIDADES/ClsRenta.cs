using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTIDADES
{
  public  class ClsRenta
    {
        public int IDVehiculo { get; set; }
        public int IDCliente { get; set; }
        public int Dias { get; set; }
        public int Importe { get; set; }

        public ClsRenta() { }
    }
}
