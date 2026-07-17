using MySql.Data.MySqlClient;

namespace CitasMed
{
    internal class ConexionBD
    {
        public static MySqlConnection ObtenerConexion()
        {
            string cadena = "server=localhost; database=citasmed; uid=root; pwd=; port=3306;";
            return new MySqlConnection(cadena);
        }
    }
}