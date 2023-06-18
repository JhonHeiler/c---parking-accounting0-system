using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class gestordeingreso
    {
 
        public gestordeingreso()
        {

        }

        public MySqlCommand Registrar(DateTime fecha, string hora, string placa,string vehiculo,string user)
        {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();

            string sql = "Insert into temporal_ingreso(fecha,hora,placa,vehiculo,usuario) values (@fecha,@hora,@placa,@vehi,@usu)";
            ejecutarSQL.CommandText = sql;
            ejecutarSQL.Parameters.AddWithValue("@fecha", fecha);
            ejecutarSQL.Parameters.AddWithValue("@hora", hora);
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            ejecutarSQL.Parameters.AddWithValue("@vehi", vehiculo);
            ejecutarSQL.Parameters.AddWithValue("@usu", user);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
        
            return null;

        }
       
    }
}
