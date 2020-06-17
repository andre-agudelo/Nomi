using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;

namespace DAL
{
    public class PuestoTrabajoRepository
    {
        List<PuestoTrabajo> puestosTrabajos = new List<PuestoTrabajo>();
        
        private readonly OracleConnection _connetion;
        public PuestoTrabajoRepository(ConecctionManager connection)
        {
            _connetion = connection._conexion;
        }

        public List<PuestoTrabajo> ConsultarPuestosTrabajo()
        {
            OracleDataReader dataReader;
            using (var command = _connetion.CreateCommand())
            {
                command.CommandText = "Select * from puestotrabajo";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        PuestoTrabajo puestoTrabajo = MapearLiquidacion(dataReader);
                        puestosTrabajos.Add(puestoTrabajo);
                    }
                }
            }
            return puestosTrabajos;
        }

        private PuestoTrabajo MapearLiquidacion(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            PuestoTrabajo puesto = new PuestoTrabajo()
            {
                CodigoPuesto = dataReader.GetString(0),
                NombrePuesto = dataReader.GetString(1),
                SalarioBase = dataReader.GetDouble(2)
            };
            return puesto;
        }
    }
}
