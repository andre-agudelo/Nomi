using Entity;
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



namespace NOMIGUI
{
    public partial class ModificarEmpleado : Form
    {
        Empleado Empleado;
        EmpleadoService empleadoService = new EmpleadoService(ConfigConnection.connectionString);
        public ModificarEmpleado(Empleado empleado)
        {
            Empleado = empleado;
            InitializeComponent();
            Setear();
        }

        private void ModificarEmpleado_Load(object sender, EventArgs e)
        {

        }

        public void Setear()
        {
            textCedula.Text = Empleado.Cedula;
            textPrimernombre.Text = Empleado.PrimerNombre;
            textSegundonombre.Text = Empleado.SegundoApellido;
            textPrimerapellido.Text = Empleado.PrimerApellido;
            textSegundoapellido.Text = Empleado.SegundoApellido;
            comboPuestos.Text = Empleado.IdPuesto;
            comboSangre.Items.Add(Empleado.TipoSangre);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado()
            {
                Cedula = textCedula.Text.Trim(),
                PrimerNombre = textPrimernombre.Text.Trim(),
                SegundoNombre = textSegundonombre.Text.Trim(),
                PrimerApellido = textPrimerapellido.Text.Trim(),
                SegundoApellido = textSegundoapellido.Text.Trim(),
                IdPuesto = comboPuestos.SelectedIndex.ToString(),
                Sexo = comboGenero.Text,
                TipoSangre = comboSangre.Text,
                FechaInicio = Empleado.FechaInicio,
                Email = Empleado.Email
               
               
            };
            string mensaje = empleadoService.Editar(empleado);
            Limpiar();
            MessageBox.Show(mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Limpiar()
        {
            textCedula.Text = "";
            textPrimernombre.Text = "";
            textSegundonombre.Text = "";
            textPrimerapellido.Text = "";
            textSegundoapellido.Text = "";
        }
        private void comboPuestos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
