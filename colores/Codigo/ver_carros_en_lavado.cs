using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class ver_carros_en_lavado
    {
     
        public ver_carros_en_lavado()
        {

        }
        public MySqlDataReader verificar()
        {
            //Verificamos si nuestro usuario ingresa el nombre correcto
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select * from ingreso_lavado";
            ejecutarSQL.CommandText = SQL;

            MySqlDataReader usuario = ejecutarSQL.ExecuteReader();

            return usuario;

        }
    }
}
