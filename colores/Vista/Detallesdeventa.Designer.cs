namespace colores
{
    partial class Detallesdeventa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltotalventas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnfiltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnreporte = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtBorrarPago = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.btbbuscarp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltotalventas
            // 
            this.lbltotalventas.AutoSize = true;
            this.lbltotalventas.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbltotalventas.Location = new System.Drawing.Point(651, 166);
            this.lbltotalventas.Name = "lbltotalventas";
            this.lbltotalventas.Size = new System.Drawing.Size(51, 58);
            this.lbltotalventas.TabIndex = 14;
            this.lbltotalventas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(330, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(315, 45);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total de ventas: $";
            // 
            // btnfiltar
            // 
            this.btnfiltar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btnfiltar.Location = new System.Drawing.Point(12, 150);
            this.btnfiltar.Name = "btnfiltar";
            this.btnfiltar.Size = new System.Drawing.Size(308, 87);
            this.btnfiltar.TabIndex = 12;
            this.btnfiltar.Text = "♒ Filtar";
            this.btnfiltar.UseVisualStyleBackColor = true;
            this.btnfiltar.Click += new System.EventHandler(this.btnfiltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(752, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(4, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Desde";
            // 
            // fecha2
            // 
            this.fecha2.CustomFormat = "dd/MM/yyyy";
            this.fecha2.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.fecha2.Location = new System.Drawing.Point(751, 66);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(516, 43);
            this.fecha2.TabIndex = 9;
            // 
            // fecha1
            // 
            this.fecha1.CustomFormat = "dd/MM/yyyy";
            this.fecha1.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.fecha1.Location = new System.Drawing.Point(12, 66);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(521, 43);
            this.fecha1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 243);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(1255, 365);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnreporte
            // 
            this.btnreporte.Enabled = false;
            this.btnreporte.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btnreporte.Location = new System.Drawing.Point(959, 151);
            this.btnreporte.Name = "btnreporte";
            this.btnreporte.Size = new System.Drawing.Size(308, 87);
            this.btnreporte.TabIndex = 17;
            this.btnreporte.Text = "♒ Exportar";
            this.btnreporte.UseVisualStyleBackColor = true;
            this.btnreporte.Click += new System.EventHandler(this.btnreporte_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(982, 112);
            this.lblmensaje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(69, 20);
            this.lblmensaje.TabIndex = 18;
            this.lblmensaje.Text = "mensaje";
            this.lblmensaje.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(351, 202);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 25;
            this.txtNombre.Visible = false;
            // 
            // txtBorrarPago
            // 
            this.txtBorrarPago.Location = new System.Drawing.Point(501, 202);
            this.txtBorrarPago.Name = "txtBorrarPago";
            this.txtBorrarPago.Size = new System.Drawing.Size(100, 20);
            this.txtBorrarPago.TabIndex = 26;
            this.txtBorrarPago.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 47);
            this.button1.TabIndex = 27;
            this.button1.Text = "♒ Habilitar para poder eliminar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(346, 615);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 47);
            this.button2.TabIndex = 28;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaca.ForeColor = System.Drawing.Color.Black;
            this.txtPlaca.Location = new System.Drawing.Point(941, 614);
            this.txtPlaca.Multiline = true;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(222, 37);
            this.txtPlaca.TabIndex = 35;
            // 
            // btbbuscarp
            // 
            this.btbbuscarp.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbbuscarp.ForeColor = System.Drawing.Color.Black;
            this.btbbuscarp.Location = new System.Drawing.Point(1171, 614);
            this.btbbuscarp.Name = "btbbuscarp";
            this.btbbuscarp.Size = new System.Drawing.Size(98, 37);
            this.btbbuscarp.TabIndex = 36;
            this.btbbuscarp.Text = "Buscar";
            this.btbbuscarp.UseVisualStyleBackColor = true;
            this.btbbuscarp.Click += new System.EventHandler(this.btbbuscarp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(757, 618);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 31);
            this.label4.TabIndex = 37;
            this.label4.Text = "Ingrese placa";
            // 
            // Detallesdeventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.ClientSize = new System.Drawing.Size(1280, 701);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btbbuscarp);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBorrarPago);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnreporte);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbltotalventas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnfiltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha2);
            this.Controls.Add(this.fecha1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Detallesdeventa";
            this.Text = "Detallesdeventa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Detallesdeventa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotalventas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnfiltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.DataGridView dataGridView1;
       
        private System.Windows.Forms.Button btnreporte;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtBorrarPago;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Button btbbuscarp;
        private System.Windows.Forms.Label label4;
    }
}