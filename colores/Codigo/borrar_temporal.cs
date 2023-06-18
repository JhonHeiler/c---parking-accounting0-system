using System;
using System.Collections.Generic;
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
        public MySqlDataReader borrar()
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "truncate table temporal_ingreso;";
            ejecutarSQL.CommandText = SQL;
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
    
            return registros;
        }

    }
}
