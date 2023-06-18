using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using MySql.Data.MySqlClient;
//using System.Drawing;
using System.Drawing.Printing;


namespace colores
{
    public partial class impresion : Form
    {
        private Button btImprimir;
        //private Button btVistaPrevia;
        private PrintDocument DocumentoParaImprimir = new PrintDocument();
        private PrintDialog Impresora = new PrintDialog();
        private PrintPreviewDialog VistaPrevia = new PrintPreviewDialog();
        private Bitmap bmp;
        public impresion()
        {
            InitializeComponent();
            this.btImprimir = new System.Windows.Forms.Button();
            this.btImprimir.Location = new System.Drawing.Point(30, 20);
            this.btImprimir.Size = new System.Drawing.Size(100, 30);
            this.btImprimir.Text = "Imprimir";
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            //this.Controls.Add(this.btImprimir);

           /* this.btVistaPrevia = new System.Windows.Forms.Button();
            this.btVistaPrevia.Location = new System.Drawing.Point(20, 60);
            this.btVistaPrevia.Size = new System.Drawing.Size(100, 30);
            this.btVistaPrevia.Text = "Vista Previa";
            this.btVistaPrevia.Click += new System.EventHandler(this.btVistaPrevia_Click);
            this.Controls.Add(this.btVistaPrevia);*/

            DocumentoParaImprimir.PrintPage +=
                new PrintPageEventHandler(DocumentoParaImprimir_PrintPage);

        }

        private void impresion_Load(object sender, EventArgs e)
        {
           /* string contador;
            Numerodeventa nm = new Numerodeventa();
            MySqlDataReader myReader;
            myReader = nm.ultimoregistro();
            if (myReader.Read())
            {
                contador = myReader.GetString(0);
                lblregistro.Text = contador;

            }*/

            lblplaca.Text = Parqueadero_ingreso.placa;
            lblticket.Text = Parqueadero_ingreso.tipo;
            BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
            Codigo.IncludeLabel = true;
            //panel1.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, "*" + lblplaca.Text + "*", Color.Black, Color.White, 400, 100);
            lblfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblhora.Text = DateTime.Now.ToString("HH:mm:ss");
            //lblcajero.Text = Form1.variable;
            
            
        }
        void DocumentoParaImprimir_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0, bmp.Width, bmp.Height);
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            CapturaFormulario();

            Impresora.Document = DocumentoParaImprimir;
            DialogResult Result = Impresora.ShowDialog();

            if (Result == DialogResult.OK)
            {
                DocumentoParaImprimir.DefaultPageSettings.Landscape = false;
                DocumentoParaImprimir.Print();
            }
            
           
        }

        private void btVistaPrevia_Click(object sender, EventArgs e)
        {
            CapturaFormulario();

            VistaPrevia.Document = DocumentoParaImprimir;
            VistaPrevia.ShowDialog();
            
        }

        private void CapturaFormulario()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size sz = this.ClientRectangle.Size;
            bmp = new Bitmap(sz.Width, sz.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(bmp);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width,
                   this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);

            //bmp.Save("prueba.bmp", ImageFormat.Bmp);
        }
        //Activamos a que un suceso se active por medio de una tecla 
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == Keys.F1)
            {
                CapturaFormulario();

                Impresora.Document = DocumentoParaImprimir;
                DialogResult Result = Impresora.ShowDialog();

                if (Result == DialogResult.OK)
                {
                    DocumentoParaImprimir.DefaultPageSettings.Landscape = false;
                    DocumentoParaImprimir.Print();
                    this.Close();
                   
                    

                }
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest,
            int nXDest,
            int nYDest,
            int nWidth,
            int nHeight,
            IntPtr hdcSrc,
            int nXSrc,
            int nYSrc,
            int dwRop);

        private void lblhora_Click(object sender, EventArgs e)
        {

        }

        private void lblticket_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
