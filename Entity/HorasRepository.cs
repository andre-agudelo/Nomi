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
    public class HorasRepository
    {
        List<Horas> horas = new List<Horas>();

        private readonly OracleConnection _connetion;
        public HorasRepository(ConecctionManager connection)
        {
            _connetion = connection._conexion;
        }

        public List<Horas> Consultar()
        {
            OracleDataReader dataReader;
            using (var command = _connetion.CreateCommand())
            {
                command.CommandText = "SELECT codllegada, cedula, hora, fecha FROM registrollegada ORDER BY fecha desc";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Horas hora = Mapear(dataReader);
                        horas.Add(hora);
                    }
                }
            }
            return horas;
        }
        private Horas Mapear(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Horas horas = new Horas()
            {
                CodigoRegistro = dataReader.GetString(0),
                CedulaEmpleado = dataReader.GetString(1),
                HoraLlegada = dataReader.GetString(2),
                Fecha = dataReader.GetString(3),
                
            };
            return horas;
        }

    }
}
