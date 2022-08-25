using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class buscar_placa_cedula
    {


        public buscar_placa_cedula()
        {
            
        }
        public SqlDataReader buscarNIT(string c)
        {
            //Esto mostrara todo lo que haya en la lista buscado por el codigo
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from clientes where cedula  like @cod;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cod", c).Value = c + "%";
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
        
            return registros;

        }
    }
}
