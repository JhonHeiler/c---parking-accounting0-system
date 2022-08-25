using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class verificar_usuario
    {
     

        public verificar_usuario()
        {

           


        }
        public SqlDataReader verificarusuario(string a)
        {
            
            //Verificamos si nuestro usuario ingresa el nombre correcto
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from usuarios where Id_user = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            SqlDataReader usuario = ejecutarSQL.ExecuteReader();
            return usuario;
           
        }

    }
}
