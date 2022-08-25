using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class ver_tabla_ingreso
    {

        public ver_tabla_ingreso()
        {

  
        }
        public SqlDataReader verificar()
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from ingreso ";
            ejecutarSQL.CommandText = SQL;
           
            SqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }
    }
}
