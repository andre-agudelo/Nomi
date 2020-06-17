using DAL;
using Entity;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class RegistroPagosService
    {
        private readonly ConecctionManager conexion;
        private readonly RegistroPagosRepository registroPagosRepository;

        public RegistroPagosService(string connectionString)
        {
            conexion = new ConecctionManager(connectionString);
            registroPagosRepository = new RegistroPagosRepository(conexion);
        }

        public string Guardar(RegistroLiquidacion registroLiquidacion)
        {

            try
            {
                conexion.Open();

                registroPagosRepository.Guardar(registroLiquidacion);

                conexion.Close();

                return $"se guardaron los datos correctamente ";
            }
            catch (System.Exception eg)
            {

                return "Error de Datos " + eg.Message;
            }
            finally
            {
                conexion.Close();
            }
        }
        public ResultadoConsultaLiquidacion Consultar()
        {
            ResultadoConsultaLiquidacion respuesta = new ResultadoConsultaLiquidacion();

            conexion.Open();
            respuesta.Liquidacion = registroPagosRepository.Consultar();
            conexion.Close();
            if (respuesta.Liquidacion.Count > 0)
            {
                respuesta.Mensaje = "Datos Consultados";
            }
            else
            {
                respuesta.Mensaje = "No hay datos para consultar";
            }
            respuesta.Error = false;
            return respuesta;

        }
    }
    public class ResultadoConsultaLiquidacion
    {
        public bool Error;
        public string Mensaje;
        public List<RegistroLiquidacion> Liquidacion;
    }
}
