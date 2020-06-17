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
    public partial class Principal : Form
    {
        EmpleadoService empleadoService;
        Empleado empleado;

        public Principal()
        {
            InitializeComponent();
            CenterToScreen();
            empleadoService = new EmpleadoService(ConfigConnection.connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 gestion = new Form1();
            gestion.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Horas horas = new Horas();
            horas.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LiquidacionEmpleados liquidacionG = new LiquidacionEmpleados();
            liquidacionG.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Historial historial = new Historial();
            historial.Show();
        }
    }
}
