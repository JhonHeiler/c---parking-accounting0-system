namespace colores
{
    partial class liquidar_encargado
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
            this.fecha1 = new System.Windows.Forms.DateTimePicker();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltotalventas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalprestamo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnpagar1 = new System.Windows.Forms.Button();
            this.btnhabilitar1 = new System.Windows.Forms.Button();
            this.txtvalor1 = new System.Windows.Forms.TextBox();
            this.lblingresaV = new System.Windows.Forms.Label();
            this.texnombre1 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txtIdentificacion1 = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tctnombrep = new System.Windows.Forms.TextBox();
            this.fecha2 = new System.Windows.Forms.DateTimePicker();
            this.btbbuscarp = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnHabilitar = new System.Windows.Forms.Button();
            this.lblhorasalida = new System.Windows.Forms.Label();
            this.lblliqui = new System.Windows.Forms.Label();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btn_pago = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fecha1
            // 
            this.fecha1.CustomFormat = "dd/MM/yyyy";
            this.fecha1.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.fecha1.Location = new System.Drawing.Point(77, -3);
            this.fecha1.Name = "fecha1";
            this.fecha1.Size = new System.Drawing.Size(129, 43);
            this.fecha1.TabIndex = 22;
            this.fecha1.Visible = false;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbuscar.ForeColor = System.Drawing.Color.Black;
            this.txtbuscar.Location = new System.Drawing.Point(630, 8);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(299, 33);
            this.txtbuscar.TabIndex = 24;
            this.txtbuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "Ingrese nombre :";
            // 
            // lbltotalventas
            // 
            this.lbltotalventas.AutoSize = true;
            this.lbltotalventas.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lbltotalventas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbltotalventas.Location = new System.Drawing.Point(229, -2);
            this.lbltotalventas.Name = "lbltotalventas";
            this.lbltotalventas.Size = new System.Drawing.Size(40, 45);
            this.lbltotalventas.TabIndex = 27;
            this.lbltotalventas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, -5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 45);
            this.label3.TabIndex = 26;
            this.label3.Text = "Liquidacion :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(4, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 45);
            this.label2.TabIndex = 29;
            this.label2.Text = "Deudas:";
            // 
            // lblTotalprestamo
            // 
            this.lblTotalprestamo.AutoSize = true;
            this.lblTotalprestamo.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.lblTotalprestamo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTotalprestamo.Location = new System.Drawing.Point(167, 3);
            this.lblTotalprestamo.Name = "lblTotalprestamo";
            this.lblTotalprestamo.Size = new System.Drawing.Size(40, 45);
            this.lblTotalprestamo.TabIndex = 30;
            this.lblTotalprestamo.Text = "0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(9, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1062, 620);
            this.panel1.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.panel3.Controls.Add(this.btnpagar1);
            this.panel3.Controls.Add(this.btnhabilitar1);
            this.panel3.Controls.Add(this.txtvalor1);
            this.panel3.Controls.Add(this.lblingresaV);
            this.panel3.Controls.Add(this.texnombre1);
            this.panel3.Controls.Add(this.textBox12);
            this.panel3.Controls.Add(this.txtIdentificacion1);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.lblTotalprestamo);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tctnombrep);
            this.panel3.Controls.Add(this.fecha2);
            this.panel3.Controls.Add(this.btbbuscarp);
            this.panel3.Location = new System.Drawing.Point(11, 343);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1037, 259);
            this.panel3.TabIndex = 32;
            // 
            // btnpagar1
            // 
            this.btnpagar1.BackColor = System.Drawing.Color.Red;
            this.btnpagar1.Enabled = false;
            this.btnpagar1.FlatAppearance.BorderSize = 0;
            this.btnpagar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnpagar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnpagar1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar1.ForeColor = System.Drawing.Color.Black;
            this.btnpagar1.Location = new System.Drawing.Point(926, 224);
            this.btnpagar1.Name = "btnpagar1";
            this.btnpagar1.Size = new System.Drawing.Size(96, 33);
            this.btnpagar1.TabIndex = 48;
            this.btnpagar1.Text = "Abonar";
            this.btnpagar1.UseVisualStyleBackColor = false;
            this.btnpagar1.Visible = false;
            this.btnpagar1.Click += new System.EventHandler(this.btnpagar1_Click_1);
            // 
            // btnhabilitar1
            // 
            this.btnhabilitar1.BackColor = System.Drawing.Color.Yellow;
            this.btnhabilitar1.FlatAppearance.BorderSize = 0;
            this.btnhabilitar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.btnhabilitar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnhabilitar1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhabilitar1.ForeColor = System.Drawing.Color.Black;
            this.btnhabilitar1.Location = new System.Drawing.Point(12, 224);
            this.btnhabilitar1.Name = "btnhabilitar1";
            this.btnhabilitar1.Size = new System.Drawing.Size(100, 33);
            this.btnhabilitar1.TabIndex = 49;
            this.btnhabilitar1.Text = "Habilitar";
            this.btnhabilitar1.UseVisualStyleBackColor = false;
            this.btnhabilitar1.Click += new System.EventHandler(this.btnhabilitar1_Click);
            // 
            // txtvalor1
            // 
            this.txtvalor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor1.Location = new System.Drawing.Point(717, 225);
            this.txtvalor1.Name = "txtvalor1";
            this.txtvalor1.Size = new System.Drawing.Size(208, 29);
            this.txtvalor1.TabIndex = 32;
            this.txtvalor1.Visible = false;
            this.txtvalor1.TextChanged += new System.EventHandler(this.txtvalor1_TextChanged);
            this.txtvalor1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalor1_KeyPress);
            // 
            // lblingresaV
            // 
            this.lblingresaV.AutoSize = true;
            this.lblingresaV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingresaV.Location = new System.Drawing.Point(596, 231);
            this.lblingresaV.Name = "lblingresaV";
            this.lblingresaV.Size = new System.Drawing.Size(116, 20);
            this.lblingresaV.TabIndex = 42;
            this.lblingresaV.Text = "Ingresa el valor";
            this.lblingresaV.Visible = false;
            // 
            // texnombre1
            // 
            this.texnombre1.Location = new System.Drawing.Point(205, 11);
            this.texnombre1.Name = "texnombre1";
            this.texnombre1.Size = new System.Drawing.Size(100, 20);
            this.texnombre1.TabIndex = 47;
            this.texnombre1.Visible = false;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(508, 11);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 46;
            this.textBox12.Visible = false;
            // 
            // txtIdentificacion1
            // 
            this.txtIdentificacion1.Location = new System.Drawing.Point(357, 11);
            this.txtIdentificacion1.Name = "txtIdentificacion1";
            this.txtIdentificacion1.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacion1.TabIndex = 32;
            this.txtIdentificacion1.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Enabled = false;
            this.dataGridView2.Location = new System.Drawing.Point(12, 49);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1010, 173);
            this.dataGridView2.TabIndex = 29;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(389, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 35);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ingrese nombre :";
            // 
            // tctnombrep
            // 
            this.tctnombrep.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tctnombrep.ForeColor = System.Drawing.Color.Black;
            this.tctnombrep.Location = new System.Drawing.Point(631, 11);
            this.tctnombrep.Name = "tctnombrep";
            this.tctnombrep.Size = new System.Drawing.Size(299, 33);
            this.tctnombrep.TabIndex = 34;
            // 
            // fecha2
            // 
            this.fecha2.CustomFormat = "dd/MM/yyyy";
            this.fecha2.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.fecha2.Location = new System.Drawing.Point(56, 1);
            this.fecha2.Name = "fecha2";
            this.fecha2.Size = new System.Drawing.Size(129, 43);
            this.fecha2.TabIndex = 32;
            this.fecha2.Visible = false;
            this.fecha2.ValueChanged += new System.EventHandler(this.fecha2_ValueChanged);
            // 
            // btbbuscarp
            // 
            this.btbbuscarp.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbbuscarp.ForeColor = System.Drawing.Color.Black;
            this.btbbuscarp.Location = new System.Drawing.Point(936, 7);
            this.btbbuscarp.Name = "btbbuscarp";
            this.btbbuscarp.Size = new System.Drawing.Size(86, 38);
            this.btbbuscarp.TabIndex = 33;
            this.btbbuscarp.Text = "Buscar";
            this.btbbuscarp.UseVisualStyleBackColor = true;
            this.btbbuscarp.Click += new System.EventHandler(this.btbbuscarp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.panel2.Controls.Add(this.fecha1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnbuscar);
            this.panel2.Controls.Add(this.btnHabilitar);
            this.panel2.Controls.Add(this.txtbuscar);
            this.panel2.Controls.Add(this.lblhorasalida);
            this.panel2.Controls.Add(this.lblliqui);
            this.panel2.Controls.Add(this.txtIdentificacion);
            this.panel2.Controls.Add(this.btn_pago);
            this.panel2.Controls.Add(this.txtValor);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbltotalventas);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1036, 315);
            this.panel2.TabIndex = 31;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(377, 1);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 44;
            this.dateTimePicker1.Visible = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.Black;
            this.btnbuscar.Location = new System.Drawing.Point(935, 6);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(86, 38);
            this.btnbuscar.TabIndex = 23;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnHabilitar
            // 
            this.btnHabilitar.BackColor = System.Drawing.Color.Yellow;
            this.btnHabilitar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHabilitar.ForeColor = System.Drawing.Color.Black;
            this.btnHabilitar.Location = new System.Drawing.Point(11, 275);
            this.btnHabilitar.Name = "btnHabilitar";
            this.btnHabilitar.Size = new System.Drawing.Size(96, 33);
            this.btnHabilitar.TabIndex = 46;
            this.btnHabilitar.Text = "Habilitar";
            this.btnHabilitar.UseVisualStyleBackColor = false;
            this.btnHabilitar.Click += new System.EventHandler(this.btnHabilitar_Click);
            // 
            // lblhorasalida
            // 
            this.lblhorasalida.AutoSize = true;
            this.lblhorasalida.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorasalida.ForeColor = System.Drawing.Color.Black;
            this.lblhorasalida.Location = new System.Drawing.Point(3, -5);
            this.lblhorasalida.Name = "lblhorasalida";
            this.lblhorasalida.Size = new System.Drawing.Size(73, 29);
            this.lblhorasalida.TabIndex = 45;
            this.lblhorasalida.Text = "salida";
            this.lblhorasalida.Visible = false;
            // 
            // lblliqui
            // 
            this.lblliqui.AutoSize = true;
            this.lblliqui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblliqui.Location = new System.Drawing.Point(592, 284);
            this.lblliqui.Name = "lblliqui";
            this.lblliqui.Size = new System.Drawing.Size(116, 20);
            this.lblliqui.TabIndex = 43;
            this.lblliqui.Text = "Ingresa el valor";
            this.lblliqui.Visible = false;
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.Location = new System.Drawing.Point(545, 3);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(100, 20);
            this.txtIdentificacion.TabIndex = 30;
            this.txtIdentificacion.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(272, 3);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 29;
            this.txtNombre.Visible = false;
            // 
            // btn_pago
            // 
            this.btn_pago.BackColor = System.Drawing.Color.Red;
            this.btn_pago.Enabled = false;
            this.btn_pago.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pago.ForeColor = System.Drawing.Color.Black;
            this.btn_pago.Location = new System.Drawing.Point(935, 278);
            this.btn_pago.Name = "btn_pago";
            this.btn_pago.Size = new System.Drawing.Size(86, 33);
            this.btn_pago.TabIndex = 36;
            this.btn_pago.Text = "Pagar";
            this.btn_pago.UseVisualStyleBackColor = false;
            this.btn_pago.Visible = false;
            this.btn_pago.Click += new System.EventHandler(this.btn_pago_Click);
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(711, 281);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(224, 29);
            this.txtValor.TabIndex = 31;
            this.txtValor.Visible = false;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            this.txtValor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValor_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 46);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 227);
            this.dataGridView1.TabIndex = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // liquidar_encargado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1082, 651);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "liquidar_encargado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "liquidar_encargado";
            this.Load += new System.EventHandler(this.liquidar_encargado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker fecha1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltotalventas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalprestamo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker fecha2;
        private System.Windows.Forms.Button btbbuscarp;
        private System.Windows.Forms.TextBox tctnombrep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_pago;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblingresaV;
        private System.Windows.Forms.TextBox txtvalor1;
        private System.Windows.Forms.Label lblliqui;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblhorasalida;
        private System.Windows.Forms.TextBox txtIdentificacion1;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox texnombre1;
        private System.Windows.Forms.Button btnpagar1;
        private System.Windows.Forms.Button btnhabilitar1;
        private System.Windows.Forms.Button btnHabilitar;
    }
}