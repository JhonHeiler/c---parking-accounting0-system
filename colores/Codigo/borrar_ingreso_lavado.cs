using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class borrar_ingreso_lavado
    {

  
        public borrar_ingreso_lavado()
        {

        }
        public SqlDataReader borrarplaca(string c)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from ingreso_lavado where placa=@cod ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cod", c);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
         
            return registros;
        }
    }
}
