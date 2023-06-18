using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace colores
{
    class registrar_ingreso_lavado
    {

        

        public registrar_ingreso_lavado()
        {



        }
        public MySqlCommand Registrarlavador(string placa, string encargado,double identificacion, string vehiculo, DateTime fecha,double total, string tipo_lavado)
        {


           var n=conexion.AbrirBD();
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD(); 

            string sql = "Insert into ingreso_lavado (placa,encargado,identificacion,vehiculo,fecha,total,tipo_lavado) values (@placa,@encar,@identificacion,@vehi,@fecha,@total,@tipo_lavado)";
            ejecutarSQL.CommandText = sql;
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            ejecutarSQL.Parameters.AddWithValue("@encar", encargado);
            ejecutarSQL.Parameters.AddWithValue("@identificacion",identificacion);
            ejecutarSQL.Parameters.AddWithValue("@vehi", vehiculo);
            ejecutarSQL.Parameters.AddWithValue("@fecha", fecha);
            ejecutarSQL.Parameters.AddWithValue("@total", total);
            ejecutarSQL.Parameters.AddWithValue("@tipo_lavado", tipo_lavado);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
           
            return null;

        }
     

    }
}
