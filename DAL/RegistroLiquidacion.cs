using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class RegistroLiquidacion
    {
        public string CodigoPago { get; set; }
        public Empleado Empleado { get; set; }
        public string FechaPago { get; set; }
        public string Hora { get; set; }    
        public double Salario { get; set; }
        public double Descuento { get; set; }
        public double Bonificacion { get; set; }
        public double TotalPago { get; set; }

        public void LiquidarEmpleado(List<PuestoTrabajo> puestosTrabajos)
        {
            ObtenerSalario(puestosTrabajos);
            TotalPago = Salario + Bonificacion - Descuento;
        }
        public void ObtenerSalario(List<PuestoTrabajo> puestosTrabajos)
        {
            Salario = puestosTrabajos.Find(p => p.CodigoPuesto.Equals(Empleado.IdPuesto)).SalarioBase;
        }
    }
}
