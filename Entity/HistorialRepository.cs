using DAL;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class HistorialRepository
    {

        List<Historial> historiales = new List<Historial>();

        private readonly OracleConnection _connetion;
        public HistorialRepository(ConecctionManager connection)
        {
            _connetion = connection._conexion;
            

        }

        public List<Historial> Consultar()
        {
            OracleDataReader dataReader;
            using (var command = _connetion.CreateCommand())
            {
                command.CommandText = "SELECT usuario, fecha, accion FROM control ORDER BY fecha desc";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Historial historial = Mapear(dataReader);
                        historiales.Add(historial);
                        }
                    }
                }
                return historiales;
            }
        private Historial Mapear(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Historial horas = new Historial()
            {
                Usuario = dataReader.GetString(0),
                Fecha = dataReader.GetString(1),
                Descripcion = dataReader.GetString(2),

             };
                return horas;
        }
    }
}
