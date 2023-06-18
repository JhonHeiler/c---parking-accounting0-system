using System;
using System.Collections.Generic;
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
        public MySqlDataReader verificacliente(string a)
        {
            //Verificamos si el dato escrito ya esta ingresado
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select cedula from clientes where cedula = @alias;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }

    }
}
