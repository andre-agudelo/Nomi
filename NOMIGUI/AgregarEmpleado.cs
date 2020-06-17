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
    public partial class AgregarEmpleado : Form
    {
        EmpleadoService empleadoService;
        Empleado empleado = new Empleado();
        public AgregarEmpleado()
        {
            empleadoService = new EmpleadoService(ConfigConnection.connectionString);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
             Empleado empleado = TomarDatos();
             string mensaje = empleadoService.Guardar(empleado);
             MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
    
        }
        public Empleado TomarDatos()
        {
            string auxCedula = textCedula.Text.Trim();
            Empleado empleado = new Empleado();
            PuestoTrabajo puesto = new PuestoTrabajo();

            empleado.Cedula = textCedula.Text.Trim();
            empleado.PrimerNombre = textPrimerNombre.Text.Trim();
            empleado.SegundoNombre = textSegundoNombre.Text.Trim();
            empleado.PrimerApellido = textPrimerApellido.Text.Trim();
            empleado.SegundoApellido = textSegundoApellido.Text.Trim();
            empleado.IdPuesto = comboPuestos.SelectedIndex.ToString();
            empleado.FechaInicio = textFecha.Value.ToString("dd/MM/yyyy");
            empleado.TipoSangre = comboSangre.Text.Trim();
            empleado.Email = textEmail.Text.Trim();
            empleado.Sexo = comboSexo.Text.Trim();
         
            return empleado;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            
        }

        private void comboPuestos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
