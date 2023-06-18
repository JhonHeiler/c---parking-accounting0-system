﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace colores
{
    class conexion
    {
        static MySqlConnection con;
        public static MySqlConnection AbrirBD()
        {
           
            con = new MySqlConnection("Server=localhost; Database = colores; Uid=root;Pwd=;SslMode=none;");
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
        public static MySqlConnection cerrarBD()
        {
            con.Close();
            return con;
        }
    }
}
