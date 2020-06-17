using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RegistroPagos
    {
        public string IdRegistro { get; set; }
        public string FechaRegistro { get; set; }
        public string idVentas { get; set; }
        public double numVentas { get; set; }
        public double TotalVentas { get; set; }
    }
}
