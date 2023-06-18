using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class Numerodeventa
    {
   
        public Numerodeventa()
        {

       
        }
        public MySqlDataReader ultimoregistro()
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from ventas where Id_ventas = (SELECT MAX(Id_ventas)from ventas);";
            ejecutarSQL.CommandText = SQL;
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }
        public MySqlDataReader Lavador()
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from lavador where identificacion =identificacion;";
            ejecutarSQL.CommandText = SQL;
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }

    }
}
