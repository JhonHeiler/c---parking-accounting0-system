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
    public partial class mensualidades : Form
    {
        public mensualidades()
        {
            InitializeComponent();
            timer1.Enabled = true;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        int contador;
        public static string total;
        public static string tiempo;
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btncobrar.Enabled = true;
        }

        private void mensualidades_Load(object sender, EventArgs e)
        {
            lblplaca.Text = clientes.NIT;
            lblnombre.Text = clientes.Nombre;
            lbltipo.Text = clientes.Tipo;
            lblplaca.Visible = true;
            lblnombre.Visible = true;
            lbltipo.Visible = true;
            txttotal.Select();
        }

        private void btncobrar_Click(object sender, EventArgs e)
        {
            try
            {

                Numerodeventa nm = new Numerodeventa();
                MySqlDataReader myReader;
                myReader = nm.ultimoregistro();
                if (myReader.Read())
                {
                    contador = Convert.ToInt32(myReader.GetInt32(0) + 1);

                }
                if (string.IsNullOrEmpty(comboBox1.Text))
                {
                    MessageBox.Show("Por favor seleccione mes a pagar", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {
                    string usuario = Form1.variable;
                    ingresoventas igv = new ingresoventas();
                    igv.Registrar_venta(contador, Convert.ToDateTime(dateTimePicker1.Value.Date), lblhora.Text, lblplaca.Text, 0, "Mensualidad", comboBox1.Text, lbltipo.Text, lblplaca.Text, usuario, Convert.ToInt32(txttotal.Text));
                    //MessageBox.Show("Datos ingresados correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    total = txttotal.Text;
                    tiempo = comboBox1.Text;
                    Impresion_mensualidad im = new Impresion_mensualidad();
                    im.Show();
                    this.Close();
                }

            }
            catch
            {

            }
        }


        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            btncobrar.Enabled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
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
    }
}
