using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class verificar_cedula
    {
    

        public verificar_cedula()
        {

           


        }
        public MySqlDataReader verificacedula(string a)
        {
            //Verificamos si el dato escrito ya esta ingresado
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select Id_user from usuarios where Id_user = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            
            return registros;
        }
    }
}
