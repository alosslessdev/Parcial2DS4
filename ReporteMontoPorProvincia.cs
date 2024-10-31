using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Carrasco, Nathan
 * Herrera, Francisco
 * Wu, Iván
 */

namespace Parcial2DS4
{
    public partial class ReporteMontoPorProvincia : Form
    {
        public ReporteMontoPorProvincia()
        {
            InitializeComponent();
        }

        private void btnMostrarMontoPorProvincia_Click(object sender, EventArgs e)
        {
            ConexionDB conexionDB = new ConexionDB();
            DataTable datos = conexionDB.ObtenerTotalComprasPorProvincia();
            dataGridViewMontoProvincia.DataSource = datos;
        }
    }
}