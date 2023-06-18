using System;
using System.Collections.Generic;
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
        public MySqlDataReader AbonoDeuda(double valor, double cedula)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "UPDATE prestamo SET valor=@valor where cedula=@cedula";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cedula", cedula);
            ejecutarSQL.Parameters.AddWithValue("@valor", valor);
       
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            
            return registros;
        }
        public MySqlDataReader eliminarDeuda( double cedula)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from prestamo where cedula=@cedula;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cedula", cedula);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
        
            return registros;
        }
    }
}
