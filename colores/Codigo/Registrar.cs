using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class Registrar
    {

        public Registrar()
        {


        }
        public SqlCommand Registrar_ingreso()
        {
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string sql = "Insert into ingreso select * from temporal_ingreso";
            ejecutarSQL.CommandText = sql;


            
            int Num = ejecutarSQL.ExecuteNonQuery();
            return null;

        }

    }
}
