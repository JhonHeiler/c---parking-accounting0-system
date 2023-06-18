using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace colores
{
    public partial class Vehiculos_pendientes : Form
    {
        int posicion = 0;
        string no;
        public Vehiculos_pendientes()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = mostrar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
              

                conexion.AbrirBD();
                string buscar = "SELECT fecha,hora,lavador,placa,vehiculo,estado,valor FROM vehiculo_pendientes WHERE placa like ('" + txtplaca.Text + "%')";
                MySqlCommand ejecutarSQL = new MySqlCommand(buscar, conexion.AbrirBD());
                ejecutarSQL.ExecuteNonQuery();
                DataTable dta = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(ejecutarSQL);
                da.Fill(dta);

                dataGridView1.DataSource = dta;
                conexion.cerrarBD();
            }

           
            catch (Exception)
            {
                MessageBox.Show("No hay vehiculos pendientes registrado a la fecha...");
            }
        }
        public DataTable mostrar()
        {
            conexion.AbrirBD();
            DataTable dt = new DataTable();
            string buscar = "SELECT fecha,hora,lavador,placa,vehiculo,estado,valor FROM vehiculo_pendientes";
            MySqlCommand ejecutarSQL = new MySqlCommand(buscar, conexion.AbrirBD());
            MySqlDataAdapter jhon = new MySqlDataAdapter(ejecutarSQL);

            jhon.Fill(dt);
            conexion.cerrarBD();
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta habilitando la opcion para eliminar");
            dataGridView1.Enabled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
                posicion = dataGridView1.CurrentRow.Index;
                txtBorrarPendiente.Text = dataGridView1[3, posicion].Value.ToString();
                textBox1.Text = dataGridView1[4, posicion].Value.ToString();

                no = textBox1.Text;



         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cargo = Form1.cargo;

            if (cargo != "Admi")
            {
                MessageBox.Show("No cuenta con el rol para eliminar los vehiculo que estan en estado pendientes en el sistema!   Comuniquese con su administrador");
            }
            else
            if (MessageBox.Show("¿Desea eliminar el registro del vehiculo?: " + no, "Vehiculo estado pendiente", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Borrar_pagos borrar = new Borrar_pagos();
                borrar.borrarpendientes(txtBorrarPendiente.Text);

                dataGridView1.DataSource = mostrar();

                dataGridView1.Enabled = false;
                conexion.cerrarBD();


            }

            else

            {

                MessageBox.Show("Tranquilo! El registro no fue eliminado del sistema : ");

            }
        }
    }
}
