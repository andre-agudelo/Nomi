using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HistorialService
    {
        private readonly ConecctionManager conexion;
        private readonly HistorialRepository historialRepository;

        public HistorialService(string connectionString)
        {
            conexion = new ConecctionManager(connectionString);
            historialRepository = new HistorialRepository(conexion);
        }

        public ConsultaHistorialRespuesta Consultar()
        {
            ConsultaHistorialRespuesta respuesta = new ConsultaHistorialRespuesta();

            conexion.Open();
            respuesta.Historiales = historialRepository.Consultar();
            conexion.Close();
            if (respuesta.Historiales.Count > 0)
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
    public class ConsultaHistorialRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public List<Historial> Historiales { get; set; }
    }
}
