using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public SqlDataReader verififacionEMPLEADO(double cedula)
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from prestamo where cedula = @cedula";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cedula", cedula);
            SqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }
        public SqlDataReader empleadocedula(double valor, double cedula)
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

        public SqlDataReader verififacionlavador(double cedula)
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from lavador where identificacion = @cedula";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cedula", cedula);
            SqlDataReader usuario = ejecutarSQL.ExecuteReader();


            return usuario;

        }
        public SqlDataReader actualizarLiquidacion(double valor, double cedula)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "UPDATE lavador SET valor=@valor where identificacion=@cedula";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@valor", valor);
            ejecutarSQL.Parameters.AddWithValue("@cedula", cedula);
           

            SqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }
    }
}
