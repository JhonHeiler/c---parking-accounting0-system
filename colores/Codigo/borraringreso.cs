using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class borraringreso
    {
     
        public borraringreso()
        {


        }
        public SqlDataReader borrarplaca(string c)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from ingreso where placa=@cod ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cod", c);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
       
            return registros;
        }
        public SqlDataReader borrarliquidacion(double identificacion)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from lavador where identificacion=@identificacion;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@identificacion", identificacion);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
    
            return registros;
        }
        public SqlDataReader borrarplacapendiente(string placa)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from vehiculo_pendientes where placa=@cod ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cod", placa);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
      
            return registros;
        }

    }
}
