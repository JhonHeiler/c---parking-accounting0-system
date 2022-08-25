using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class preciolavada
    {
     

        public preciolavada()
        {

        }
        public SqlDataReader verificarprecio(string a)
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from precio_lavado where descripcion = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            SqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }
    }
}
