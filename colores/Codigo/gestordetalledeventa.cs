using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace colores
{
    class gestordetalledeventa
    {

     
        public gestordetalledeventa()
        {
          
            
        }
        public MySqlDataReader mostrarventaspormes(string fecha1, string fecha2)
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from ventas where fecha between @fecha1 and @fecha2 ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@fecha1", fecha1);
            ejecutarSQL.Parameters.AddWithValue("@fecha2", fecha2);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
            
        }
        public MySqlDataReader mostrarventaspormespagos(string fecha1, string fecha2)
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from pagos where fecha between @fecha1 and @fecha2 ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@fecha1", fecha1);
            ejecutarSQL.Parameters.AddWithValue("@fecha2", fecha2);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
 
            return registros;
      
        }
    }
}
