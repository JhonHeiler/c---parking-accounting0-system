using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class Abono_deudas
    {

     
        public Abono_deudas()
        {

        }
        public SqlDataReader AbonoDeuda(double valor, double cedula)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "UPDATE prestamo SET valor=@valor where cedula=@cedula";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cedula", cedula);
            ejecutarSQL.Parameters.AddWithValue("@valor", valor);
       
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
            
            return registros;
        }
        public SqlDataReader eliminarDeuda( double cedula)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from prestamo where cedula=@cedula;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cedula", cedula);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
        
            return registros;
        }
    }
}
