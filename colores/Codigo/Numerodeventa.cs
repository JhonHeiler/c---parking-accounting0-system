using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public SqlDataReader ultimoregistro()
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from ventas where Id_ventas = (SELECT MAX(Id_ventas)from ventas);";
            ejecutarSQL.CommandText = SQL;
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }
        public SqlDataReader Lavador()
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from lavador where identificacion =identificacion;";
            ejecutarSQL.CommandText = SQL;
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }

    }
}
