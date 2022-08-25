using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace colores
{
    class editar_cliente
    {
       
        public editar_cliente()
        {

        }
        public SqlDataReader Actualizarcliente(string ced, string nom, string tel, string cel, string dir, 
            string corr,string dia,string refe, string com)
        {
            //Actualizaremos datos
            SqlCommand ejecutarSQL = new SqlCommand();
            ejecutarSQL.Connection = conexion.AbrirBD();
            string SQL = "update clientes set nombre= @nom,telefono = @tel ,celular=@cel,direccion=@dir," +
                "correo= @corr,dia_pago = @dia ,ref_pago=@ref,comentario=@com where cedula=@cod ;";
            ejecutarSQL.CommandText = SQL;
            ejecutarSQL.Parameters.AddWithValue("@cod", ced);
            ejecutarSQL.Parameters.AddWithValue("@nom", nom);
            ejecutarSQL.Parameters.AddWithValue("@tel", tel);
            ejecutarSQL.Parameters.AddWithValue("@cel", cel);
            ejecutarSQL.Parameters.AddWithValue("@dir", dir);
            ejecutarSQL.Parameters.AddWithValue("@corr", corr);
            ejecutarSQL.Parameters.AddWithValue("@dia", dia);
            ejecutarSQL.Parameters.AddWithValue("@ref", refe);
            ejecutarSQL.Parameters.AddWithValue("@com", com);

            SqlDataReader registros = ejecutarSQL.ExecuteReader();
           
            return registros;
        }
    }
}
