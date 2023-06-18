using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class ventas_por_lavador
    {



        public ventas_por_lavador()
        {

        }
        public MySqlDataReader mostrarventas(string fecha1, string nombre)
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select nombre,identificacion,valor,fecha,hora from lavador where nombre like @nomb and fecha = @fecha1 ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@fecha1", fecha1);
            ejecutarSQL.Parameters.AddWithValue("@nomb", nombre).Value = nombre + "%";


            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }
        public MySqlDataReader mostrarempleado(string fecha1, string nombre)
        {
            //Cuando cargue el formulario de Productos se muestren todos los productos registrados
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select nombre,valor,fecha,hora from prestamo where nombre like @nomb and fecha = @fecha1 ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@fecha1", fecha1);
            ejecutarSQL.Parameters.AddWithValue("@nomb", nombre).Value = nombre + "%";


            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;
        }
    }
}
