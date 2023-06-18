using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class Agg_cliente
    {
    
        public Agg_cliente()
        {
          
        }

        public MySqlCommand Registrar_cliente(string cedula, string nombre, string telefono, string celular,
            string direccion, string correo, string dia, string refe, string comentario)

        {
            MySqlCommand ejecutarSQL = new MySqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string sql = "Insert into clientes (cedula,nombre,telefono,celular,direccion," +
                "correo,dia_pago,ref_pago,comentario) values (@NIT,@nom,@tel,@cel,@direc,@correo,@moroso,@refe,@comentario);";
            ejecutarSQL.CommandText = sql;
            ejecutarSQL.Parameters.AddWithValue("@NIT", cedula);
            
            ejecutarSQL.Parameters.AddWithValue("@nom", nombre);
            ejecutarSQL.Parameters.AddWithValue("@tel", telefono);
            ejecutarSQL.Parameters.AddWithValue("@cel", celular);
            ejecutarSQL.Parameters.AddWithValue("@direc", direccion);
            
            ejecutarSQL.Parameters.AddWithValue("@correo", correo);
            ejecutarSQL.Parameters.AddWithValue("@moroso", dia);
            ejecutarSQL.Parameters.AddWithValue("@refe", refe);
            ejecutarSQL.Parameters.AddWithValue("@comentario", comentario);
            int Num = ejecutarSQL.ExecuteNonQuery();
       
            return null;
             
        }
        
    }
}
