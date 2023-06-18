using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class ingreso_ventas_lavador
    {


        public ingreso_ventas_lavador()
        {



        }
        public MySqlCommand Registrarlavador(DateTime fecha, string hora, string nombre, int identificacion, int valor)
        {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();

            string sql = "Insert into lavador (fecha,hora,nombre,identificacion,valor) values (@fecha,@hora,@nombre,@identificacion,@valor)";
            ejecutarSQL.CommandText = sql;
            ejecutarSQL.Parameters.AddWithValue("@fecha", fecha);
            ejecutarSQL.Parameters.AddWithValue("@hora", hora);
            ejecutarSQL.Parameters.AddWithValue("@nombre", nombre);
            ejecutarSQL.Parameters.AddWithValue("@identificacion", identificacion);
            ejecutarSQL.Parameters.AddWithValue("@valor", valor);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return null;

        }
    }
}
