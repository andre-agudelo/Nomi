using Entity;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
namespace DAL
{
    public class RegistroPagosRepository
    {
        List<RegistroLiquidacion> lista = new List<RegistroLiquidacion>();
        private readonly OracleConnection _connection;
        public RegistroPagosRepository(ConecctionManager connection)
        {
            _connection = connection._conexion;
        }

        public int Guardar(RegistroLiquidacion registroLiquidacion)
        {
            using (var Comando = _connection.CreateCommand())
            {
                Comando.CommandText = "INSERT INTO registropagos (codpago, cedula, fecha, hora, subtotal, descuento, bonificacion, total) VALUES" +
                    "(PAGOS.NEXTVAL, :cedula, :fecha, :hora, :subtotal, :decuento, :bonificacion, :total)";
                Comando.Parameters.Add("cedula", OracleDbType.Varchar2).Value = registroLiquidacion.Empleado.Cedula;
                Comando.Parameters.Add("fecha", OracleDbType.Varchar2).Value = registroLiquidacion.FechaPago;
                Comando.Parameters.Add("hora", OracleDbType.Varchar2).Value = registroLiquidacion.Hora;
                Comando.Parameters.Add("subtotal", OracleDbType.Double).Value = registroLiquidacion.Salario;
                Comando.Parameters.Add("descuento", OracleDbType.Double).Value = registroLiquidacion.Descuento;
                Comando.Parameters.Add("bonificacion", OracleDbType.Double).Value = registroLiquidacion.Bonificacion;
                Comando.Parameters.Add("total", OracleDbType.Double).Value = registroLiquidacion.TotalPago;

                var filas = Comando.ExecuteNonQuery();
                return filas;
            }
        }
        public List<RegistroLiquidacion> Consultar()
        {
            OracleDataReader dataReader;
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "Select * from registropagos";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        RegistroLiquidacion liqui = Mapear(dataReader);
                        lista.Add(liqui);
                    }
                }
            }
            return lista;
        }
        private RegistroLiquidacion Mapear(OracleDataReader dataReader)
        {
            Empleado empleado = new Empleado();
            empleado.Cedula = dataReader.GetString(1);
            if (!dataReader.HasRows) return null;
            RegistroLiquidacion registro = new RegistroLiquidacion
            {
                CodigoPago = dataReader.GetString(0),
                FechaPago = dataReader.GetString(2),
                Hora = dataReader.GetString(3),
                Empleado = empleado,
                Salario = (dataReader.GetDouble(4)),
                Descuento = (dataReader.GetDouble(5)),
                Bonificacion = (dataReader.GetDouble(7)),
                TotalPago =(dataReader.GetDouble(6)),

            };
            return registro;
        }

    }
}
