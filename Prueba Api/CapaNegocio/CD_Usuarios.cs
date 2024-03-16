using CapaAccessoDatos;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaNegocio
{
    public class CD_Usuarios
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader? leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select * from dbo.USUARIO";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
           
            
            conexion.CerrarConexion();
            return tabla;

        }

       

      
        

    }
}
