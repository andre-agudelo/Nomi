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
    public class EmpleadoService
    {
        private readonly ConecctionManager conexion;
        private readonly EmpleadoRepository empleadoRepository;
        Email email = new Email(); 

        public EmpleadoService(string connectionString)
        {
            conexion = new ConecctionManager(connectionString);
            empleadoRepository = new EmpleadoRepository(conexion);
        }

        string mensajeEmail = string.Empty;

        public string Guardar (Empleado empleado)
        {
            try
            {

                conexion.Open();
                mensajeEmail = email.EnviarEmail(empleado);
                empleadoRepository.Guardar(empleado);
                return $"Guardado";
            }
            catch(Exception e)
            {
                return $"Error de la aplicacion: {e.Message}";
            }
            finally 
            { 
                conexion.Close(); 
            }
        }
        public RespuestaConsultarIdentificacion GuardarLlegada(Empleado empleado)
        {
            RespuestaConsultarIdentificacion respuesta = new RespuestaConsultarIdentificacion();
            try
            {
                conexion.Open();

                if (empleadoRepository.ConsultarIdentificacion(empleado.Cedula) != null)
                {
                    empleadoRepository.GuardarLlegada(empleado);
                    string mensaje = $"Se guardó la llegada  de {empleado.PrimerNombre} satisfactoriamente";
                    respuesta.Mensaje = mensaje;
                    return respuesta;
                }
                else if(empleadoRepository.ConsultarIdentificacion(empleado.Cedula) is null)
                {
                    string mensaje = $"No existe trabajador";
                    respuesta.Mensaje = mensaje;
                    return respuesta;
                }

                return respuesta;
            }
            catch (Exception e)
            {

                string mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Mensaje = mensaje;
                return respuesta;
            }
            finally { conexion.Close(); }
        }

        
        public List<Empleado> FiltroPorIdentificacion(string identificacion)
        {
            return empleadoRepository.FiltroIdentificacion(identificacion);
        }

        public string GenerarPdf(List<Empleado> empleado, string filename)
        {

            DocumentoPdf documentoPdf = new DocumentoPdf();

            try
            {
                documentoPdf.GuardarPdf(empleado, filename);
                mensajeEmail = email.EnviarEmailDocumento();
                return "Se generó el Documento satisfactoriamente " + mensajeEmail;
            }
            catch (Exception e)
            {
                return "Error al crear docuemnto" + e.Message;
            }

        }
        public string Editar(Empleado empleado)
        {
            try
            {

                conexion.Open();
                mensajeEmail = email.EnviarEmail(empleado);
                empleadoRepository.Editar(empleado);
                return $"Editado";
            }
            catch (Exception e)
            {
                return $"Error de la aplicacion: {e.Message}";
            }
            finally
            {
                conexion.Close();
            }
        }

        public ConsultaPersonaRespuesta Consultar()
        {
            ConsultaPersonaRespuesta respuesta = new ConsultaPersonaRespuesta();
           
                conexion.Open();
                respuesta.Empleados = empleadoRepository.Consultar();
                conexion.Close();
                if (respuesta.Empleados.Count > 0)
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

        public RespuestaConsultarIdentificacion ConsultarIdentificacion(string identificacion)
        {
            RespuestaConsultarIdentificacion respuesta = new RespuestaConsultarIdentificacion();
            try
            {
                conexion.Open();
                respuesta.empleado = empleadoRepository.ConsultarIdentificacion(identificacion);
                conexion.Close();
                respuesta.Error = false;

                if (respuesta.empleado == null)
                {
                    respuesta.Mensaje = "El empleado no existe";
                }
                else
                {
                    respuesta.Mensaje = "Consultado";
                }
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = "Error de aplicación " + e.Message;
                return respuesta;
            }
            finally
            {
                conexion.Close();
            }

        }
        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                var empleado = empleadoRepository.ConsultarIdentificacion(identificacion);
                if (empleado != null)
                {
                    empleadoRepository.Eliminar(empleado);
                    conexion.Close();
                    return ($"El registro se ha eliminado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, no se encuentra el registro.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
      


        public RespuestaFiltroIdentificacion FiltroIdentificacion(string identificacion)
        {
            RespuestaFiltroIdentificacion respuesta = new RespuestaFiltroIdentificacion();

            try
            {
                respuesta.Empleados = empleadoRepository.FiltroIdentificacion(identificacion);
                respuesta.ErrorFiltro = false;
                respuesta.Mensajefiltro = "Consultando";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensajefiltro = "Error " + e.Message;
                respuesta.ErrorFiltro = true;
                return respuesta;
            }
        } 
    }
    

    public class RespuestaConsultarIdentificacion
    {
        public bool Error;
        public string Mensaje;
        public Empleado empleado;
    }
    public class RespuestaEliminarEmpleado
    {
        public bool Error;
        public string Mensaje;
        public Empleado empleado;
    }
    public class ConsultaPersonaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public List<Empleado> Empleados { get; set; }
    }

    public class RespuestaFiltroIdentificacion
    {
        public bool ErrorFiltro; 
        public string Mensajefiltro;
        public List<Empleado> Empleados;
    }
}
