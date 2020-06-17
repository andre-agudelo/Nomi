using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HorasService
    {
        private readonly ConecctionManager conexion;
        private readonly HorasRepository horasRepository;

        public HorasService (string connectionString)
        {
            conexion = new ConecctionManager(connectionString);
            horasRepository = new HorasRepository(conexion);
        }

        public ConsultaHorasRespuesta Consultar()
        {
            ConsultaHorasRespuesta respuesta = new ConsultaHorasRespuesta();

            conexion.Open();
            respuesta.Horas = horasRepository.Consultar();
            conexion.Close();
            if (respuesta.Horas.Count > 0)
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

    public class ConsultaHorasRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public List<Horas> Horas { get; set; }
    }

}
