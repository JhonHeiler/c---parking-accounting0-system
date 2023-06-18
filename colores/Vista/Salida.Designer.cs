namespace colores
{
    partial class Salida
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblhoraentrada = new System.Windows.Forms.Label();
            this.lblhorasalida = new System.Windows.Forms.Label();
            this.lbltiempoacobrar = new System.Windows.Forms.Label();
            this.btnactivar = new System.Windows.Forms.Button();
            this.btncobrar = new System.Windows.Forms.Button();
            this.lblfecha = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbltipo = new System.Windows.Forms.Label();
            this.lblcontador = new System.Windows.Forms.Label();
            this.lblparque = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbltotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotalOtros = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(32, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese placa :";
            // 
            // txtplaca
            // 
            this.txtplaca.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.txtplaca.Location = new System.Drawing.Point(208, 7);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(266, 43);
            this.txtplaca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora de entrada :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hora de salida :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(11, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiempo a cobrar :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total a cobrar :";
            // 
            // lblhoraentrada
            // 
            this.lblhoraentrada.AutoSize = true;
            this.lblhoraentrada.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhoraentrada.ForeColor = System.Drawing.Color.Black;
            this.lblhoraentrada.Location = new System.Drawing.Point(234, 104);
            this.lblhoraentrada.Name = "lblhoraentrada";
            this.lblhoraentrada.Size = new System.Drawing.Size(90, 29);
            this.lblhoraentrada.TabIndex = 6;
            this.lblhoraentrada.Text = "Total  :";
            this.lblhoraentrada.Visible = false;
            // 
            // lblhorasalida
            // 
            this.lblhorasalida.AutoSize = true;
            this.lblhorasalida.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhorasalida.ForeColor = System.Drawing.Color.Black;
            this.lblhorasalida.Location = new System.Drawing.Point(234, 157);
            this.lblhorasalida.Name = "lblhorasalida";
            this.lblhorasalida.Size = new System.Drawing.Size(90, 29);
            this.lblhorasalida.TabIndex = 7;
            this.lblhorasalida.Text = "Total  :";
            this.lblhorasalida.Visible = false;
            // 
            // lbltiempoacobrar
            // 
            this.lbltiempoacobrar.AutoSize = true;
            this.lbltiempoacobrar.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltiempoacobrar.ForeColor = System.Drawing.Color.Black;
            this.lbltiempoacobrar.Location = new System.Drawing.Point(234, 220);
            this.lbltiempoacobrar.Name = "lbltiempoacobrar";
            this.lbltiempoacobrar.Size = new System.Drawing.Size(90, 29);
            this.lbltiempoacobrar.TabIndex = 8;
            this.lbltiempoacobrar.Text = "Total  :";
            this.lbltiempoacobrar.Visible = false;
            // 
            // btnactivar
            // 
            this.btnactivar.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactivar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnactivar.Location = new System.Drawing.Point(479, 8);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(225, 41);
            this.btnactivar.TabIndex = 10;
            this.btnactivar.Text = "Activar";
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // btncobrar
            // 
            this.btncobrar.Enabled = false;
            this.btncobrar.Font = new System.Drawing.Font("Tahoma", 27.75F);
            this.btncobrar.ForeColor = System.Drawing.Color.Crimson;
            this.btncobrar.Image = global::colores.Properties.Resources.images__1_;
            this.btncobrar.Location = new System.Drawing.Point(451, 111);
            this.btncobrar.Name = "btncobrar";
            this.btncobrar.Size = new System.Drawing.Size(225, 224);
            this.btncobrar.TabIndex = 11;
            this.btncobrar.Text = "Clic-cobrar";
            this.btncobrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btncobrar.UseVisualStyleBackColor = true;
            this.btncobrar.Click += new System.EventHandler(this.btncobrar_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.Color.Black;
            this.lblfecha.Location = new System.Drawing.Point(234, 41);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(90, 29);
            this.lblfecha.TabIndex = 13;
            this.lblfecha.Text = "Total  :";
            this.lblfecha.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fecha :";
            // 
            // lbltipo
            // 
            this.lbltipo.AutoSize = true;
            this.lbltipo.Location = new System.Drawing.Point(448, 176);
            this.lbltipo.Name = "lbltipo";
            this.lbltipo.Size = new System.Drawing.Size(40, 13);
            this.lbltipo.TabIndex = 14;
            this.lbltipo.Text = "Total  :";
            this.lbltipo.Visible = false;
            // 
            // lblcontador
            // 
            this.lblcontador.AutoSize = true;
            this.lblcontador.Location = new System.Drawing.Point(451, 118);
            this.lblcontador.Name = "lblcontador";
            this.lblcontador.Size = new System.Drawing.Size(40, 13);
            this.lblcontador.TabIndex = 16;
            this.lblcontador.Text = "Total  :";
            this.lblcontador.Visible = false;
            // 
            // lblparque
            // 
            this.lblparque.AutoSize = true;
            this.lblparque.Location = new System.Drawing.Point(448, 141);
            this.lblparque.Name = "lblparque";
            this.lblparque.Size = new System.Drawing.Size(68, 13);
            this.lblparque.TabIndex = 17;
            this.lblparque.Text = "Parqueadero";
            this.lblparque.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Location = new System.Drawing.Point(393, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            this.dateTimePicker1.Visible = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbltotal.Location = new System.Drawing.Point(233, 284);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(101, 33);
            this.lbltotal.TabIndex = 19;
            this.lbltotal.Text = "Total  :";
            this.lbltotal.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.panel1.Controls.Add(this.txtTotalOtros);
            this.panel1.Controls.Add(this.lbltotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btncobrar);
            this.panel1.Controls.Add(this.lbltipo);
            this.panel1.Controls.Add(this.lblparque);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.lblcontador);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblfecha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblhoraentrada);
            this.panel1.Controls.Add(this.lbltiempoacobrar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblhorasalida);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(20, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 363);
            this.panel1.TabIndex = 20;
            // 
            // txtTotalOtros
            // 
            this.txtTotalOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalOtros.Location = new System.Drawing.Point(219, 281);
            this.txtTotalOtros.Multiline = true;
            this.txtTotalOtros.Name = "txtTotalOtros";
            this.txtTotalOtros.Size = new System.Drawing.Size(139, 33);
            this.txtTotalOtros.TabIndex = 20;
            this.txtTotalOtros.Visible = false;
            this.txtTotalOtros.TextChanged += new System.EventHandler(this.txtTotalOtros_TextChanged);
            this.txtTotalOtros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalOtros_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.txtplaca);
            this.panel2.Controls.Add(this.btnactivar);
            this.panel2.Location = new System.Drawing.Point(9, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 446);
            this.panel2.TabIndex = 21;
            // 
            // Salida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(778, 493);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Salida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salida de vehiculos";
            this.Load += new System.EventHandler(this.Salida_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtplaca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblhoraentrada;
        private System.Windows.Forms.Label lblhorasalida;
        private System.Windows.Forms.Label lbltiempoacobrar;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.Button btncobrar;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbltipo;
        private System.Windows.Forms.Label lblcontador;
        private System.Windows.Forms.Label lblparque;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTotalOtros;
    }
}