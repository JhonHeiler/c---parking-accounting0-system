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
    public partial class Ingreso_lavado : Form
    {
        public Ingreso_lavado()
        {
            InitializeComponent();
            timer1.Enabled = true;
            txttipovehiculo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(txtplaca.Text))
            {
                MessageBox.Show("Por favor ingresa la placa", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtplaca.Select();

              
                return;



            }
            else
            {

                //Cada vez que el usuario selecciones un campo del combobox
                //preciolavada pl = new preciolavada();
                //MySqlDataReader myReader;
                if (comboBox1.Text == "Solo agua")
                {
                    label6.Visible = false;
                    lblidentificacion.Visible = false;
                    txtencargado.Visible = false;
                    txtIdentificacion.Visible = false;
            
                    panel4vehiculo.Location = new Point(30, 50);
                    txttipovehiculo.Visible = true;
                    lblplaca.Text = txtplaca.Text;
                    lblplaca.Visible = true;

                    label2.Visible = true;
                    label3.Visible = true;
                    txttotal.Visible = true;
                    label4.Visible = true;
                    lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
                    lblfecha.Visible = true;
                    lblhora.Visible = true;
                    btncobrar.Enabled = true;
                  
                    txtIdentificacion.Visible = false;
                  
               
                    panel4vehiculo.Visible = true;
                }
                else { 
                   
                    txttipovehiculo.Visible = true;
                    lblplaca.Text = txtplaca.Text;
                    lblplaca.Visible = true;

                    label2.Visible = true;
                    label3.Visible = true;
                    txttotal.Visible = true;
                    label4.Visible = true;
                    lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
                    lblfecha.Visible = true;
                    lblhora.Visible = true;
                    btncobrar.Enabled = true;
                    label6.Visible = true;
                    txtencargado.Visible = true;
                    txtencargado.Select();
                    txtIdentificacion.Visible = true;
                    lblidentificacion.Visible = true;
                    panel3Personal.Visible = true;
                
                    panel4vehiculo.Visible = true;
                }
            }
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtplaca.Text) || string.IsNullOrEmpty(txttotal.Text))
                {
                    MessageBox.Show("Por favor llenar todos los campos!!", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;

                }
                else
                {
                    verificar_placa_lavado vpl = new verificar_placa_lavado();
                    MySqlDataReader myReader;
                    myReader = vpl.verificar(lblplaca.Text);
                    if (myReader.Read())
                    {
                        MessageBox.Show("Placa ya ingresada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtplaca.Select();



                    }
                    else
                    {
                        //if (comboBox1.Text != "Solo agua")
                        //{

                        //}
                        //else
                        //{
                        int ejm = 0;
                        if ((int.TryParse(txttotal.Text, out ejm)))
                        {
                            if (comboBox1.Text == "Solo agua")
                            {
                                try
                                {
                                    double agua = Convert.ToDouble(txttotal.Text);
                                    registrar_ingreso_lavado sinlavador = new registrar_ingreso_lavado();
                                    sinlavador.Registrarlavador(lblplaca.Text, "Parqueadero-solo agua", 1082869353, txttipovehiculo.Text, dateTimePicker1.Value, agua, comboBox1.Text);
                                    MessageBox.Show("Vehiculo ingresado al lavadero correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Close();
                                    conexion.cerrarBD();
                                }
                                catch
                                {

                                }
                            }
                            else
                            {

                                if (string.IsNullOrEmpty(txtencargado.Text))
                                {
                                    MessageBox.Show("Por favor ingrese nombre del encargado del lavado", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    txtencargado.Select();
                                    return;

                                }
                                else if (string.IsNullOrEmpty(txtIdentificacion.Text))
                                {
                                    MessageBox.Show("Por favor ingrese el numero de documento del encargado de lavar el vehiculo", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    txtIdentificacion.Focus();
                                    return;
                                }
                                else
                                {
                                    registrar_ingreso_lavado ril = new registrar_ingreso_lavado();
                                    ril.Registrarlavador(lblplaca.Text, txtencargado.Text, Convert.ToDouble(txtIdentificacion.Text), txttipovehiculo.Text, dateTimePicker1.Value, Convert.ToDouble(txttotal.Text), comboBox1.Text);
                                    MessageBox.Show("Vehiculo ingresado al lavadero correctamente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Close();
                                    conexion.cerrarBD();
                                }
                            }

                        }
                        else
                        {
                            MessageBox.Show("Solo ingresar numeros !", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txttotal.Select();
                        }
                        //}
                    }
                }
            }
            catch
            {
                MessageBox.Show("Verifique intente nuevamente  ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
           
        }

        private void Ingreso_lavado_Load(object sender, EventArgs e)
        {
            txtplaca.Select();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            lavado lva = new lavado();
            lva.Show();
            Close();
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            btnregistrar.Enabled = false;
        }

        private void txtencargado_KeyPress(object sender, KeyPressEventArgs e)
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
        }

        private void txtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Por favor ingrese el documento identificacion del lavador del vehiculo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
