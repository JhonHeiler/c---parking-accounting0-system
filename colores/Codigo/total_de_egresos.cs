using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class total_de_egresos
    {
        
        public total_de_egresos()
        {
        }
        public MySqlDataReader totalventasfiltrada(string fecha1, string fecha2)
        {
          
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select sum(egresos) from ventas where fecha between @fecha1 and @fecha2 ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@fecha1", fecha1);
            ejecutarSQL.Parameters.AddWithValue("@fecha2", fecha2);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            
            return registros;
        }
        public MySqlDataReader pagos_realizados(string fecha1, string fecha2)
        {
            
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select sum(valor) from lavador where fecha between @fecha1 and @fecha2 ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@fecha1", fecha1);
            ejecutarSQL.Parameters.AddWithValue("@fecha2", fecha2);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
      
            return registros;
        }
        public MySqlDataReader mostrarventas(string fecha1,string fecha2, string nombre)
        {
            
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from ventas where fecha between @fecha1 and @fecha2 and placa like @nomb";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@fecha1", fecha1);
            ejecutarSQL.Parameters.AddWithValue("@fecha2", fecha2);
            ejecutarSQL.Parameters.AddWithValue("@nomb", nombre).Value = nombre + "%";
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
       
            return registros;
        }
    }
}
