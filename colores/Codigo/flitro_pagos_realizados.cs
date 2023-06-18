using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class flitro_pagos_realizados
    {
       

        public flitro_pagos_realizados()
        {
      
        }
        public MySqlDataReader pagos_realizados(string a)
        {
            //buscamos todo las ventas echas al cliente
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "select fecha,hora,placa,egresos,tipo,mes,servicio,cliente,usuario,valor from ventas where cliente = @alias";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@alias", a);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
            return registros;

        }
    }
}
