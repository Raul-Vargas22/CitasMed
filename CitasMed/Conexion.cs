using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CitasMed
{
    internal class ConnectionData
    {
        private readonly string cadena = "Server=localhost;Database=CitasMed;Uid=root;Pwd=;Port=3306;SslMode=None;";

        public MySqlConnection GetConnection()
        {
            MySqlConnection conexion = new MySqlConnection(cadena);

            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conexion.Dispose();
                return null;
            }
        }
    }
}