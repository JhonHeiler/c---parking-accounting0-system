using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class ver_carros_en_lavado
    {
     
        public ver_carros_en_lavado()
        {

        }
        public SqlDataReader verificar()
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from ingreso_lavado";
            ejecutarSQL.CommandText = SQL;

            SqlDataReader usuario = ejecutarSQL.ExecuteReader();

            return usuario;

        }
    }
}
