using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;

namespace colores
{
    public partial class Detallesdeventa : Form
    {
        int posicion = 0;
        string no;
        MySqlConnection cerrar;
        public Detallesdeventa()
        {
            InitializeComponent();
           

        }
        int egresos;
        private void btnfiltar_Click(object sender, EventArgs e)
        {
            
            filtar();
           
            btnreporte.Enabled = true;
           

        }


        public void filtar()
        {
            string ventas;
            
            //convertimos los datetime en string para su filtracion
            gestordetalledeventa gv = new gestordetalledeventa();
            DataTable dt = new DataTable();
            string m1 = Convert.ToString(fecha1.Value.Month);
            string a1 = Convert.ToString(fecha1.Value.Year);
            string d1 = Convert.ToString(fecha1.Value.Day);

            string m2 = Convert.ToString(fecha2.Value.Month);
            string a2 = Convert.ToString(fecha2.Value.Year);
            string d2 = Convert.ToString(fecha2.Value.Day);
            //Esto lo hago para ponerle un cero a todos los numeros de 1 a 9
            if (Convert.ToInt32(d1) < 10) { d1 = 0 + d1; }
            if (Convert.ToInt32(d2) < 10) { d2 = 0 + d2; }
            if (Convert.ToInt32(m1) < 10) { m1 = 0 + m1; }
            if (Convert.ToInt32(m2) < 10) { m2 = 0 + m2; }
            string f1 = (a1 + m1 + d1);
            string f2 = (a2 + m2 + d2);
            try
            {
                total_de_egresos tde = new total_de_egresos();
                MySqlDataReader My;
                My = tde.totalventasfiltrada(f1, f2);
                if (My.Read())
                {
                    egresos = My.GetInt32(0);
                    Console.WriteLine(egresos);
                }

                total_de_ventas_detallada tdvd = new total_de_ventas_detallada();
                MySqlDataReader myReader;
                myReader = tdvd.totalventasfiltrada(f1, f2);
                
                if (myReader.Read())
                {
                   
                    //Mostrador el total de ventas el un label
                    ventas = Convert.ToString(myReader.GetInt32(0));
                   
                    
                    lbltotalventas.Text = Convert.ToString(Convert.ToInt32(ventas) - egresos);
                 
                    
                    dt.Load(gv.mostrarventaspormes(f1, f2));
                    dataGridView1.DataSource = dt;
                    this.dataGridView1.Columns["Id_ventas"].Visible = false;
                    conexion.cerrarBD();




                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Fechas filtradas no tiene ventas. Si tienes dudas hable con encargado de sistema, 3234960276. " + error.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            

        }

       /* public void flitra2()
        {

            datoscrystal dc = new datoscrystal();

            dc.Registrar(Convert.ToDateTime(fecha1.Value.Date), Convert.ToDateTime(fecha2.Value.Date), Convert.ToInt32(lbltotalventas.Text));
            MySqlDataReader my;
            mostrardatoscrystal mdc = new mostrardatoscrystal();
            DataTable dt1 = new DataTable();
            my = mdc.mostrardatos();
            if (my.Read())
            {
                dt1.Load(mdc.mostrardatos());
                dataGridView2.DataSource = dt1;
            }
            else { MessageBox.Show("hola", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }

        }
        */
        private void Detallesdeventa_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            


        }
        public void exportaraexcel(DataGridView tabla)
        {

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            int IndiceColumna = 0;

            foreach (DataGridViewColumn col in tabla.Columns)
            {

                IndiceColumna++;

                excel.Cells[1, IndiceColumna] = col.Name;

            }

            int IndeceFila = 0;

            foreach (DataGridViewRow row in tabla.Rows)
            {

                IndeceFila++;

                IndiceColumna = 0;

                foreach (DataGridViewColumn col in tabla.Columns)
                {

                    IndiceColumna++;

                    excel.Cells[IndeceFila + 1, IndiceColumna] = row.Cells[col.Name].Value;

                }

            }

            excel.Visible = true;


        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            lblmensaje.Visible = true;
            lblmensaje.Text = "Estamos exportando......";
            exportaraexcel(dataGridView1);
        }

       
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            posicion = dataGridView1.CurrentRow.Index;
            txtBorrarPago.Text = dataGridView1[0, posicion].Value.ToString();
            txtNombre.Text = dataGridView1[3, posicion].Value.ToString();

            no = txtNombre.Text;





        }
        public DataTable llenar_datagrid()
        {
            conexion.AbrirBD();
            DataTable dt = new DataTable();
            string consulta = "select * from pagos";
            MySqlCommand ejecutarSQL = new MySqlCommand(consulta, conexion.AbrirBD());
            MySqlDataAdapter jhon = new MySqlDataAdapter(ejecutarSQL);

            jhon.Fill(dt);
            return dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta habilitando la opcion para eliminar");
            dataGridView1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cargo = Form1.cargo;
            if (cargo != "Admi")
            {
                MessageBox.Show("No cuenta con permiso para eliminar las ventas registrada en el sistema.....!cumuniquese con el administrador");
            }
            else

             if (MessageBox.Show("¿Desea eliminar el registro de la venta?: " + no, "Pago empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Borrar_pagos borrar = new Borrar_pagos();
                borrar.borrarventas(Convert.ToInt32(txtBorrarPago.Text));
                dataGridView1.DataSource = llenar_datagrid();
                filtar();
                dataGridView1.Enabled = false;

            }

            else

            {

                MessageBox.Show("Tranquilo! El registro no fue eliminado del sistema : ");

            }

        }

        private void btbbuscarp_Click(object sender, EventArgs e)
        {

            string m1 = Convert.ToString(fecha1.Value.Month);
            string a1 = Convert.ToString(fecha1.Value.Year);
            string d1 = Convert.ToString(fecha1.Value.Day);

            string m2 = Convert.ToString(fecha2.Value.Month);
            string a2 = Convert.ToString(fecha2.Value.Year);
            string d2 = Convert.ToString(fecha2.Value.Day);
            //Esto lo hago para ponerle un cero a todos los numeros de 1 a 9
            if (Convert.ToInt32(d1) < 10) { d1 = 0 + d1; }
            if (Convert.ToInt32(d2) < 10) { d2 = 0 + d2; }
            if (Convert.ToInt32(m1) < 10) { m1 = 0 + m1; }
            if (Convert.ToInt32(m2) < 10) { m2 = 0 + m2; }
            string f1 = (a1 + m1 + d1);
            string f2 = (a2 + m2 + d2);

            try
            {
                


                total_de_egresos vpl = new total_de_egresos();
                DataTable dt = new DataTable();
                dt.Load(vpl.mostrarventas(f1,f2, txtPlaca.Text));
                dataGridView1.DataSource = dt;
                this.dataGridView1.Columns["Id_ventas"].Visible = false;

                //---------------------------------------------------------------------------------------------------------


            }
            catch
            {
                MessageBox.Show("No  hay ventas en la fecha actual! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
