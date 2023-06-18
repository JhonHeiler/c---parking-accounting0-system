using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class VerificarEmpleado
    {

        

        public VerificarEmpleado()
        {



        }
        public MySqlDataReader verififacionEMPLEADO(double cedula)
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from prestamo where cedula = @cedula";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cedula", cedula);
            MySqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }
        public MySqlDataReader empleadocedula(double valor, double cedula)
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

        public MySqlDataReader verififacionlavador(double cedula)
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from lavador where identificacion = @cedula";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cedula", cedula);
            MySqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }
        public MySqlDataReader actualizarLiquidacion(double valor, double cedula)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "UPDATE lavador SET valor=@valor where identificacion=@cedula";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@valor", valor);
            ejecutarSQL.Parameters.AddWithValue("@cedula", cedula);
           

            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }
    }
}
