using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

/*
 * Carrasco, Nathan
 * Herrera, Francisco
 * Wu, Iván
 */

namespace Parcial2DS4
{
    public partial class ReporteClientesPorProvincia : Form
    {
        public ReporteClientesPorProvincia()
        {
            InitializeComponent();
        }

        private void btnMontoProvincia_Click(object sender, EventArgs e)
        {
            ReporteMontoPorProvincia reporteMontoPorProvincia = new ReporteMontoPorProvincia();
            reporteMontoPorProvincia.Show();
        }

        private void btnListaClientes_Click(object sender, EventArgs e)
        {
            ReporteListaDeClientes reporteListaDeClientes = new ReporteListaDeClientes();
            reporteListaDeClientes.Show();

        }

        private void btnClientesProvincia_Click(object sender, EventArgs e)
        {
            ConexionDB conexionDB = new ConexionDB();
            DataTable datos = conexionDB.ObtenerCantidadClientesPorProvincia();
            dataGridViewClientesProvincia.DataSource = datos;
        }
    }
}
