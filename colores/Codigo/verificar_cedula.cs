using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public SqlDataReader verificacedula(string a)
        {
            //Verificamos si el dato escrito ya esta ingresado
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select Id_user from usuarios where Id_user = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
            
            return registros;
        }
    }
}
