using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class verificar_placa_lavado
    {
       
        public verificar_placa_lavado()
        {


        }
        public SqlDataReader verificar(string a)
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from ingreso_lavado where placa = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            SqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }
    }
}
