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
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public static string NIT;
        public static string Nombre;
        public static string Tipo;

        private void btnagregar_Click(object sender, EventArgs e)
        {
            agregarcliente();
        }
        public void agregarcliente()
        {
            MySqlDataReader verificar;
            //condicion para que el usuario llene todos los campos
            if (string.IsNullOrEmpty(txtNIT.Text) || string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Por favor completar  los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNIT.Select();
                return;

            }
            else
            {
                verificar_cliente vc = new verificar_cliente();
                verificar = vc.verificacliente(txtNIT.Text);
                //Si la cedula ya fue inscrita no lo dejamos avanzar
                if (verificar.Read())
                {
                    MessageBox.Show("Usuario YA creado por favor intente de nuevo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    limpiar();

                }
                else
                {
                    Agg_cliente aggc = new Agg_cliente();
                    //creamos el cliente
                    aggc.Registrar_cliente(txtNIT.Text, txtnombre.Text, txttelefono.Text, txtcelular.Text, txtdireccion.Text,
                         txtcorreo.Text, txtdia.Text, comboBox2.Text, txtcomentario.Text);
                    MessageBox.Show("Cliente creado con exito!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conexion.cerrarBD();
                    limpiar();
                    txtNIT.Enabled = false;
                    txtcelular.Enabled = false;

                    txtcomentario.Enabled = false;
                    txtcorreo.Enabled = false;

                    txtdireccion.Enabled = false;
                    txtdia.Enabled = false;
                    txtnombre.Enabled = false;
                    comboBox2.Enabled = false;
                    txttelefono.Enabled = false;

                }
            }
        }
        public void limpiar()
        {
            txtbuscar.Clear();
            txtNIT.Clear();
            txtcelular.Clear();
            txtcomentario.Clear();
            txtcorreo.Clear();
            txtdireccion.Clear();
            txtdia.Clear();
            txtnombre.Clear();
            txttelefono.Clear();
            txtNIT.Select();
        }

        private void btntocar_Click(object sender, EventArgs e)
        {
            txtNIT.Enabled = true;
            txtcelular.Enabled = true;
            txtcomentario.Enabled = true;
            txtcorreo.Enabled = true;
            txtdireccion.Enabled = true;
            txtdia.Enabled = true;
            txtnombre.Enabled = true;
            comboBox2.Enabled = true;
            txttelefono.Enabled = true;
            txtNIT.Focus();
        }
        public void buscar()
        {
            if (comboBox1.Text == "Placa/cedula")
            {
                buscar_placa_cedula gc = new buscar_placa_cedula();
                DataTable dt = new DataTable();
                dt.Load(gc.buscarNIT(txtbuscar.Text));
                dataGridView1.DataSource = dt;
            }
            if (comboBox1.Text == "Nombre")
            {
                buscar_nombre_cliente bnc = new buscar_nombre_cliente();
                DataTable dt = new DataTable();
                dt.Load(bnc.buscarnombre(txtbuscar.Text));
                dataGridView1.DataSource = dt;
            }


        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscar();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.Enter)
            {
                buscar();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 1;
            txtbuscar.Select();
            lblcargo.Text = Form1.cargo;
            if (lblcargo.Text == "Admi")
            {
                btneditar.Visible = true;
                btneliminar.Visible = true;

            }
            else {
                btneditar.Visible = false;
                btneliminar.Visible = false;
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Cuando de click en el datagrid se llenaran los campos en el formulario
            DataGridView gridView = (sender as DataGridView);
            DataGridViewRow row = gridView.Rows[e.RowIndex];
            txtNIT.Text = row.Cells[0].Value.ToString();
            txtnombre.Text = row.Cells[1].Value.ToString();
            txttelefono.Text = row.Cells[2].Value.ToString();
            txtcelular.Text = row.Cells[3].Value.ToString();
            txtdireccion.Text = row.Cells[4].Value.ToString();
            txtcorreo.Text = row.Cells[5].Value.ToString();
            txtdia.Text = row.Cells[6].Value.ToString();
            comboBox2.Text = row.Cells[7].Value.ToString();
            txtcomentario.Text = row.Cells[8].Value.ToString();
            btneditar.Enabled = true;
            btneliminar.Enabled = true;
            btnpago.Enabled = true;
            btnpagos.Enabled = true;
            NIT = txtNIT.Text;
            Nombre = txtnombre.Text;
            Tipo = comboBox2.Text;
        }
        public void editar()
        {
            //Condicionamos para que el usuario llene los campos obligatorios
            if (string.IsNullOrEmpty(txtNIT.Text))
            {
                MessageBox.Show("Por favor completar  los campos", "alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;

            }
            else
            {
                //verificamos si el usuario si deasea editar
                DialogResult result = MessageBox.Show("Seguro que quiere editar este cliente  ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    editar_cliente edc = new editar_cliente();
                    edc.Actualizarcliente(txtNIT.Text, txtnombre.Text, txttelefono.Text, txtcelular.Text, txtdireccion.Text, txtcorreo.Text, txtdia.Text, comboBox2.Text, txtcomentario.Text);
                    MessageBox.Show("Cliente Actualizado correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    limpiar();
                }
                
            }
        }
        public void eliminar()
        {
            //verificamos si el usuario si deasea eliminar
            DialogResult result = MessageBox.Show("Seguro que quiere eliminar este cliente  ?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                eliminar_cliente ec = new eliminar_cliente();
                ec.borrarcliente(txtNIT.Text);
                MessageBox.Show("Cliente Eliminado correctamente ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();

            }
            else if (result == DialogResult.No)
            {
                limpiar();
            }
        }
            private void btneditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnpago_Click(object sender, EventArgs e)
        {
            mensualidades ms = new mensualidades();
            ms.Show();
            Close();
        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            pagos_por_cliente ppc = new pagos_por_cliente();
            ppc.Show();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
