namespace NOMIGUI
{
    partial class ModificarEmpleado
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
            this.button4 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.comboSangre = new System.Windows.Forms.ComboBox();
            this.comboPuestos = new System.Windows.Forms.ComboBox();
            this.textCedula = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textSegundoapellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSegundonombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPrimerapellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textPrimernombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(157, 498);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Image = global::NOMIGUI.Properties.Resources.back2;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(10, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 52);
            this.button4.TabIndex = 40;
            this.button4.Text = "Atrás";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.comboSangre);
            this.panel2.Controls.Add(this.comboPuestos);
            this.panel2.Controls.Add(this.textCedula);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.comboGenero);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textSegundoapellido);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textSegundonombre);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textPrimerapellido);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textPrimernombre);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(175, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 498);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = global::NOMIGUI.Properties.Resources.pencil__2_;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(558, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 61);
            this.button2.TabIndex = 42;
            this.button2.Text = "Modificar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.comboSangre.Location = new System.Drawing.Point(538, 211);
            this.comboSangre.Name = "comboSangre";
            this.comboSangre.Size = new System.Drawing.Size(217, 21);
            this.comboSangre.TabIndex = 40;
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
            this.comboPuestos.Location = new System.Drawing.Point(129, 298);
            this.comboPuestos.Name = "comboPuestos";
            this.comboPuestos.Size = new System.Drawing.Size(216, 21);
            this.comboPuestos.TabIndex = 38;
            this.comboPuestos.SelectedIndexChanged += new System.EventHandler(this.comboPuestos_SelectedIndexChanged);
            // 
            // textCedula
            // 
            this.textCedula.Location = new System.Drawing.Point(127, 42);
            this.textCedula.Name = "textCedula";
            this.textCedula.Size = new System.Drawing.Size(218, 20);
            this.textCedula.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label9.Location = new System.Drawing.Point(67, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Cédula:";
            // 
            // comboGenero
            // 
            this.comboGenero.FormattingEnabled = true;
            this.comboGenero.Items.AddRange(new object[] {
            "M",
            "F"});
            this.comboGenero.Location = new System.Drawing.Point(537, 299);
            this.comboGenero.Name = "comboGenero";
            this.comboGenero.Size = new System.Drawing.Size(218, 21);
            this.comboGenero.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label5.Location = new System.Drawing.Point(477, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Género:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label6.Location = new System.Drawing.Point(418, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Grupo Sanguíneo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label8.Location = new System.Drawing.Point(71, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Puesto:";
            // 
            // textSegundoapellido
            // 
            this.textSegundoapellido.Location = new System.Drawing.Point(538, 127);
            this.textSegundoapellido.Name = "textSegundoapellido";
            this.textSegundoapellido.Size = new System.Drawing.Size(217, 20);
            this.textSegundoapellido.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label4.Location = new System.Drawing.Point(413, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Segundo Apellido:";
            // 
            // textSegundonombre
            // 
            this.textSegundonombre.Location = new System.Drawing.Point(537, 42);
            this.textSegundonombre.Name = "textSegundonombre";
            this.textSegundonombre.Size = new System.Drawing.Size(218, 20);
            this.textSegundonombre.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label3.Location = new System.Drawing.Point(413, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Segundo nombre:";
            // 
            // textPrimerapellido
            // 
            this.textPrimerapellido.Location = new System.Drawing.Point(127, 211);
            this.textPrimerapellido.Name = "textPrimerapellido";
            this.textPrimerapellido.Size = new System.Drawing.Size(218, 20);
            this.textPrimerapellido.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label2.Location = new System.Drawing.Point(16, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Primer Apellido:";
            // 
            // textPrimernombre
            // 
            this.textPrimernombre.Location = new System.Drawing.Point(127, 128);
            this.textPrimernombre.Name = "textPrimernombre";
            this.textPrimernombre.Size = new System.Drawing.Size(218, 20);
            this.textPrimernombre.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(255)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Primer Nombre:";
            // 
            // ModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(37)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(981, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ModificarEmpleado";
            this.Text = "ModificarEmpleado";
            this.Load += new System.EventHandler(this.ModificarEmpleado_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textCedula;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboGenero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textSegundoapellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSegundonombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPrimerapellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPrimernombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPuestos;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboSangre;
        private System.Windows.Forms.Button button2;
    }
}