using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace colores
{
    public partial class pagos_por_cliente : Form
    {
        public pagos_por_cliente()
        {
            InitializeComponent();
        }
        string cliente = clientes.NIT;
        private void pagos_por_cliente_Load(object sender, EventArgs e)
        {
            flitro_pagos_realizados fpr = new flitro_pagos_realizados();
            DataTable dt = new DataTable();
            dt.Load(fpr.pagos_realizados(cliente));
            dataGridView1.DataSource = dt;
            conexion.cerrarBD();
        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            try
            {
               
            //Mostramos lo que tiene la tabla ventas
            DsReports ds = new DsReports();
            int filas = dataGridView1.Rows.Count;

            for (int i = 0; i <= filas - 2; i++)
            {
                ds.Tables[0].Rows.Add
                    (new object[] { dataGridView1[ 0,i].Value.ToString(),
                    dataGridView1[ 1,i].Value.ToString(),
                    dataGridView1[ 2,i].Value.ToString(),
                    dataGridView1[ 3,i].Value.ToString(),
                    dataGridView1[ 4,i].Value.ToString(),
                    dataGridView1[ 5,i].Value.ToString(),
                    dataGridView1[ 6,i].Value.ToString(),
                    dataGridView1[ 7,i].Value.ToString(),
                    dataGridView1[ 8,i].Value.ToString(),




                    });
            }
          
            
            }
            catch (Exception error)
            {
                MessageBox.Show("No se puede ver el reporte. Llame al encargado del programa." + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }
        }

    }
}
