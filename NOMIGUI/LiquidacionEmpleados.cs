using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace NOMIGUI
{
    public partial class LiquidacionEmpleados : Form
    {
        PuestoTrabajoService puestoService = new PuestoTrabajoService(ConfigConnection.connectionString);
        RespuestaConsultarIdentificacion resp = new RespuestaConsultarIdentificacion();
        EmpleadoService empleadoService = new EmpleadoService(ConfigConnection.connectionString);
        RegistroLiquidacion registroLiquidacion = new RegistroLiquidacion();
        RegistroPagosService registroPagoService = new RegistroPagosService(ConfigConnection.connectionString);

        Empleado empleado;

        List<PuestoTrabajo> lista;

        public LiquidacionEmpleados()
        {
            InitializeComponent();
            CenterToScreen();
            lista = new List<PuestoTrabajo>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textID.Text.Trim();

            if (textID.Text.Equals(""))
            {
                MessageBox.Show("Digite identificación");
            }
            else
            {
                if (resp.Error is false)
                {
                    MessageBox.Show(resp.Mensaje, "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string identificacion = textID.Text.Trim();
                    MapearParcial();
                }
                else
                {
                    MessageBox.Show(resp.Mensaje, "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                textID.Text = "";
            }
        }

        private void LiquidacionEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int indice;
        private void MapearParcial()
        {
            indice = TblEmpleados.Rows.Add();

            RespuestaConsultarIdentificacion resp = new RespuestaConsultarIdentificacion();

            resp = empleadoService.ConsultarIdentificacion(textID.Text.Trim());

            empleado = resp.empleado;
            
            TblEmpleados.Rows[indice].Cells[0].Value = resp.empleado.Cedula;
            TblEmpleados.Rows[indice].Cells[1].Value = resp.empleado.PrimerNombre;
            TblEmpleados.Rows[indice].Cells[2].Value = resp.empleado.PrimerApellido;

        }


        

        private void button2_Click(object sender, EventArgs e)
        {
            LiquidarEmpleado();
        }

        private void LiquidarEmpleado()
        {
            RegistroLiquidacion registroLiquidacion = new RegistroLiquidacion()
            {
                Empleado = empleado,
                Bonificacion = Convert.ToDouble(textBonificacion.Text.Trim()),
                Descuento = Convert.ToDouble(textDescuento.Text.Trim()),
                Hora = DateTime.Now.ToString("HH:mm"),
                FechaPago = DateTime.Now.ToString("dd/MM/yyyy")
            };

            RespuestaConsultaPuesto respuesta = puestoService.ConsultarPuestosTrabajo();

            MessageBox.Show(respuesta.MensajePuesto, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            registroLiquidacion.LiquidarEmpleado(respuesta.puestos);


            string mensaje = registroPagoService.Guardar(registroLiquidacion);

            MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            HistorialPagos histo = new HistorialPagos();
            histo.Show();
        }
    }
}
