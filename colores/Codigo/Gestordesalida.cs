using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class Gestordesalida
    {

        public Gestordesalida()
        {


        }
        public SqlDataReader verificarplaca(string a)
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from ingreso where placa = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            SqlDataReader usuario = ejecutarSQL.ExecuteReader();
      
            return usuario;

        }

        public SqlDataReader verificarplacapendiente(string placa)
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from vehiculo_pendientes where placa = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", placa);
            SqlDataReader usuario = ejecutarSQL.ExecuteReader();
       
            return usuario;

        }

    }
}
