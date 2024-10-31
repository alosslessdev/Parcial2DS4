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
    public partial class ReporteListaDeClientes : Form
    {
        private ConexionDB conexionDB;
        public ReporteListaDeClientes()
        {
            InitializeComponent();
        }

        private void comboboxFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexionDB = new ConexionDB();
            DataTable datos;


            // Índice 0 muestra todos los datos
            if (comboBoxFiltrar.SelectedIndex == 0)
            {
                datos = conexionDB.ObtenerClientesPorTodasProvincias();
                dataGridViewListaClientes.DataSource = datos; // Obtener datos de todas las provincias
            }
            else
            {
                // Obtiene los datos de la provincia específica usando el índice del ComboBox (1 a 5)
                datos = conexionDB.ObtenerClientesPorProvincia(comboBoxFiltrar.Text);
                dataGridViewListaClientes.DataSource = datos;
            }

            dataGridViewListaClientes.DataSource = datos;            

        }

    }
}

