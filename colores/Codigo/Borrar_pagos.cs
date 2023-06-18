using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class Borrar_pagos
    {

     
        public Borrar_pagos()
        {

        
        }
        public MySqlDataReader borrarpagos(int id)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from pagos where id_pagos=@id_pagos;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@id_pagos", id);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
           
            return registros;
        }
        public MySqlDataReader borrarventas(int id)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from ventas where Id_ventas=@Id_ventas;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@Id_ventas", id);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
         
            return registros;
        }
        public MySqlDataReader borrarpendientes(string placa)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from vehiculo_pendientes where placa=@placa;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
  
            return registros;
        }
        public MySqlDataReader eliminarcarrolavado(string placa)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from ingreso_lavado where placa=@placa";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
           
            return registros;
        }
        public MySqlDataReader eliminarcarroparqueadero(string placa)
        {
            //Actualizaremos datos
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from ingreso where placa=@placa";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            MySqlDataReader registros = ejecutarSQL.ExecuteReader();
         
            return registros;
        }
    }
}
