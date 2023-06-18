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
    public partial class Form1 : Form
    {
        string pass;
        public Form1()
        {
            InitializeComponent();
        }
        public static string variable;
        public static string cargo;
        public static string contra;

        public void siguiente()
        {
            try
            {

                conexion.AbrirBD();
                verificar_usuario user = new verificar_usuario();
                MySqlDataReader myReader;
                myReader = user.verificarusuario(txtescriba.Text);
                //verifico que el usuario ingrese numero en la cedula

                int ejm = 0;
                if (int.TryParse(txtescriba.Text, out ejm))
                {
                    if (myReader.Read())

                    {
                        lblusuario.Text = myReader.GetString(1);
                        lblusuario.Visible = true;
                        lblusuario.Location = new Point(80, 33);
                        lblmensaje.Text = "Contraseña :";
                        lblmensaje.Location = new Point(43, 83);
                        txtescriba.Clear();
                        txtescriba.Focus();
                        txtescriba.Location = new Point(149, 84);
                        txtescriba.UseSystemPasswordChar = true;
                        btniniciar.Visible = true;
                        btnsiguiente.Visible = false;
                        btnatras.Visible = true;
                        nombreprogram.Visible = false;

                        ckver.Visible = true;
                        variable = lblusuario.Text;

                        pass = myReader.GetString(2);
                        contra = pass;
                        cargo = myReader.GetString(3);


                    }
                    else
                    {
                        MessageBox.Show("Usuario no registrado", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtescriba.Clear();
                        txtescriba.Focus();
                    }
                }
                //Mensaje cuando el usuario en la cedula ingresa letras
                else
                {
                    MessageBox.Show("Ingrese su cedula !", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtescriba.Clear();
                    txtescriba.Focus();
                }
            }
            catch
            {

            }
        }

        //Activamos a que un suceso se active por medio de una tecla 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Enter)
            {
                if (btnsiguiente.Visible == false)
                {
                    iniciar();
                }
                else
                {
                    siguiente();
                }


            }


            return base.ProcessCmdKey(ref msg, keyData);

        }


        private void btnparqueadero_Click(object sender, EventArgs e)
        {
            Parqueadero_ingreso pi = new Parqueadero_ingreso();
            pi.Show();
        }

        private void btnlavado_Click(object sender, EventArgs e)
        {
            Ingreso_lavado ilv = new Ingreso_lavado();
            ilv.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtescriba.Focus();
            
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            siguiente();
        }

        private void btnatras_Click(object sender, EventArgs e)
        {
            btnatras.Visible = false;
            btnsiguiente.Visible = true;
            btniniciar.Visible = false;
            txtescriba.Focus();
            txtescriba.Clear();
            txtescriba.Location = new Point(149, 84);
            lblmensaje.Location = new Point(43, 83);
            lblusuario.Visible = false;
            txtescriba.UseSystemPasswordChar = false;
            lblmensaje.Text = "Cedula :";
            nombreprogram.Visible = true;

            ckver.Visible = false;
            btnsiguiente.Enabled = true;
        }
        public void iniciar()
        {

            //verificamos si lo inscrito por el usuario es igual a lo que tenemos en la BD
            if (string.Equals((pass.Trim()), txtescriba.Text.Trim()))
            {
                MessageBox.Show("Bienvenido al sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cargo == "Admi")
                {
                    menuStrip1.Visible = true;

                }
                else
                {
                    menuStrip1.Visible = true;
                    administradorToolStripMenuItem.Visible = false;
                    verToolStripMenuItem.Visible = true;

                }
                btnparqueadero.Visible = true;
                btnlavado.Visible = true; 

            /*  if (cargo == "Admi")
               {
                   btnclientes.Visible = true;
                   btnegresos.Location = new Point(139, 372);
               }
            else { btnclientes.Visible = false; }*/
               
                groupBox1.Visible = false;
                label1.Text = variable;
                label1.Visible = true;
                btnegresos.Visible = true;
                btnclientes.Visible = true;
                //btnegresos.Location = new Point(139, 372);

            }
            else
            {
                MessageBox.Show("Contraseña Incorrecta", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtescriba.Clear();
                txtescriba.Focus();

            }
           
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            
            iniciar();
            
        }

        private void ckver_CheckedChanged(object sender, EventArgs e)
        {
            //Activamos y desactivamos la contraseña
            if (ckver.Checked)
            {
                txtescriba.UseSystemPasswordChar = false;
            }
            else { txtescriba.UseSystemPasswordChar = true; }
        }

        private void nuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agg_usuarios ag_u = new Agg_usuarios();
            ag_u.Show();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detallesdeventa dv = new Detallesdeventa();
            dv.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clientes c = new clientes();
            c.Show();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            clientes c = new clientes();
            c.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            panel1.Visible = true;
            lblmensaje.Text = "Cedula :";
            btnparqueadero.Visible = false;
            btnlavado.Visible = false;
            btnegresos.Visible = false;
            btnclientes.Visible = false;
            label1.Visible = false;
            administradorToolStripMenuItem.Visible = true;
            btnatras.Visible = false;
            btniniciar.Visible = false;
            btnsiguiente.Visible = true;
            txtescriba.UseSystemPasswordChar = false;
            txtescriba.Focus();
            txtescriba.Clear();
            ckver.Visible = false;

        }

        private void reporteDeVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detallesdeventa dv = new Detallesdeventa();
            dv.Show();
        }

        private void vehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vehiculos_parqueadero vp = new vehiculos_parqueadero();
            vp.Show();
        }

        private void btnegresos_Click(object sender, EventArgs e)
        {
            egresos eg = new egresos();
            eg.Show();
        }

        private void liquidarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            liquidar_encargado lenc = new liquidar_encargado();
            lenc.Show();
        }

        private void carrosEnLavadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ver_ingreso_lavado vil = new ver_ingreso_lavado();
            vil.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtescriba_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pagosempleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalles_de_pagos_empleados pago = new Detalles_de_pagos_empleados();
            pago.Show();
        }

        private void vehiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vehiculos_parqueadero vp = new vehiculos_parqueadero();
            vp.Show();
        }

        private void pagosDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Detalles_de_pagos_empleados pago = new Detalles_de_pagos_empleados();
            pago.Show();
        }

        private void vehiculosPendienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vehiculos_pendientes vehiculo = new Vehiculos_pendientes();
            vehiculo.Show();
        }
    }
}
