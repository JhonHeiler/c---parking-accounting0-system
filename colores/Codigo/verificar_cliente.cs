using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class verificar_cliente
    {

        public verificar_cliente()
        {
        }
        public SqlDataReader verificacliente(string a)
        {
            //Verificamos si el dato escrito ya esta ingresado
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select cedula from clientes where cedula = @alias;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }

    }
}
