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
    public partial class lavado : Form
    {
        public lavado()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        int contador;
        int valor;
        public static string placa;
        public static string vehiculo;
        public static string tipo;
        public static string total;
        public static string fechalavado;
       
        
            private void lavado_Load(object sender, EventArgs e)
            {
            txtplaca.MaxLength = 50;
          
            txtplaca.Select();
            
             }

      
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            verificar_placa_lavado vpl = new verificar_placa_lavado();
            MySqlDataReader myReader;
            myReader = vpl.verificar(txtplaca.Text);
            if (myReader.Read())
            {
                lblplaca.Text = myReader.GetString(0);
                lblencargado.Text = myReader.GetString(1);
                lblIdentificacion.Text = myReader.GetString(2);
                lbltipo.Text = myReader.GetString(3);
                txttotal.Text = myReader.GetString(5);               
                lblencargado.Visible = true;
                lblplaca.Visible = true;
                lbltipo.Visible = true;
                txttotal.Visible = true;
                txttotal.Select();



            }
            else
            {
                MessageBox.Show("Placa NO registrada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtplaca.Clear();
                txtplaca.Select();
            }

            //VerificarEmpleado empl = new VerificarEmpleado();
            //MySqlDataReader myRe;
            //myRe = empl.verififacionlavador(Convert.ToDouble(lblIdentificacion.Text));
            //if (myRe.Read())

            //{
            //    txtvalorLiquidacion.Text = myReade.GetString(4);
            //}

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
         
           
        }

        private void txttotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;               
                return;
            }
            else
            {
               
            }
        }

        private void lbltipo_Click(object sender, EventArgs e)
        {

        }

        private void btncobrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txttotal.Text))
                {
                    MessageBox.Show("Por favor completar  los campos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txttotal.Select();
                    return;

                }
                else
           if (Convert.ToDouble(lblIdentificacion.Text) == 1082869353)
                {
                    try
                    {
                        ingresoventas igv = new ingresoventas();
                        fechalavado = Convert.ToString(dateTimePicker2.Value);
                        string usuario = Form1.variable;
                        //Ingresamos la venta
                        igv.Registrar_venta(contador, Convert.ToDateTime(dateTimePicker2.Value.Date), lblhora.Text, lblplaca.Text, 0, lbltipo.Text, "", "Lavadero", "Invitado", usuario, Convert.ToDouble(txttotal.Text));

                        //borramos la placa ingresada
                        borrar_ingreso_lavado bil = new borrar_ingreso_lavado();
                        bil.borrarplaca(lblplaca.Text);

                        total = txttotal.Text;
                        placa = lblplaca.Text;
                        vehiculo = lbltipo.Text;
                        tipo = "Lavadero";
                        impresion_lavado il = new impresion_lavado();
                        il.Show();
                        this.Close();
                        conexion.cerrarBD();
                    }
                    catch
                    {
                        MessageBox.Show("Por favor verifica que estes haciendo el procceso bien");
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(txttotal.Text))
                    {
                        MessageBox.Show("Por favor completar  los campos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txttotal.Select();
                        return;

                    }
                    else
                    {
                        Numerodeventa nm = new Numerodeventa();
                        MySqlDataReader myReader;
                        myReader = nm.ultimoregistro();
                        if (myReader.Read())
                        {
                            contador = Convert.ToInt32(myReader.GetInt32(0) + 1);

                        }
                        int ejm = 0;
                        if ((int.TryParse(txttotal.Text, out ejm)))
                        {
                            double valor1 = Convert.ToInt32(txttotal.Text);
                            valor = Convert.ToInt32(txttotal.Text) / 2;
                            string usuario = Form1.variable;

                            if (checkBox1.Checked == true)
                            {
                                lblEstado.Text = "Pendiente";
                                Ingreso_pendientes pendiente = new Ingreso_pendientes();
                                pendiente.Registrar_pendiente(Convert.ToDateTime(dateTimePicker2.Value), lblhora.Text, lblencargado.Text, lblplaca.Text, lbltipo.Text, lblEstado.Text, Convert.ToDouble(txttotal.Text));

                            }
                            else
                            {
                                ingresoventas igv = new ingresoventas();
                                fechalavado = Convert.ToString(dateTimePicker2.Value);
                                //Ingresamos la venta
                                igv.Registrar_venta(contador, Convert.ToDateTime(dateTimePicker2.Value.Date), lblhora.Text, lblplaca.Text, 0, lbltipo.Text, "", "Lavadero", "Invitado", usuario, valor1);
                            }



                            VerificarEmpleado empl = new VerificarEmpleado();
                            MySqlDataReader myRe;
                            myRe = empl.verififacionlavador(Convert.ToDouble(lblIdentificacion.Text));
                            if (myRe.Read())

                            {
                                txtvalorLiquidacion.Text = myRe.GetString(4);
                                int acomulador = Convert.ToInt32(txtvalorLiquidacion.Text) + valor;

                                VerificarEmpleado actualizar = new VerificarEmpleado();
                                actualizar.actualizarLiquidacion(acomulador, Convert.ToDouble(lblIdentificacion.Text));

                                //borramos la placa ingresada
                                borrar_ingreso_lavado bil = new borrar_ingreso_lavado();
                                bil.borrarplaca(lblplaca.Text);

                                total = txttotal.Text;
                                placa = lblplaca.Text;
                                vehiculo = lbltipo.Text;
                                tipo = "Lavadero";
                                impresion_lavado il = new impresion_lavado();
                                il.Show();
                                this.Close();

                            }
                            else
                            {
                                ingreso_ventas_lavador ivl = new ingreso_ventas_lavador();
                                //ingresamos los datos de la persona encargada del lavado
                                ivl.Registrarlavador(Convert.ToDateTime(dateTimePicker2.Value.Date), lblhora.Text, lblencargado.Text, Convert.ToInt32(lblIdentificacion.Text), valor);

                                //borramos la placa ingresada
                                borrar_ingreso_lavado bil = new borrar_ingreso_lavado();
                                bil.borrarplaca(lblplaca.Text);

                                total = txttotal.Text;
                                placa = lblplaca.Text;
                                vehiculo = lbltipo.Text;
                                tipo = "Lavadero";
                                impresion_lavado il = new impresion_lavado();
                                il.Show();
                                this.Close();
                            }
                            conexion.cerrarBD();

                        }
                        else
                        {

                            MessageBox.Show("Por favor ingresa solo numeros !", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txttotal.Clear();
                            txttotal.Select();

                        }
                    }
                }
            }
            catch
            {

            }
        }

        private void rbpendiente_MouseClick(object sender, MouseEventArgs e)
        {
            //string s = lbltipo.Text;
            //if (MessageBox.Show("se quede en el parqueadero " , "Desea que el " + s, MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{


            //    rbpendiente.Checked = true;


            //}

            //else

            //{

            //    rbpendiente.Checked = false;

            //}
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            string s = lbltipo.Text;
            if (MessageBox.Show("Se quede pendiente en el parqueadero ", "Desea que el " + s, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                checkBox1.Checked = true;
            }

            else
            {
                checkBox1.Checked = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
