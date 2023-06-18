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
    public partial class Parqueadero_ingreso : Form
    {
        public static string placa;
        public static string tipo;


        public Parqueadero_ingreso()
        {
            InitializeComponent();
            timer1.Enabled = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        
        private void Parqueadero_ingreso_Load(object sender, EventArgs e)
        {
          
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");

            txtplaca.MaxLength = 50;


        }


        private void btnactivar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtplaca.Text))
            {
                MessageBox.Show("Por favor ingresar placa !", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtplaca.Focus();
                return;

            }
            else if (comboBox1.Text == "Otros")
            {
                if (string.IsNullOrEmpty(txtOtroVehiculo.Text))
                {
                    MessageBox.Show("Por favor ingresar  vehiculo !", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOtroVehiculo.Focus();
                    return;

                }
                else {
                lbltipo.Text = txtOtroVehiculo.Text.Trim();
                lblplaca.Text = txtplaca.Text;
                txtplaca.Clear();
                label2.Visible = true;
                label4.Visible = true;
                lblplaca.Visible = true;
                lbltipo.Visible = true;
                btnconfirmar.Visible = true;
                btncancelar.Visible = true;
                }
            }
            else
            {
                lbltipo.Text = comboBox1.Text.Trim(); ;
                lblplaca.Text = txtplaca.Text;
                txtplaca.Clear();
                label2.Visible = true;
                label4.Visible = true;
                lblplaca.Visible = true;
                lbltipo.Visible = true;
                btnconfirmar.Visible = true;
                btncancelar.Visible = true;
            }

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label4.Visible = false;
            lblplaca.Visible = false;
            lbltipo.Visible = false;
            btnconfirmar.Visible = false;
            btncancelar.Visible = false;
            txtplaca.Focus();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Otros")
            {
                comboBox1.Visible = false;
                label3.Text = "Ingrese el vehiculo";
                txtOtroVehiculo.Visible = true;
               
                txtplaca.Enabled = true;

                txtOtroVehiculo.Select();
            }
            else {
            txtplaca.Enabled = true;
            txtplaca.Focus();
            }


        }
       
        private void txtplaca_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            Salida sali = new Salida();
            sali.Show();
            Close();
            


        }
       

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = Form1.variable;
                gestordeingreso gi = new gestordeingreso();
                verificarplaca vp = new verificarplaca();
                MySqlDataReader myReader;
                myReader = vp.verificar(lblplaca.Text);
                if (myReader.Read())
                {
                    MessageBox.Show("Placa ya ingresada!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    label2.Visible = false;
                    label4.Visible = false;
                    lblplaca.Visible = false;
                    lbltipo.Visible = false;
                    btnconfirmar.Visible = false;
                    btncancelar.Visible = false;
                    txtplaca.Focus();


                }
                else
                {
                    gi.Registrar(Convert.ToDateTime(dateTimePicker1.Value), lblhora.Text, lblplaca.Text, lbltipo.Text.Trim(), usuario);
                    placa = lblplaca.Text;
                    //MessageBox.Show(Convert.ToString(Convert.ToDateTime(dateTimePicker1.Value.Date)), "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tipo = lbltipo.Text.Trim();
                    Registrar r = new Registrar();
                    r.Registrar_ingreso();
                    borrar_temporal bt = new borrar_temporal();
                    bt.borrar();
                    impresion im = new impresion();
                    im.Show();
                    this.Close();
                    conexion.cerrarBD();
                    /* DialogResult result= MessageBox.Show("Desea hacer nueva venta ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                      if (result == DialogResult.Yes)
                      {
                          Registrar r = new Registrar();
                          r.Registrar_ingreso();
                          borrar_temporal bt = new borrar_temporal();
                          bt.borrar();
                          impresion im = new impresion();
                          im.Show();
                          this.Close();

                      }
                      else if (result == DialogResult.No)
                      {
                          borrar_temporal bt = new borrar_temporal();
                          bt.borrar();
                          impresion im = new impresion();
                          im.Show();
                          this.Close();
                      }*/
                    label2.Visible = false;
                    label4.Visible = false;
                    lblplaca.Visible = false;
                    lbltipo.Visible = false;
                    btnconfirmar.Visible = false;
                    btncancelar.Visible = false;
                    txtplaca.Focus();

                }
            }
            catch
            {

            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void txtOtroVehiculo_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
