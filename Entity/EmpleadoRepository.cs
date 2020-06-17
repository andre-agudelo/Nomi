using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class EmpleadoRepository
    {
        List<Empleado> empleados = new List<Empleado>();


        private readonly OracleConnection _connetion;
        public EmpleadoRepository(ConecctionManager connection)
        {
            _connetion = connection._conexion;
        }
        public int Guardar (Empleado empleado)
        {
            using (var command = _connetion.CreateCommand())
            {
                command.CommandText = @"Insert into Empleado (cedula, primernombre, segundonombre, primerapellido, segundoapellido, idpuesto, FechaInicio, tiposangre, email, Sexo)
                                        values (:cedula, :primernombre, :segundonombre,:primerapellido, :segundoapellido, :idpuesto, :FechaInicio, :tiposangre, :email, :Sexo)";
                command.Parameters.Add("cedula", OracleDbType.Varchar2).Value = empleado.Cedula;
                command.Parameters.Add("primernombre", OracleDbType.Varchar2).Value = empleado.PrimerNombre;
                command.Parameters.Add("segundonombre", OracleDbType.Varchar2).Value = empleado.SegundoNombre;
                command.Parameters.Add("primerapellido", OracleDbType.Varchar2).Value = empleado.PrimerApellido;
                command.Parameters.Add("segundoapellido", OracleDbType.Varchar2).Value = empleado.SegundoApellido;
                command.Parameters.Add("idpuesto", OracleDbType.Varchar2).Value = empleado.IdPuesto;
                command.Parameters.Add("FechaInicio", OracleDbType.Varchar2).Value = empleado.FechaInicio;
                command.Parameters.Add("tiposangre", OracleDbType.Varchar2).Value = empleado.TipoSangre;
                command.Parameters.Add("email", OracleDbType.Varchar2).Value = empleado.Email;
                command.Parameters.Add("Sexo", OracleDbType.Varchar2).Value = empleado.Sexo;
                var filas = command.ExecuteNonQuery();
                return filas;

            }
        }
        public int GuardarLlegada(Empleado empleado)
        {
            using (var command = _connetion.CreateCommand())
            {
                command.CommandText = @"Insert Into registrollegada (codllegada, cedula, hora, fecha) 
                                      values (llegadas.Nextval,:cedula,:hora,:fecha)";
                command.Parameters.Add("cedula", OracleDbType.Varchar2).Value = empleado.Cedula;
                command.Parameters.Add("hora", OracleDbType.Varchar2).Value = DateTime.Now.ToString("HH:mm");
                command.Parameters.Add("fecha", OracleDbType.Varchar2).Value = DateTime.Today.ToString("dd/MM/yyyy");

                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }


        public List<Empleado> Consultar()
        {
            OracleDataReader dataReader;
            using (var command = _connetion.CreateCommand())
            {
                command.CommandText = "Select * from Empleado";
                dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        Empleado empleado = Mapear(dataReader);
                        empleados.Add(empleado);
                    }
                }
            }
            return empleados;
        }

        private Empleado Mapear(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Empleado empleado = new Empleado()
            {
                Cedula = dataReader.GetString(0),
                PrimerNombre = dataReader.GetString(1),
                SegundoNombre = dataReader.GetString(2),
                PrimerApellido = dataReader.GetString(3),
                SegundoApellido = dataReader.GetString(4),
                IdPuesto = dataReader.GetString(5),
                FechaInicio = dataReader.GetString(7),
                TipoSangre = dataReader.GetString(6),
                Email = dataReader.GetString(8),
                Sexo = dataReader.GetString(9)
            };
            return empleado;
        }

        public Empleado ConsultarIdentificacion(string identificacion)
        {
            OracleDataReader dataReader;
            using (var Comando = _connetion.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM empleado WHERE cedula = :cedula";
                Comando.Parameters.Add("cedula", OracleDbType.Varchar2).Value = identificacion;
                dataReader = Comando.ExecuteReader();
                dataReader.Read();
                Empleado empleado = Mapear(dataReader);
                return empleado;
            }
        }

        public int Eliminar(Empleado empleado)
        {
            using (var command = _connetion.CreateCommand())
            {
                command.CommandText = "Delete from empleado where cedula=:cedula";
                command.Parameters.Add("cedula", OracleDbType.Varchar2).Value = empleado.Cedula;
                var filas = command.ExecuteNonQuery();
                return filas;
            }
        }

        public int Editar(Empleado empleado)
        {
            using (var Comando = _connetion.CreateCommand())
            {
                Comando.CommandText = "UPDATE empleado SET cedula =:Cedula, primernombre =:PrimerNombre, segundonombre =:segundonombre, primerapellido =:primerapellido, segundoapellido=:segundoapellido, idpuesto=:idpuesto, FechaInicio=:FechaInicio, tiposangre=:tiposangre, email=:email, Sexo =:Sexo WHERE Cedula = :Cedula";
                Comando.Parameters.Add("Cedula", OracleDbType.Varchar2).Value = empleado.Cedula;
                Comando.Parameters.Add("primernombre", OracleDbType.Varchar2).Value = empleado.PrimerNombre;
                Comando.Parameters.Add("segundonombre", OracleDbType.Varchar2).Value = empleado.SegundoNombre;
                Comando.Parameters.Add("primerapellido", OracleDbType.Varchar2).Value = empleado.PrimerApellido;
                Comando.Parameters.Add("segundoapellido", OracleDbType.Varchar2).Value = empleado.SegundoApellido;
                Comando.Parameters.Add("idpuesto", OracleDbType.Varchar2).Value = empleado.IdPuesto;
                Comando.Parameters.Add("FechaInicio ", OracleDbType.Varchar2).Value = empleado.FechaInicio;
                Comando.Parameters.Add("tiposangre ", OracleDbType.Varchar2).Value = empleado.TipoSangre;
                Comando.Parameters.Add("email ", OracleDbType.Varchar2).Value = empleado.Email;
                Comando.Parameters.Add("Sexo ", OracleDbType.Varchar2).Value = empleado.Sexo;
                var filas = Comando.ExecuteNonQuery();
                
                return filas;
            }
        }

        public List<Empleado> FiltroIdentificacion(string identificacion)
        {
            return empleados.Where(e => e.Cedula.Contains(identificacion)).ToList();
        }


    }
}
