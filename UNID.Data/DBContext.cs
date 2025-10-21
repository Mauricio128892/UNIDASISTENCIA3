using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace UNID.Data
{
    public class DBContext
    {
        // La conexión ya está configurada con tu contraseña
        private readonly string connectionString =
            "Server=localhost;Port=3306;Database=UNID_ASISTENCIA;Uid=root;Pwd=161448;";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}