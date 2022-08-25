using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class registrar_usuario
    {
       

        public registrar_usuario()
        {




        }
        public MySqlCommand Registrar(int id, string nom, string contra, string car)
        {
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();

            string sql = "Insert into usuarios (Id_user,nombre_user,contraseña_user,cargo_user) values (@id,@nombre,@contra,@cargo)";
            ejecutarSQL.CommandText = sql;
            ejecutarSQL.Parameters.AddWithValue("@id", id);
            ejecutarSQL.Parameters.AddWithValue("@nombre", nom);
            ejecutarSQL.Parameters.AddWithValue("@contra", contra);
            ejecutarSQL.Parameters.AddWithValue("@cargo", car);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
           
            return null;

        }

    }
}
