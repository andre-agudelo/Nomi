using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using DAL;
using Entity;
using Infraestructura;

namespace BLL
{
    public class PuestoTrabajoService
    {
        private readonly ConecctionManager conexion;
        private readonly PuestoTrabajoRepository puestoRepository;

        public PuestoTrabajoService(string connectionString)
        {
            conexion = new ConecctionManager(connectionString);
            puestoRepository = new PuestoTrabajoRepository(conexion);
        }

        public RespuestaConsultaPuesto ConsultarPuestosTrabajo()
        {
            RespuestaConsultaPuesto respuesta = new RespuestaConsultaPuesto();

            try
            {
                conexion.Open();
                respuesta.puestos = puestoRepository.ConsultarPuestosTrabajo();
                conexion.Close();
                if (respuesta.puestos.Count > 0)
                {
                    respuesta.MensajePuesto = "Datos Consultados";
                }
                else
                {
                    respuesta.MensajePuesto = "No hay datos para consultar";
                }
                respuesta.ErrorPuesto = false;
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.ErrorPuesto = true;
                respuesta.MensajePuesto = "Error" + e.Message;
                return respuesta;
            }
            finally
            {
                conexion.Close();
            }

        }




    }
    public class RespuestaConsultaPuesto
    {
        public bool ErrorPuesto;
        public string MensajePuesto;
        public List<Entity.PuestoTrabajo> puestos;
    }

}
