using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Empleado
    {
        public string Cedula {get; set;}
        public string PrimerNombre {get; set;}
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string IdPuesto { get; set; }
        public string FechaInicio{get; set;}
        public string TipoSangre { get; set; }
        public string Email { get; set; }  
        public string Sexo {get; set;}


}
}
