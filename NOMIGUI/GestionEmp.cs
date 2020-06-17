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
    public partial class Form1 : Form
    {
        EmpleadoService empleadoService = new EmpleadoService(ConfigConnection.connectionString);
        List<Empleado> empleados;
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
            empleados = new List<Empleado>();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Empleado> lista;
            RespuestaConsultarIdentificacion resp = new RespuestaConsultarIdentificacion();
            string id = textName.Text.Trim();
            resp = empleadoService.ConsultarIdentificacion(id);

            if (textName.Text.Equals(""))
            {
                ConsultaPersonaRespuesta respuesta = new ConsultaPersonaRespuesta();
                respuesta = empleadoService.Consultar();
                if (respuesta.Error is false)
                {
                    TblEmpleados.DataSource = null;
                    empleados = null;

                    TblEmpleados.DataSource = null;
                    empleados = respuesta.Empleados.ToList();
                    TblEmpleados.DataSource = respuesta.Empleados;
                    MessageBox.Show(respuesta.Mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (resp.Error is false)
                {
                    MessageBox.Show(resp.Mensaje, "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    string identificacion = textID.Text.Trim();
                    resp = empleadoService.ConsultarIdentificacion(identificacion);
                    lista = new List<Empleado>();
                    lista.Add(resp.empleado);
                    TblEmpleados.DataSource = lista;
                }
                else
                {
                    MessageBox.Show(resp.Mensaje, "Prueba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
       


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void button5_Click(object sender, EventArgs e)
        {
            AgregarEmpleado emp = new AgregarEmpleado();
            emp.Show();
        }

        private void PDF_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Informe";
            saveFileDialog.InitialDirectory = @"c:/document";
            saveFileDialog.DefaultExt = "pdf";
            string filename = "";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
                if (filename != "" && empleados.Count > 0)
                {

                    string mensaje = empleadoService.GenerarPdf(empleados, filename);

                    MessageBox.Show(mensaje, "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("No se especifico una ruta o No hay datos para generar el reporte", "Generar Pdf", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                }
            }
        }

        private void textID_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string identificacion = textID.Text.Trim();
            empleados = empleadoService.FiltroPorIdentificacion(textName.Text.Trim());
            TblEmpleados.DataSource = empleados;
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TblEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Empleado empleado = (Empleado)TblEmpleados.CurrentRow.DataBoundItem;
            new ModificarEmpleado(empleado).Show();
        }

        private void Ajusteempleado_Click(object sender, EventArgs e)
        {

            ConsultaPersonaRespuesta respuesta = new ConsultaPersonaRespuesta();
            respuesta = empleadoService.Consultar();

            if (respuesta.Error is false)
            {
                TblEmpleados.DataSource = null;
                empleados = respuesta.Empleados.ToList();
                TblEmpleados.DataSource = respuesta.Empleados;
                MessageBox.Show(respuesta.Mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {


                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textName_KeyPress(object sender, KeyPressEventArgs e)
        {
            RespuestaFiltroIdentificacion respuesta = new RespuestaFiltroIdentificacion();
            respuesta = empleadoService.FiltroIdentificacion(textName.Text);

            if (respuesta.ErrorFiltro == false)
            {
                TblEmpleados.DataSource = respuesta.Empleados;
            }
            else
            {
                MessageBox.Show(respuesta.Mensajefiltro, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string identificacion = textName.Text.Trim();
            if (identificacion != "")
            {
                var respuesta = MessageBox.Show("Está seguro de eliminar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    string mensaje = empleadoService.Eliminar(identificacion);
                    MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor digite la cedula de la persona a modificar y presione el boton buscar", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
