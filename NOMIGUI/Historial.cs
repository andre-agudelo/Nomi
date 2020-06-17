using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOMIGUI
{
    public partial class Historial : Form
    {
        HistorialService historialService = new HistorialService(ConfigConnection.connectionString);
        List<Entity.Historial> historiales;
        public Historial()
        {
            InitializeComponent();
            CenterToScreen();
            historiales = new List<Entity.Historial>();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaHistorialRespuesta respuesta = new ConsultaHistorialRespuesta();
            respuesta = historialService.Consultar();
            if (respuesta.Error is false)
            {
                TablaLlegadas.DataSource = null;
                historiales = null;

                TablaLlegadas.DataSource = null;
                historiales = respuesta.Historiales;
                TablaLlegadas.DataSource = respuesta.Historiales;
                MessageBox.Show(respuesta.Mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
