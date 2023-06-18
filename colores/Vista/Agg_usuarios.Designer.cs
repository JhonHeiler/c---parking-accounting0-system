namespace colores
{
    partial class Agg_usuarios
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
            this.ckvercontra = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtcontraseña_user = new System.Windows.Forms.TextBox();
            this.txtnombre_user = new System.Windows.Forms.TextBox();
            this.txtcedula_user = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckvercontra
            // 
            this.ckvercontra.AutoSize = true;
            this.ckvercontra.Location = new System.Drawing.Point(181, 235);
            this.ckvercontra.Margin = new System.Windows.Forms.Padding(4);
            this.ckvercontra.Name = "ckvercontra";
            this.ckvercontra.Size = new System.Drawing.Size(127, 21);
            this.ckvercontra.TabIndex = 28;
            this.ckvercontra.Text = "Ver contraseña";
            this.ckvercontra.UseVisualStyleBackColor = true;
            this.ckvercontra.CheckedChanged += new System.EventHandler(this.ckvercontra_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Administrador",
            "Empleado"});
            this.comboBox1.Location = new System.Drawing.Point(172, 279);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 275);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Cargo :";
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.Location = new System.Drawing.Point(168, 341);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(164, 44);
            this.btnguardar.TabIndex = 25;
            this.btnguardar.Text = "✔ Crear";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtcontraseña_user
            // 
            this.txtcontraseña_user.Location = new System.Drawing.Point(181, 192);
            this.txtcontraseña_user.Margin = new System.Windows.Forms.Padding(4);
            this.txtcontraseña_user.Name = "txtcontraseña_user";
            this.txtcontraseña_user.Size = new System.Drawing.Size(153, 22);
            this.txtcontraseña_user.TabIndex = 24;
            this.txtcontraseña_user.UseSystemPasswordChar = true;
            // 
            // txtnombre_user
            // 
            this.txtnombre_user.Location = new System.Drawing.Point(181, 135);
            this.txtnombre_user.Margin = new System.Windows.Forms.Padding(4);
            this.txtnombre_user.Name = "txtnombre_user";
            this.txtnombre_user.Size = new System.Drawing.Size(153, 22);
            this.txtnombre_user.TabIndex = 23;
            this.txtnombre_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_user_KeyPress);
            // 
            // txtcedula_user
            // 
            this.txtcedula_user.BackColor = System.Drawing.Color.White;
            this.txtcedula_user.ForeColor = System.Drawing.Color.Black;
            this.txtcedula_user.Location = new System.Drawing.Point(181, 82);
            this.txtcedula_user.Margin = new System.Windows.Forms.Padding(4);
            this.txtcedula_user.Name = "txtcedula_user";
            this.txtcedula_user.Size = new System.Drawing.Size(153, 22);
            this.txtcedula_user.TabIndex = 22;
            this.txtcedula_user.TextChanged += new System.EventHandler(this.txtcedula_user_TextChanged);
            this.txtcedula_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_user_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Contraseña :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Cedula :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Creacion de usuarios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(24, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 480);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ckvercontra);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnguardar);
            this.panel2.Controls.Add(this.txtcedula_user);
            this.panel2.Controls.Add(this.txtcontraseña_user);
            this.panel2.Controls.Add(this.txtnombre_user);
            this.panel2.Location = new System.Drawing.Point(45, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 410);
            this.panel2.TabIndex = 0;
            // 
            // Agg_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(604, 532);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Agg_usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo usuario";
            this.Load += new System.EventHandler(this.Agg_usuarios_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox ckvercontra;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtcontraseña_user;
        private System.Windows.Forms.TextBox txtnombre_user;
        private System.Windows.Forms.TextBox txtcedula_user;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}