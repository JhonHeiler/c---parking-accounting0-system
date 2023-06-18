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
    public partial class liquidar_encargado : Form
    {
        int posicion = 0;
        double valorabono;
        string nome;

        public liquidar_encargado()
        {
            InitializeComponent();
           
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
            
        }
        int contador;
        public static string nombre;
        public static double identificacion;
        public static double valor;
       

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string m1 = Convert.ToString(fecha1.Value.Month);
            string a1 = Convert.ToString(fecha1.Value.Year);
            string d1 = Convert.ToString(fecha1.Value.Day);
            if (Convert.ToInt32(d1) < 10) { d1 = 0 + d1; }
            if (Convert.ToInt32(m1) < 10) { m1 = 0 + m1; }
            string f1 = (a1 + m1 + d1);
            liquidacion_encargado tde = new liquidacion_encargado();
            MySqlDataReader My;
            My = tde.totalventas(f1, txtbuscar.Text);
           
     

            try
            {
                if (My.Read())
                {
                    lbltotalventas.Text = Convert.ToString(My.GetInt32(0));
                }



                ventas_por_lavador vpl = new ventas_por_lavador();
                DataTable dt = new DataTable();
                dt.Load(vpl.mostrarventas(f1, txtbuscar.Text));
                dataGridView1.DataSource = dt;

                //---------------------------------------------------------------------------------------------------------
                conexion.cerrarBD();

            }
            catch 
            {
                MessageBox.Show("NO hay servicios de lavados por el momento ! " ,"Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

         
         
        }
       
        private void liquidar_encargado_Load(object sender, EventArgs e)
        {
            txtbuscar.Select();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btbbuscarp_Click(object sender, EventArgs e)
        {


            liquidacion_encargado tede = new liquidacion_encargado();
            MySqlDataReader Moy;
            Moy = tede.totalpretamo(txtbuscar.Text);



            try
            {
                if (Moy.Read())
                {
                    lblTotalprestamo.Text = Convert.ToString(Moy.GetInt32(0));
                    //totalP.Text = Convert.ToString(Moy.GetInt32(0) - My.GetInt32(0));
                }


                conexion.AbrirBD();
                string buscar = "SELECT nombre,cedula,valor,fecha,hora FROM prestamo WHERE nombre like ('" + txtbuscar.Text + "%')";
                MySqlCommand ejecutarSQL = new MySqlCommand(buscar, conexion.AbrirBD());
                ejecutarSQL.ExecuteNonQuery();
                DataTable dta = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(ejecutarSQL);
                da.Fill(dta);

                dataGridView2.DataSource = dta;
                conexion.cerrarBD();

            }
            catch(Exception)
            {
                MessageBox.Show("No hay presmaos registrado a la fecha...");
            }

        }

        private void btn_pago_Click(object sender, EventArgs e)
        {
            lblhorasalida.Text = DateTime.Now.ToString("HH:mm:ss");
            if (string.IsNullOrEmpty(txtIdentificacion.Text))
            {
                MessageBox.Show("Por favor seleccione el empleado que desea pagarle", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else {
                string usuario = Form1.variable;
                nombre = txtNombre.Text;
                identificacion = Convert.ToDouble(txtIdentificacion.Text);
                if(string.IsNullOrEmpty(txtValor.Text))
                    {
                    MessageBox.Show("Por favor ingrese el valor que le desea pagar al empleado", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValor.Select();
                    return;

                }

                valor = Convert.ToDouble(txtValor.Text);

                //Agregamos en la tabla de pago
                Pagos_lavadores p = new Pagos_lavadores();
                p.Registrar_pagos_empleado(Convert.ToDateTime(dateTimePicker1.Value.Date), lblhorasalida.Text, txtNombre.Text, Convert.ToDouble(txtIdentificacion.Text), Convert.ToDouble(txtValor.Text));


                /// DESCONTAMOS DONDE ESTA TODA LA PLATA ACOMULADA
                /// 
                string usua = Form1.variable;
                ingresoventas igv = new ingresoventas();
                igv.Registrar_venta(contador, Convert.ToDateTime(dateTimePicker1.Value.Date), lblhorasalida.Text, txtNombre.Text, Convert.ToInt32(txtValor.Text), "Egreso", "", "Pago de empleado", "Empleado", usua, 0);

                //Borramos el lavador de la tabla lavador
                borraringreso bi = new borraringreso();
                bi.borrarliquidacion(Convert.ToDouble(txtIdentificacion.Text));



                impresion_empleado im = new impresion_empleado();
                im.Show();
                //actualizar tabla
                string m1 = Convert.ToString(fecha1.Value.Month);
                string a1 = Convert.ToString(fecha1.Value.Year);
                string d1 = Convert.ToString(fecha1.Value.Day);
                if (Convert.ToInt32(d1) < 10) { d1 = 0 + d1; }
                if (Convert.ToInt32(m1) < 10) { m1 = 0 + m1; }
                string f1 = (a1 + m1 + d1);
                ventas_por_lavador vpl = new ventas_por_lavador();
                DataTable dt = new DataTable();
                dt.Load(vpl.mostrarventas(f1, txtbuscar.Text));
                dataGridView1.DataSource = dt;
              
                conexion.cerrarBD();
                this.Close();
                txtValor.Visible = false;
                btn_pago.Visible = false;
                lblliqui.Visible = false;
                txtValor.Text = "";
            }
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            posicion = dataGridView1.CurrentRow.Index;
            txtNombre.Text = dataGridView1[0, posicion].Value.ToString();
            txtIdentificacion.Text = dataGridView1[1, posicion].Value.ToString();
            string nom = txtNombre.Text;

            if (MessageBox.Show("¿Desea realizar el pago al empleado?: "+ nom, "Pago empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btn_pago.Visible = true;
                txtValor.Visible = true;
                lblliqui.Visible = true;
                txtValor.Select();
                dataGridView1.Enabled = false;




            }

            else

            {

                MessageBox.Show("Pago no realizado al empleado: "+ nom);

            }

        }


        
       
        public DataTable llenar_datagridprestamo()
        {
            conexion.AbrirBD();
            DataTable dt = new DataTable();
            string consulta = "select nombre,cedula,valor,fecha,hora from prestamo";
            MySqlCommand ejecutarSQL = new MySqlCommand(consulta, conexion.AbrirBD());
            MySqlDataAdapter jhon = new MySqlDataAdapter(ejecutarSQL);

            jhon.Fill(dt);
            conexion.cerrarBD();
        
            return dt;

        }


        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            posicion = dataGridView2.CurrentRow.Index;
            txtIdentificacion1.Text = dataGridView2[1, posicion].Value.ToString();
            textBox12.Text = dataGridView2[2, posicion].Value.ToString();
            texnombre1.Text = dataGridView2[0, posicion].Value.ToString();
            nome = texnombre1.Text;

            if (Convert.ToDouble(textBox12.Text) <= 0)
            {
                MessageBox.Show("El sistema no resgistra que el empleado " + nome + " tenga deuda pendiente");
            }
           else if (MessageBox.Show("¿Desea realizar el abono al empleado?: " + nome, "Pago empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lblingresaV.Visible = true;
                txtvalor1.Visible = true;
                btnpagar1.Visible = true;
                txtvalor1.Select();
                dataGridView2.Enabled = false;




            }
            
            else

            {

                MessageBox.Show("No se realizado el abono al empleado: " + nome);

            }


        }
        private void btnpagar1_Click_1(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(txtvalor1.Text))
            {
                MessageBox.Show("Por favor ingrese el valor que le desea abonar", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtvalor1.Select();
                return;

            }
            else if (Convert.ToDouble(txtvalor1.Text) <= Convert.ToDouble(textBox12.Text))
            {

                
                    valorabono = Convert.ToDouble(textBox12.Text) - Convert.ToDouble(txtvalor1.Text);

                    Abono_deudas deuda = new Abono_deudas();
                    deuda.AbonoDeuda(valorabono, Convert.ToDouble(txtIdentificacion1.Text));
                    
                    btnpagar1.Visible = false;
                /// ABONAR DEUDA
                /// 

                //aumentar dinero
                string usuar = Form1.variable;
                ingresoventas igv = new ingresoventas();
                igv.Registrar_venta(contador, Convert.ToDateTime(dateTimePicker1.Value.Date), lblhorasalida.Text, texnombre1.Text, 0, "Ingreso", "", "Abono", "empleado", usuar,Convert.ToDouble(txtvalor1.Text));
                lblingresaV.Visible = false;
                txtvalor1.Visible = false;
                dataGridView2.DataSource = llenar_datagridprestamo();
                txtvalor1.Text = "";
                txtvalor1.Select();
                MessageBox.Show("Abono realizado con exito");
                /////eliminar deuda
                if (valorabono == 0)
                {
                Abono_deudas eliminardeudad = new Abono_deudas();
                eliminardeudad.eliminarDeuda(Convert.ToDouble(txtIdentificacion1.Text));
                dataGridView2.DataSource = llenar_datagridprestamo();
                    
                }
                
                conexion.cerrarBD();
                this.Close();
            }
           
            else
            {

                MessageBox.Show("El sistema no resgistra que el empleado " + nome + " deba toda esa cantida de dinero");

            }
        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            btn_pago.Enabled = true;
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Por favor ingrese el valor que le desea pagar al empleado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtvalor1_TextChanged(object sender, EventArgs e)
        {

            btnpagar1.Enabled= true;

            
         
        }

        private void txtvalor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Por favor ingrese el valor que desea abonar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta habilitando la opcion para pagarle al empleado");
            dataGridView1.Enabled = true;
        }

        private void btnhabilitar1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta habilitando la opcion para abonarle al empleado");
            dataGridView2.Enabled = true;
        }

        private void fecha2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
