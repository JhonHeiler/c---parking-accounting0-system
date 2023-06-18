using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class Ingreso_pendientes
    {
     
        public Ingreso_pendientes()
        {

          
        }
        public MySqlCommand Registrar_pendiente(DateTime fecha, string hora, string usuario, string placa, string vehiculo,string estado, double valor)
        {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string sql = "Insert vehiculo_pendientes(fecha,hora,lavador,placa,vehiculo,estado,valor)values (@fecha,@hora,@usuario,@placa,@vehiculo,@estado,@valor)";
            ejecutarSQL.CommandText = sql;
            ejecutarSQL.Parameters.AddWithValue("@fecha", fecha);
            ejecutarSQL.Parameters.AddWithValue("@hora", hora);
            ejecutarSQL.Parameters.AddWithValue("@usuario", usuario);
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            ejecutarSQL.Parameters.AddWithValue("@vehiculo", vehiculo);
            ejecutarSQL.Parameters.AddWithValue("@estado", estado);
            ejecutarSQL.Parameters.AddWithValue("@valor", valor);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return null;

        }
    }
}

