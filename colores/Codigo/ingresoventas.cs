using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace colores
{
    class ingresoventas
    {

  
        public ingresoventas()
        {

       
        }
        public MySqlCommand Registrar_venta(int id, DateTime fecha, string horae, string placa ,double egresos, string tipo,string mes,string servicio,string cliente,string usuario, double valor)
        {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string sql = "Insert into ventas(Id_ventas,fecha,hora,placa,egresos,tipo,mes,servicio,cliente,usuario,valor)" +
                " values (@id,@fech,@horae,@placa,@egre,@tipo,@mes,@serv,@clie,@user,@valor)";
            ejecutarSQL.CommandText = sql;
            ejecutarSQL.Parameters.AddWithValue("@id", id);
            ejecutarSQL.Parameters.AddWithValue("@fech", fecha);
            ejecutarSQL.Parameters.AddWithValue("@horae", horae);
            ejecutarSQL.Parameters.AddWithValue("@placa", placa);
            ejecutarSQL.Parameters.AddWithValue("@egre", egresos);
            ejecutarSQL.Parameters.AddWithValue("@tipo", tipo);
            ejecutarSQL.Parameters.AddWithValue("@mes", mes);
            ejecutarSQL.Parameters.AddWithValue("@serv", servicio);
            ejecutarSQL.Parameters.AddWithValue("@clie", cliente);
            ejecutarSQL.Parameters.AddWithValue("@user", usuario);
            ejecutarSQL.Parameters.AddWithValue("@valor", valor);
            
            int Num = ejecutarSQL.ExecuteNonQuery();
            return null;

        }
    }
}
