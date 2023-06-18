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
    public partial class Salida : Form
    {
        public static string total;
        public static int cantidadacobrar;
        public static int precio;
        public static int contador;
        public static string placa;
        public static string vehiculo;
        public static string fechaentrada;
        public static string tiempoacobrar;
        public static int totalxdia;
        private string valorpendiente;
        float dias;


        public Salida()
        {
            InitializeComponent();
            
        }

        private void Salida_Load(object sender, EventArgs e)
        {
            txtplaca.MaxLength = 6;
            Numerodeventa nm = new Numerodeventa();
            MySqlDataReader myReader;
            myReader = nm.ultimoregistro();
            if (myReader.Read())
            {
                lblcontador.Text = Convert.ToString(myReader.GetInt32(0) + 1);
                contador = Convert.ToInt32(lblcontador.Text);
            }
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            
               if (txtTotalOtros.Visible==true)
                    
               {
                try
                {
                    if (string.IsNullOrEmpty(txtTotalOtros.Text))
                    {
                        MessageBox.Show("Por favor ingresar el valor a cobrar !", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTotalOtros.Focus();

                    }
                    else
                    {

                        placa = txtplaca.Text;
                        tiempoacobrar = lbltiempoacobrar.Text;
                        total = lbltotal.Text;
                        string usuario = Form1.variable;
                        //Ingresamos los datos a la tabla ventas

                        total = txtTotalOtros.Text;
                        ingresoventas iv = new ingresoventas();
                        iv.Registrar_venta(Convert.ToInt32(lblcontador.Text), Convert.ToDateTime(dateTimePicker1.Value.Date), lblhorasalida.Text, txtplaca.Text, 0, lbltipo.Text, "", lblparque.Text, "Invitado", usuario, Convert.ToInt32(txtTotalOtros.Text));
                        /////----------------------------------------------------------///

                        borraringreso bi = new borraringreso();
                        //Borramos la plata de la tabla ingreso
                        bi.borrarplaca(txtplaca.Text);
                        ///-------------------------------------------
                        borraringreso pendiente = new borraringreso();
                        //Borramos la plata de la tabla ingreso
                        pendiente.borrarplacapendiente(txtplaca.Text);

                        impresion_salida_parqueadero ipsp = new impresion_salida_parqueadero();
                        ipsp.Show();

                        lblhorasalida.Visible = false;
                        lblhoraentrada.Visible = false;
                        txtplaca.Focus();

                        this.Close();
                    }
                    conexion.cerrarBD();
                }
                catch
                {

                }
               }
                else
                {

                try
                {

                    placa = txtplaca.Text;
                    tiempoacobrar = lbltiempoacobrar.Text;
                    total = lbltotal.Text;
                    string usuario = Form1.variable;
                    //Ingresamos los datos a la tabla ventas
                    btncobrar.Enabled = true;
                    ingresoventas iv = new ingresoventas();
                    iv.Registrar_venta(Convert.ToInt32(lblcontador.Text), Convert.ToDateTime(dateTimePicker1.Value.Date), lblhorasalida.Text, txtplaca.Text, 0, lbltipo.Text, "", lblparque.Text, "Invitado",
                    usuario, Convert.ToInt32(lbltotal.Text));


                    ////---------------------------------------------------///

                    borraringreso bi = new borraringreso();
                    //Borramos la plata de la tabla ingreso
                    bi.borrarplaca(txtplaca.Text);
                    ///-------------------------------------------
                    borraringreso pendiente = new borraringreso();
                    //Borramos la plata de la tabla ingreso
                    pendiente.borrarplacapendiente(txtplaca.Text);

                    impresion_salida_parqueadero ipsp = new impresion_salida_parqueadero();
                    ipsp.Show();

                    lblhorasalida.Visible = false;
                    lblhoraentrada.Visible = false;
                    txtplaca.Focus();

                    this.Close();
                    conexion.cerrarBD();
                }

                catch
                {
                    MessageBox.Show("Por favor ingrese a salida y retire 1000 pesos, para solucionar el error  ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                }
               
        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            Gestordesalida pendiente = new Gestordesalida();
            MySqlDataReader myRead;
            myRead = pendiente.verificarplacapendiente(txtplaca.Text);



            // vehiculo en parqueo
            Gestordesalida gs = new Gestordesalida();
            MySqlDataReader myReader;
            myReader = gs.verificarplaca(txtplaca.Text);

            if (myRead.Read())
            {



                lblhoraentrada.Visible = true;
                lblhorasalida.Visible = true;

                lbltiempoacobrar.Visible = true;
                lblfecha.Visible = true;
                lblhoraentrada.Text = myRead.GetString(1);

                DateTime horaentrada = Convert.ToDateTime(lblhoraentrada.Text);
                int totaldehoras = horaentrada.Hour;
                //MessageBox.Show(Convert.ToString(totaldehoras), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vehiculo = myRead.GetString(4).Trim();
                //lbltipo.Text = myReader.GetString(3);
                fechaentrada = myRead.GetString(0);
                //MessageBox.Show(Convert.ToString(vehiculo), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //verificamos el precio por tipo de vehiculo y lo guardamos en la variable precio
                precioporhora pph = new precioporhora();


                lblhorasalida.Text = DateTime.Now.ToString("HH:mm:ss");
                lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                //dias
                DateTime fentrada = Convert.ToDateTime(fechaentrada);
                //MessageBox.Show(Convert.ToString( fentrada), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DateTime fsalida = dateTimePicker1.Value;



                //es esta variable tenemos los dias que se quedo en el parqueadero

                //MessageBox.Show(Convert.ToString(dias), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Horas
                DateTime entrada = fentrada;
                DateTime salida = fsalida;
                TimeSpan span = salida.Subtract(entrada);



                lbltiempoacobrar.Text = Convert.ToString(span);
                //lbltiempoacobrar.Text = Convert.ToString(span).Split('.')[0];
                //MessageBox.Show(Convert.ToString(span), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int prueba = Convert.ToInt32(span.TotalDays);
                int prueba1 = Convert.ToInt32(span.TotalMinutes);
                //dias = span.Days;
                valorpendiente = myRead.GetString(6);
               
                // Aqui definimos cuantos cobramos dependiendo del vehiculo


                ///-------------------------------------------------------------otros procesos
                if (vehiculo == "Motocicleta".Trim())
                {
                    int total;
                    int total1;
                    int total2;
                    lbltotal.Visible = true;
                    btncobrar.Enabled = true;
                    if (Convert.ToDouble(prueba1) > 299 && Convert.ToDouble(prueba1) <1739)
                    {
                      total = 2000 + Convert.ToInt32(valorpendiente);

                       lbltotal.Text = Convert.ToString(total);
                    }
                    else if(Convert.ToDouble(prueba1) > 1739)
                    {

                        total1 = prueba * 2000;
                        total2= 2000 + Convert.ToInt32(valorpendiente);
                        int suma = total1 + total2;
                        lbltotal.Text = Convert.ToString(suma);


                    }
                    else
                    {
                        lbltotal.Text = valorpendiente;
                    }
                }
              else  if (vehiculo == "Bicicleta".Trim())
                {
                    int total;
                    int total1;
                    int total2;
                    lbltotal.Visible = true;
                    btncobrar.Enabled = true;
                    if (Convert.ToDouble(prueba1) > 299 && Convert.ToDouble(prueba1) < 1739)
                    {
                        total = 2000 + Convert.ToInt32(valorpendiente);

                        lbltotal.Text = Convert.ToString(total);
                    }
                    else if (Convert.ToDouble(prueba1) > 1739)
                    {

                        total1 = prueba * 2000;
                        total2 = 2000 + Convert.ToInt32(valorpendiente);
                        int suma = total1 + total2;
                        lbltotal.Text = Convert.ToString(suma);


                    }
                    else
                    {
                        lbltotal.Text = valorpendiente;
                    }
                }
                else if (vehiculo == "Automovil".Trim())
                {
                    int total;
                    int total1;
                    int total2;
                    lbltotal.Visible = true;
                    btncobrar.Enabled = true;
                    if (Convert.ToDouble(prueba1) > 299 && Convert.ToDouble(prueba1) < 1739)
                    {
                        total = 6000 + Convert.ToInt32(valorpendiente);

                        lbltotal.Text = Convert.ToString(total);
                    }
                    else if (Convert.ToDouble(prueba1) > 1739)
                    {

                        total1 = prueba * 6000;
                        total2 = 6000 + Convert.ToInt32(valorpendiente);
                        int suma = total1 + total2;
                        lbltotal.Text = Convert.ToString(suma);


                    }
                    else
                    {
                        lbltotal.Text = valorpendiente;
                    }
                }

                else if (vehiculo == "Camionetas".Trim())
                {

                    int total;
                    int total1;
                    int total2;
                    lbltotal.Visible = true;
                    btncobrar.Enabled = true;
                    if (Convert.ToDouble(prueba1) > 299 && Convert.ToDouble(prueba1) < 1739)
                    {
                        total = 6000 + Convert.ToInt32(valorpendiente);

                        lbltotal.Text = Convert.ToString(total);
                    }
                    else if (Convert.ToDouble(prueba1) > 1739)
                    {

                        total1 = prueba * 6000;
                        total2 = 6000 + Convert.ToInt32(valorpendiente);
                        int suma = total1 + total2;
                        lbltotal.Text = Convert.ToString(suma);


                    }
                    else
                    {
                        lbltotal.Text = valorpendiente;
                    }

                }

                else if (vehiculo == "Taxis".Trim())
                {

                    int total;
                    int total1;
                    int total2;
                    lbltotal.Visible = true;
                    btncobrar.Enabled = true;
                    if (Convert.ToDouble(prueba1) > 299 && Convert.ToDouble(prueba1) < 1739)
                    {
                        total = 6000 + Convert.ToInt32(valorpendiente);

                        lbltotal.Text = Convert.ToString(total);
                    }
                    else if (Convert.ToDouble(prueba1) > 1739)
                    {

                        total1 = prueba * 6000;
                        total2 = 6000 + Convert.ToInt32(valorpendiente);
                        int suma = total1 + total2;
                        lbltotal.Text = Convert.ToString(suma);


                    }
                    else
                    {
                        lbltotal.Text = valorpendiente;
                    }
                }
                else if (vehiculo == "Camperos Vans".Trim())
                {

                    int total;
                    int total1;
                    int total2;
                    lbltotal.Visible = true;
                    btncobrar.Enabled = true;
                    if (Convert.ToDouble(prueba1) > 299 && Convert.ToDouble(prueba1) < 1739)
                    {
                        total = 6000 + Convert.ToInt32(valorpendiente);

                        lbltotal.Text = Convert.ToString(total);
                    }
                    else if (Convert.ToDouble(prueba1) > 1739)
                    {

                        total1 = prueba * 6000;
                        total2 = 6000 + Convert.ToInt32(valorpendiente);
                        int suma = total1 + total2;
                        lbltotal.Text = Convert.ToString(suma);


                    }
                    else
                    {
                        lbltotal.Text = valorpendiente;
                    }
                }
                else if (vehiculo == "Mini vans".Trim())
                {
                    int total;
                    int total1;
                    int total2;
                    lbltotal.Visible = true;
                    btncobrar.Enabled = true;

                    if (Convert.ToDouble(prueba1) > 299 && Convert.ToDouble(prueba1) < 1739)
                    {
                        total = 6000 + Convert.ToInt32(valorpendiente);

                        lbltotal.Text = Convert.ToString(total);
                    }
                    else if (Convert.ToDouble(prueba1) > 1739)
                    {

                        total1 = prueba * 6000;
                        total2 = 6000 + Convert.ToInt32(valorpendiente);
                        int suma = total1 + total2;
                        lbltotal.Text = Convert.ToString(suma);


                    }
                    else
                    {
                        lbltotal.Text = valorpendiente;
                    }

                }
                else if (vehiculo == "Moto carro".Trim())
                {
                    int total;
                    int total1;
                    int total2;
                    lbltotal.Visible = true;
                    btncobrar.Enabled = true;
                    if (Convert.ToDouble(prueba1) > 299 && Convert.ToDouble(prueba1) < 1739)
                    {
                        total = 4000 + Convert.ToInt32(valorpendiente);

                        lbltotal.Text = Convert.ToString(total);
                    }
                    else if (Convert.ToDouble(prueba1) > 1739)
                    {

                        total1 = prueba * 4000;
                        total2 = 4000 + Convert.ToInt32(valorpendiente);
                        int suma = total1 + total2;
                        lbltotal.Text = Convert.ToString(suma);


                    }
                    else
                    {
                        lbltotal.Text = valorpendiente;
                    }
                }
                else
                {
                    btncobrar.Enabled = false;
                    txtTotalOtros.Visible = true;
                }

                conexion.cerrarBD();
            }
            else

            // vehiculo en parqueo

            if (myReader.Read())
            {


               
                lblhoraentrada.Visible = true;
                lblhorasalida.Visible = true;
               
                lbltiempoacobrar.Visible = true;
                lblfecha.Visible = true;
                lblhoraentrada.Text = myReader.GetString(1);
                
                DateTime horaentrada = Convert.ToDateTime(lblhoraentrada.Text);
                int totaldehoras = horaentrada.Hour;
                //MessageBox.Show(Convert.ToString(totaldehoras), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                vehiculo = myReader.GetString(3).Trim(); 
                //lbltipo.Text = myReader.GetString(3);
                fechaentrada = myReader.GetString(0);
                //MessageBox.Show(Convert.ToString(vehiculo), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //verificamos el precio por tipo de vehiculo y lo guardamos en la variable precio
                precioporhora pph = new precioporhora();


                lblhorasalida.Text = DateTime.Now.ToString("HH:mm:ss");
                lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                //dias
                DateTime fentrada = Convert.ToDateTime(fechaentrada);
                //MessageBox.Show(Convert.ToString( fentrada), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DateTime fsalida = dateTimePicker1.Value;
               
               
                
                //es esta variable tenemos los dias que se quedo en el parqueadero

                //MessageBox.Show(Convert.ToString(dias), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Horas
                DateTime entrada = fentrada;
                DateTime salida = fsalida;
                TimeSpan span = salida.Subtract(entrada);
                
              
              
                //lbltiempoacobrar.Text =Convert.ToString(span).Split('.')[0];
          
                int prueba = Convert.ToInt32(span.TotalDays);
                //int prueba1 = Convert.ToInt32(span.TotalMinutes);
                //dias = span.Days;

                // Aqui definimos cuantos cobramos dependiendo del vehiculo


                ///-------------------------------------------------------------otros procesos
                if (vehiculo == "Motocicleta".Trim())
                {
                    lbltotal.Visible = true;
                    btncobrar.Enabled = true;
                    if (Convert.ToDouble(prueba) > 1)
                    {
                        lbltotal.Text = Convert.ToString(prueba* 2000);

                    }
                    else
                    {
                        lbltotal.Text = "2000";
                       
                    }
                }
                else if (vehiculo == "Automovil".Trim())
                {

                    btncobrar.Enabled = true;
                    lbltotal.Visible = true;
                    if (Convert.ToDouble(prueba) > 0)
                    {
                        lbltotal.Text = Convert.ToString(prueba * 6000);
                    }
                    else
                    {
                        lbltotal.Text = "6000";

                    }
                }

               else if (vehiculo == "Camionetas".Trim())
                {

                    btncobrar.Enabled = true;
                    lbltotal.Visible = true;
                    if (Convert.ToDouble(prueba) > 0)
                    {
                        lbltotal.Text = Convert.ToString(prueba * 6000);
                    }
                    else
                    {
                        lbltotal.Text = "6000";

                    }
                }

               else if (vehiculo == "Taxis".Trim())
                {

                    btncobrar.Enabled = true;
                    lbltotal.Visible = true;
                    if (Convert.ToDouble(prueba) > 0)
                    {
                        lbltotal.Text = Convert.ToString(prueba * 6000);
                       
                    }
                    else
                    {
                        lbltotal.Text = "6000";

                    }
                }
                else if (vehiculo == "Camperos Vans".Trim())
                {

                    btncobrar.Enabled = true;
                    lbltotal.Visible = true;
                    if (Convert.ToDouble(prueba) > 0)
                    {
                        lbltotal.Text = Convert.ToString(prueba * 6000);
                    }
                    else
                    {
                        lbltotal.Text = "6000";

                    }
                }
                else if (vehiculo == "Mini vans".Trim())
                {

                    btncobrar.Enabled = true;
                    lbltotal.Visible = true;
                    if (Convert.ToDouble(prueba) > 0)
                    {
                        lbltotal.Text = Convert.ToString(prueba * 6000);
                    }
                    else
                    {
                        lbltotal.Text = "6000";

                    }
                }
                else if (vehiculo == "Moto carro".Trim())
                {

                    btncobrar.Enabled = true;
                    lbltotal.Visible = true;
                    if (Convert.ToDouble(prueba) > 0)
                    {
                        lbltotal.Text = Convert.ToString(prueba * 4000);

                    }
                    else
                    {
                        lbltotal.Text = "4000";
                        txtTotalOtros.Visible = false;

                    }
                }
                else 
                {
                    btncobrar.Enabled = false;
                    txtTotalOtros.Visible = true;
                }

                conexion.cerrarBD();
            }
            else
            {
                MessageBox.Show("Placa no encontrada", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtplaca.Clear();
                txtplaca.Focus();
            }



            }

        private void txtTotalOtros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten numero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTotalOtros_TextChanged(object sender, EventArgs e)
        {
            btncobrar.Enabled = true;
        }
    }

        
    
}
