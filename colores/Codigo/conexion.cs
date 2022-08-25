using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class conexion
    {
        static SqlConnection con;
        public static SqlConnection AbrirBD()
        {
           
            con = new SqlConnection("Data Source=127.0.0.1;Initial Catalog=colores;Integrated Security=True;");
            try
            {
                con.Open();

                return con;
            }
            catch (Exception error)
            {
                System.Windows.Forms.MessageBox.Show("Error en la conexion" + error.Message);
                con.Close();
                return null;


            }
        }
        public static SqlConnection cerrarBD()
        {
            con.Close();
            return con;
        }
    }
}
