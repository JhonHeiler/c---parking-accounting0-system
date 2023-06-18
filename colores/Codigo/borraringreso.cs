using System;
using System.Collections.Generic;
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
        public MySqlDataReader borrarplaca(string c)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from ingreso where placa=@cod ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cod", c);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
       
            return registros;
        }
        public MySqlDataReader borrarliquidacion(double identificacion)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from lavador where identificacion=@identificacion;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@identificacion", identificacion);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
    
            return registros;
        }
        public MySqlDataReader borrarplacapendiente(string placa)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from vehiculo_pendientes where placa=@cod ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cod", placa);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
      
            return registros;
        }

    }
}
