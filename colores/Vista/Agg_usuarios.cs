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
    public partial class Agg_usuarios : Form
    {

        MySqlDataReader verificar;
        verificar_cedula user = new verificar_cedula();
        public Agg_usuarios()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            //Creacion de usuarios con condicion de si ya la cedula esta en la BD
            verificar = user.verificacedula(txtcedula_user.Text);


            //condicion para que el usuario llene todos los campos
            if (string.IsNullOrEmpty(txtcedula_user.Text) || string.IsNullOrEmpty(txtcontraseña_user.Text) || string.IsNullOrEmpty(txtnombre_user.Text))
            {
                MessageBox.Show("Por favor completar  los campos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            else
            {   //verifico que el usuario ingrese numero en la cedula
                int ejm = 0;
                if (int.TryParse(txtcedula_user.Text, out ejm))
                {

                    //Si la cedula ya fue inscrita no lo dejamos avanzar
                    if (verificar.Read())
                    {
                        MessageBox.Show("Usuario creado por favor intente de nuevo", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        txtcedula_user.Clear();
                        txtcontraseña_user.Clear();
                        txtnombre_user.Clear();
                        txtcedula_user.Focus();
                        Close();
                    }
                    else
                    {
                        //creamos el usuario
                        int i = Convert.ToInt32(txtcedula_user.Text);
                        string n = txtnombre_user.Text;
                        string c = txtcontraseña_user.Text.Trim();
                        string carg = "Cargo";

                        registrar_usuario ru = new registrar_usuario();
                        //Condicion del combobox
                        if (comboBox1.Text == "Administrador") { carg = "Admi"; }
                        else
                            if (comboBox1.Text == "Empleado") { carg = "cajero"; }
                        ru.Registrar(i, n, c, carg);
                        MessageBox.Show("Usuario creado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                        conexion.cerrarBD();
                    }
                }
                //Alerta por no escribir en cedula numeros
                else
                {
                    MessageBox.Show("Error, Ingresa solo numeros ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcedula_user.Clear();
                    txtcedula_user.Focus();
                }
               
            }
        
    }

        private void Agg_usuarios_Load(object sender, EventArgs e)
        {
            // El combobox se inicia en Administrador
            comboBox1.SelectedIndex = 0;
        }

        private void ckvercontra_CheckedChanged(object sender, EventArgs e)
        {
            if (ckvercontra.Checked)
            {
                txtcontraseña_user.UseSystemPasswordChar = false;
            }
            else { txtcontraseña_user.UseSystemPasswordChar = true; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtnombre_user_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtcedula_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcedula_user_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
