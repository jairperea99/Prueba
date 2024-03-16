using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaAccessoDatos
{
    public class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("Server=DESKTOP-84MSQ10\\MSSQLSERVER01;DataBase=pruebaSD;Integrated Security=true;TrustServerCertificate=true");
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
