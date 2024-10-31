using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    internal class ConexionDB
    {
        private string detallesConexion = "Data Source=localhost;Initial Catalog=GestionClientesDB;Integrated Security=True";

        // Método para obtener la cantidad de clientes por provincia
        // Problema 1

        public DataTable ObtenerCantidadClientesPorProvincia()
        {
            DataTable datos = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(detallesConexion))
                {
                    SqlCommand command = new SqlCommand("ContarClientesPorProvincia", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(datos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener cantidad de clientes por provincia: " + ex.Message);
            }
            return datos;
        }

        // Método para obtener el total de compras por provincia
        // Problema 2
        public DataTable ObtenerTotalComprasPorProvincia()
        {
            DataTable datos = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(detallesConexion))
                {
                    SqlCommand command = new SqlCommand("TotalComprasPorProvincia", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(datos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener total de compras por provincia: " + ex.Message);
            }
            return datos;
        }


        // Método para obtener todas las provincias y sus clientes
        // Problema 3
        public DataTable ObtenerClientesPorTodasProvincias()
        {
            DataTable datos = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(detallesConexion))
                {
                    SqlCommand command = new SqlCommand("ListadoClientesConVentas", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Provincia", DBNull.Value);  // Sin filtro, muestra todas las provincias

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(datos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener clientes de todas las provincias: " + ex.Message);
            }
            return datos;
        }

        // Método para obtener clientes de una provincia específica
        // Problema 3
        public DataTable ObtenerClientesPorProvincia(string provincia)
        {
            DataTable datos = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(detallesConexion))
                {
                    SqlCommand command = new SqlCommand("ListadoClientesConVentas", connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Provincia", provincia);  // Filtro por provincia específica

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(datos);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener clientes por provincia: " + ex.Message);
            }
            return datos;
        }

        // Método para mostrar todos los clientes por provincia en un DataGridView
        public void MostrarClientesPorProvinciaEnDataGridView(DataGridView dgv, string provincia = null)
        {
            DataTable datos;
            if (string.IsNullOrEmpty(provincia))
            {
                datos = ObtenerClientesPorTodasProvincias();  // Sin filtro, muestra todas las provincias
            }
            else
            {
                datos = ObtenerClientesPorProvincia(provincia);  // Filtra por la provincia seleccionada
            }
            dgv.DataSource = datos;
        }
                    
    }
}
