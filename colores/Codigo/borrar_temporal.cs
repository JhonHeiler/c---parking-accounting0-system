using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace colores
{
    class borrar_temporal
    {
   
        public borrar_temporal()
        {

        }
        public SqlDataReader borrar()
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "truncate table temporal_ingreso;";
            ejecutarSQL.CommandText = SQL;
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
    
            return registros;
        }

    }
}
