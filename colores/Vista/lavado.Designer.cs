namespace colores
{
    partial class lavado
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.lbltipo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblplaca = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblencargado = new System.Windows.Forms.Label();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblIdentificacion = new System.Windows.Forms.Label();
            this.btncobrar = new System.Windows.Forms.Button();
            this.txtvalorLiquidacion = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(40, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingrese placa :";
            // 
            // txtplaca
            // 
            this.txtplaca.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.txtplaca.ForeColor = System.Drawing.Color.Black;
            this.txtplaca.Location = new System.Drawing.Point(261, 3);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(232, 43);
            this.txtplaca.TabIndex = 2;
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipo.ForeColor = System.Drawing.Color.Black;
            this.lbltipo.Location = new System.Drawing.Point(263, 190);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(67, 33);
            this.lbltipo.TabIndex = 12;
            this.lbltipo.Text = "Tipo";
            this.lbltipo.Visible = false;
            this.lbltipo.Click += new System.EventHandler(this.lbltipo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 33);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tipo de vehiculo :";
            // 
            // lblplaca
            // 
            this.lblplaca.AutoSize = true;
            this.lblplaca.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplaca.ForeColor = System.Drawing.Color.Black;
            this.lblplaca.Location = new System.Drawing.Point(263, 248);
            this.lblplaca.Name = "lblplaca";
            this.lblplaca.Size = new System.Drawing.Size(94, 33);
            this.lblplaca.TabIndex = 10;
            this.lblplaca.Text = "Placa :";
            this.lblplaca.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Placa :";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.Black;
            this.lblhora.Location = new System.Drawing.Point(584, 40);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(201, 77);
            this.lblhora.TabIndex = 15;
            this.lblhora.Text = "label5";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Black;
            this.lblfecha.Location = new System.Drawing.Point(262, 44);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(85, 33);
            this.lblfecha.TabIndex = 14;
            this.lblfecha.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Total :  $";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txttotal.Location = new System.Drawing.Point(155, 324);
            this.txttotal.Multiline = true;
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(226, 42);
            this.txttotal.TabIndex = 20;
            this.txttotal.Visible = false;
            this.txttotal.TextChanged += new System.EventHandler(this.txttotal_TextChanged);
            this.txttotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttotal_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 33);
            this.label6.TabIndex = 21;
            this.label6.Text = "Encargado :";
            // 
            // lblencargado
            // 
            this.lblencargado.AutoSize = true;
            this.lblencargado.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblencargado.ForeColor = System.Drawing.Color.Black;
            this.lblencargado.Location = new System.Drawing.Point(263, 113);
            this.lblencargado.Name = "lblencargado";
            this.lblencargado.Size = new System.Drawing.Size(140, 33);
            this.lblencargado.TabIndex = 22;
            this.lblencargado.Text = "Encargado";
            this.lblencargado.Visible = false;
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnconfirmar.Location = new System.Drawing.Point(499, 3);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(133, 44);
            this.btnconfirmar.TabIndex = 23;
            this.btnconfirmar.Text = "Aceptar";
            this.btnconfirmar.UseVisualStyleBackColor = true;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(31, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 33);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fecha de recibo :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(64, 292);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 25;
            this.dateTimePicker2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnconfirmar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtplaca);
            this.panel1.Location = new System.Drawing.Point(33, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 515);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.panel2.Controls.Add(this.lblhora);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.lblEstado);
            this.panel2.Controls.Add(this.lblIdentificacion);
            this.panel2.Controls.Add(this.btncobrar);
            this.panel2.Controls.Add(this.txtvalorLiquidacion);
            this.panel2.Location = new System.Drawing.Point(37, 57);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 431);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbltipo);
            this.groupBox1.Controls.Add(this.lblfecha);
            this.groupBox1.Controls.Add(this.lblplaca);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblencargado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.txttotal);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 380);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de lavado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(628, 166);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 29);
            this.checkBox1.TabIndex = 45;
            this.checkBox1.Text = "Pendiente";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBox1_MouseClick);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(752, 15);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(35, 13);
            this.lblEstado.TabIndex = 43;
            this.lblEstado.Text = "label7";
            this.lblEstado.Visible = false;
            // 
            // lblIdentificacion
            // 
            this.lblIdentificacion.AutoSize = true;
            this.lblIdentificacion.Location = new System.Drawing.Point(698, 134);
            this.lblIdentificacion.Name = "lblIdentificacion";
            this.lblIdentificacion.Size = new System.Drawing.Size(69, 13);
            this.lblIdentificacion.TabIndex = 40;
            this.lblIdentificacion.Text = "identificacion";
            this.lblIdentificacion.Visible = false;
            // 
            // btncobrar
            // 
            this.btncobrar.FlatAppearance.BorderSize = 0;
            this.btncobrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncobrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btncobrar.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncobrar.ForeColor = System.Drawing.Color.Crimson;
            this.btncobrar.Image = global::colores.Properties.Resources.WhatsApp_Image_2021_08_14_at_11_43_02_AM;
            this.btncobrar.Location = new System.Drawing.Point(628, 242);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(190, 153);
            this.btncobrar.TabIndex = 39;
            this.btncobrar.Text = "Clic-cobrar";
            this.btncobrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncobrar.UseVisualStyleBackColor = true;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click_1);
            // 
            // txtvalorLiquidacion
            // 
            this.txtvalorLiquidacion.Location = new System.Drawing.Point(646, 15);
            this.txtvalorLiquidacion.Name = "txtvalorLiquidacion";
            this.txtvalorLiquidacion.Size = new System.Drawing.Size(100, 20);
            this.txtvalorLiquidacion.TabIndex = 41;
            this.txtvalorLiquidacion.Visible = false;
            // 
            // lavado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1000, 577);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "lavado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "lavado";
            this.Load += new System.EventHandler(this.lavado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblplaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblencargado;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Label lblIdentificacion;
        private System.Windows.Forms.TextBox txtvalorLiquidacion;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}