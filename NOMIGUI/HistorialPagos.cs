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
using DAL;
using Entity;

namespace NOMIGUI
{
    public partial class HistorialPagos : Form
    {
        RegistroPagosService registroService = new RegistroPagosService(ConfigConnection.connectionString);
        List<RegistroLiquidacion> lista;
        ResultadoConsultaLiquidacion respuesta = new ResultadoConsultaLiquidacion();
        public HistorialPagos()
        {
            InitializeComponent();
            CenterToScreen();
            lista = new List<RegistroLiquidacion>();
            Consultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TablaPagos.DataSource = null;

            if (respuesta.Error is false)
            {
                TablaPagos.DataSource = null;
                TablaPagos.Columns.Clear();
                TablaPagos.Rows.Clear();
                TablaPagos.Refresh();

                TablaPagos.DataSource = null;

                TablaPagos.DataSource = respuesta.Liquidacion;
                MessageBox.Show(respuesta.Mensaje, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show(respuesta.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Consultar()
        {
            respuesta = registroService.Consultar();
            lista = respuesta.Liquidacion;
        }

        private void TablaPagos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
