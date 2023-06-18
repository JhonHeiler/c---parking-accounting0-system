using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class Pagos_lavadores
    {
       
        public Pagos_lavadores()
        {
     
        }

        public MySqlCommand Registrar_pagos_empleado(DateTime fecha, string hora, string nombre, double ident,double valor)

        {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string sql = "Insert into pagos(id_pagos,fecha,hora,nombre,identificacion,valor)" +
            " values (@id,@fech,@hora,@nombre,@ident,@valor)";
            ejecutarSQL.CommandText = sql;
            ejecutarSQL.Parameters.AddWithValue("@id", null);
            ejecutarSQL.Parameters.AddWithValue("@fech", fecha);
            ejecutarSQL.Parameters.AddWithValue("@hora", hora);
            ejecutarSQL.Parameters.AddWithValue("@nombre", nombre);
            ejecutarSQL.Parameters.AddWithValue("@ident", ident);
            ejecutarSQL.Parameters.AddWithValue("@valor", valor);

            int Num = ejecutarSQL.ExecuteNonQuery();
            return null;

        }

    }
}
