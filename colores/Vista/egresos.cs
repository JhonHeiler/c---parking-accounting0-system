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
    public partial class egresos : Form
    {
        public static string nombreEmple;
        public static double cedulaEmple;
        public egresos()
        {
            InitializeComponent();
            timer1.Enabled = true;


           




        }
        int contador;

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
        }


        private void btncobrar_Click(object sender, EventArgs e)
        {
         

            Numerodeventa nm = new Numerodeventa();
            MySqlDataReader myReader;
            myReader = nm.ultimoregistro();
            if (myReader.Read())
            {
                contador = Convert.ToInt32(myReader.GetInt32(0) + 1);

            }          
            try
            {
                if (string.IsNullOrEmpty(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor ingresar la descripión !", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDescripcion.Focus();

                   
                }
                else
                {
                    string usuario = Form1.variable;
                    ingresoventas igv = new ingresoventas();
                    igv.Registrar_venta(contador, Convert.ToDateTime(dateTimePicker1.Value.Date), lblhora.Text, "", Convert.ToInt32(txtValor.Text), "Egreso", "", txtDescripcion.Text, "", usuario, 0);
                    MessageBox.Show("Dinero retirado de la caja correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.cerrarBD();
                }

                

            }
             catch (Exception error)
            {
                    MessageBox.Show("Por favor llene los campos correctamente " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                //MessageBox.Show("Por favor ingresar placa !", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //txtDescripcion.Focus();
                //return;

              this.Close();
           


        }


        private void btnAgregarPrestamos_Click(object sender, EventArgs e)
        {

            Ingresoprestamos prestamos = new Ingresoprestamos();

            VerificarEmpleado empl = new VerificarEmpleado();
            MySqlDataReader myReader;
            myReader = empl.verififacionEMPLEADO(Convert.ToDouble(txtCedula.Text));
            if (myReader.Read())

            {
                    txtNombreEpleado.Text = myReader.GetString(0);
                    string nombre = txtNombreEpleado.Text;

                    if (MessageBox.Show("Desea prestarle mas dinero", "El sistema registra que el empleado  !: " + nombre + "! cuenta con prestamo ", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        txtCedula.Text = myReader.GetString(1);
                        txtDeuda.Text = myReader.GetString(2);

                        double deuda = Convert.ToDouble(txtDeuda.Text) + Convert.ToDouble(txtValorEmpleado.Text);

                        VerificarEmpleado actualizar = new VerificarEmpleado();
                        actualizar.empleadocedula(deuda, Convert.ToDouble(txtCedula.Text));
             
                    //Disminuir el dinero de la caja por prestamo
                    string us = Form1.variable;
                    ingresoventas igv = new ingresoventas();
                    igv.Registrar_venta(contador, Convert.ToDateTime(dateTimePicker1.Value.Date), lblhora.Text, nombre, Convert.ToDouble(txtValorEmpleado.Text), "Egreso", "", "Prestamo", "Empleado", us, 0);

                    this.Close();

                    }

                else

                    {

                        MessageBox.Show("No se realizo el prestamo al empleado: " + nombre);
                        txtNombreEpleado.Clear();
                        txtCedula.Clear();
                        txtValorEmpleado.Clear();

                    }


                        //nombreEmple = txtNombreEpleado.Text;
                        //cedulaEmple =Convert.ToDouble(txtCedula.Text);

            }
            else
            {
                try
                {

                    if (string.IsNullOrEmpty(txtNombreEpleado.Text))
                {
                    MessageBox.Show("Por favor ingresar el nombre del empleado !", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNombreEpleado.Focus();

                }
                else
                {
                    prestamos.Registrar_prestamos(txtNombreEpleado.Text,Convert.ToDouble(txtCedula.Text), Convert.ToDouble(txtValorEmpleado.Text), Convert.ToDateTime(lblfecha.Text), lblhora.Text);
                    MessageBox.Show("Se realizo el prestamo al empleado correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                        //Disminuir el dinero de la caja por prestamo
                        string usuario = Form1.variable;
                        ingresoventas igv = new ingresoventas();
                        igv.Registrar_venta(contador, Convert.ToDateTime(dateTimePicker1.Value.Date), lblhora.Text, txtNombreEpleado.Text, Convert.ToDouble(txtValorEmpleado.Text), "Egreso", "", "Prestamo", "Empleado", usuario, 0);

                        conexion.cerrarBD();
                        this.Close();
                    }

                }
                catch (Exception error)
                {
                    MessageBox.Show("Por favor llene los campos correctamente " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

       private void txtValor_TextChanged(object sender, EventArgs e)
        {
            btncobrar.Enabled = true;
        }

        private void txtValorEmpleado_TextChanged(object sender, EventArgs e)
        {
           
            btnAgregarPrestamos.Enabled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void egresos_Load(object sender, EventArgs e)
        {

        }

        private void txtNombreEpleado_TextChanged(object sender, EventArgs e)
        {
            txtCedula.Enabled = true;
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            txtValor.Enabled = true;
        }

        private void txtNombreEpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
           

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValorEmpleado_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtApellidoEplea_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtApellidoEplea_TextChanged(object sender, EventArgs e)
        {

            txtValorEmpleado.Enabled = true;

        }

      
    }
        
}
