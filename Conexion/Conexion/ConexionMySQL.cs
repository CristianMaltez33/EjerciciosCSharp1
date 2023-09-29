using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexion 
{
    class ConexionMySQL : Conexion
    {
        private MySqlConnection connection;
        private string cadena;

        public ConexionMySQL()
        {
            this.cadena = string.Format("Database = {0}; DataSource = {1}; User Id = {2}; Password = {3}; ", database, server, user, password);

            this.connection = new MySqlConnection(cadena);
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if(connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                    MessageBox.Show("Conectado", "Conectado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } catch(Exception e)
            {
                MessageBox.Show(e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return connection;
        }
    }
}
