using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace colores
{
    class eliminar_cliente
    {
       
        public eliminar_cliente()
        {

    
        }
        public SqlDataReader borrarcliente(string  c)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from clientes where cedula=@cod ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cod", c);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
       
            return registros;
        }
    }
}
