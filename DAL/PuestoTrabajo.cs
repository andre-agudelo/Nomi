using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PuestoTrabajo
    {
        Empleado cedula { get; set; }
        public string CodigoPuesto { get; set; }
        public string NombrePuesto { get; set; }
        public double SalarioBase { get; set; }

       
    }
}
