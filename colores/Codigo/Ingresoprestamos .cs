using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colores
{
    class Ingresoprestamos
    {

     
        public Ingresoprestamos()
        {

           
        }
        public MySqlCommand Registrar_prestamos(string nombre, double cedula, double valor, DateTime fecha, string hora)
        {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string sql = "INSERT INTO prestamo(nombre,cedula,valor,fecha,hora )" +
                " values (@nombre,@cedula,@valor,@fech,@hora)";
            ejecutarSQL.CommandText = sql;
            
            ejecutarSQL.Parameters.AddWithValue("@nombre", nombre);
            ejecutarSQL.Parameters.AddWithValue("@cedula", cedula);
            ejecutarSQL.Parameters.AddWithValue("@valor", valor);
            ejecutarSQL.Parameters.AddWithValue("@fech", fecha);
            ejecutarSQL.Parameters.AddWithValue("@hora", hora);
            ejecutarSQL.ExecuteNonQuery();
            return null;

        }
    }
}
