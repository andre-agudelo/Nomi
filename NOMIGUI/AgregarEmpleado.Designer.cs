namespace NOMIGUI
{
    partial class AgregarEmpleado
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboSangre = new System.Windows.Forms.ComboBox();
            this.comboPuestos = new System.Windows.Forms.ComboBox();
            this.textFecha = new System.Windows.Forms.DateTimePicker();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textSegundoApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSegundoNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrimerApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPrimerNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.panel1.Controls.Add(this.textEmail);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textCedula);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboSangre);
            this.panel1.Controls.Add(this.comboPuestos);
            this.panel1.Controls.Add(this.textFecha);
            this.panel1.Controls.Add(this.comboSexo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textSegundoApellido);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textSegundoNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textPrimerApellido);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textPrimerNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(202, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 492);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(143, 400);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(222, 20);
            this.textEmail.TabIndex = 42;
            this.textEmail.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label10.Location = new System.Drawing.Point(93, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 19);
            this.label10.TabIndex = 41;
            this.label10.Text = "Email:";
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(143, 37);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(222, 20);
            this.textCedula.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label9.Location = new System.Drawing.Point(80, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 39;
            this.label9.Text = "Cedula:";
            // 
            // comboSangre
            // 
            this.comboSangre.FormattingEnabled = true;
            this.comboSangre.Items.AddRange(new object[] {
            "O +",
            "O -",
            "A +",
            "A -",
            "B +",
            "B -",
            "AB +",
            "AB -"});
            this.comboSangre.Location = new System.Drawing.Point(143, 355);
            this.comboSangre.Name = "comboSangre";
            this.comboSangre.Size = new System.Drawing.Size(222, 21);
            this.comboSangre.TabIndex = 38;
            // 
            // comboPuestos
            // 
            this.comboPuestos.FormattingEnabled = true;
            this.comboPuestos.Items.AddRange(new object[] {
            "Mesero",
            "Cajero",
            "Juguero",
            "Asador",
            "Sandwichero",
            "Despulpador"});
            this.comboPuestos.Location = new System.Drawing.Point(143, 263);
            this.comboPuestos.Name = "comboPuestos";
            this.comboPuestos.Size = new System.Drawing.Size(222, 21);
            this.comboPuestos.TabIndex = 37;
            this.comboPuestos.SelectedIndexChanged += new System.EventHandler(this.comboPuestos_SelectedIndexChanged);
            // 
            // textFecha
            // 
            this.textFecha.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFecha.Location = new System.Drawing.Point(143, 308);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(222, 22);
            this.textFecha.TabIndex = 35;
            // 
            // comboSexo
            // 
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboSexo.Location = new System.Drawing.Point(143, 440);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(222, 21);
            this.comboSexo.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label5.Location = new System.Drawing.Point(94, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label6.Location = new System.Drawing.Point(24, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Grupo Sanguíneo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label7.Location = new System.Drawing.Point(56, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Fecha Inicio:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label8.Location = new System.Drawing.Point(87, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Puesto:";
            // 
            // textSegundoApellido
            // 
            this.textSegundoApellido.Location = new System.Drawing.Point(143, 217);
            this.textSegundoApellido.Name = "textSegundoApellido";
            this.textSegundoApellido.Size = new System.Drawing.Size(222, 20);
            this.textSegundoApellido.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label4.Location = new System.Drawing.Point(17, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Segundo Apellido:";
            // 
            // textSegundoNombre
            // 
            this.textSegundoNombre.Location = new System.Drawing.Point(143, 126);
            this.textSegundoNombre.Name = "textSegundoNombre";
            this.textSegundoNombre.Size = new System.Drawing.Size(222, 20);
            this.textSegundoNombre.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Segundo nombre:";
            // 
            // textPrimerApellido
            // 
            this.textPrimerApellido.Location = new System.Drawing.Point(143, 171);
            this.textPrimerApellido.Name = "textPrimerApellido";
            this.textPrimerApellido.Size = new System.Drawing.Size(222, 20);
            this.textPrimerApellido.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label2.Location = new System.Drawing.Point(31, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Primer Apellido:";
            // 
            // textPrimerNombre
            // 
            this.textPrimerNombre.Location = new System.Drawing.Point(143, 80);
            this.textPrimerNombre.Name = "textPrimerNombre";
            this.textPrimerNombre.Size = new System.Drawing.Size(222, 20);
            this.textPrimerNombre.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(30, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Primer Nombre:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(184, 492);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::NOMIGUI.Properties.Resources.logout__1_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(26, 196);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 95);
            this.button4.TabIndex = 1;
            this.button4.Text = "Atrás";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::NOMIGUI.Properties.Resources.tecnologia;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(431, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 60);
            this.button1.TabIndex = 18;
            this.button1.Text = "Guardar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarEmpleado
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(796, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AgregarEmpleado";
            this.Text = "AgregarEmpleado";
            this.Load += new System.EventHandler(this.AgregarEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker textFecha;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textSegundoApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSegundoNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPrimerApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPrimerNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPuestos;
        private System.Windows.Forms.ComboBox comboSangre;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label10;
    }
}