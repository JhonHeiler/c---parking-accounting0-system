using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
        public SqlDataReader borrarpagos(int id)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from pagos where id_pagos=@id_pagos;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@id_pagos", id);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
           
            return registros;
        }
        public SqlDataReader borrarventas(int id)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from ventas where Id_ventas=@Id_ventas;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@Id_ventas", id);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
         
            return registros;
        }
        public SqlDataReader borrarpendientes(string placa)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from vehiculo_pendientes where placa=@placa;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
  
            return registros;
        }
        public SqlDataReader eliminarcarrolavado(string placa)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from ingreso_lavado where placa=@placa";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
           
            return registros;
        }
        public SqlDataReader eliminarcarroparqueadero(string placa)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "delete from ingreso where placa=@placa";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            SqlDataReader registros = ejecutarSQL.ExecuteReader();
         
            return registros;
        }
    }
}
