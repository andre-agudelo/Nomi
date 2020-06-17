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
    public partial class HistorialLlegadas : Form
    {
        HorasService horasService = new HorasService(ConfigConnection.connectionString);
        List<Entity.Horas> horasllegadas;
        ConsultaHorasRespuesta respuesta = new ConsultaHorasRespuesta();
        public HistorialLlegadas()
        {
            InitializeComponent();
            CenterToScreen();
            horasllegadas = new List<Entity.Horas>();
            Consultar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablaLlegadas.DataSource = null;
           
            if (respuesta.Error is false)
            {
                TablaLlegadas.DataSource = null;
                TablaLlegadas.Columns.Clear();
                TablaLlegadas.Rows.Clear();
                TablaLlegadas.Refresh();

                TablaLlegadas.DataSource = null;
            
                TablaLlegadas.DataSource = respuesta.Horas;
                MessageBox.Show(respuesta.Mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else
            {
                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Consultar()
        {
            respuesta = horasService.Consultar();
            horasllegadas = respuesta.Horas;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void TablaLlegadas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
