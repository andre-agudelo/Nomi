namespace NOMIGUI
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.Button();
            this.Liquidar = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.Gestionar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.Liquidar);
            this.panel1.Controls.Add(this.Registrar);
            this.panel1.Controls.Add(this.Gestionar);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 451);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Salir
            // 
            this.Salir.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Salir.FlatAppearance.BorderSize = 0;
            this.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Salir.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salir.Image = global::NOMIGUI.Properties.Resources.logout__1_;
            this.Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Salir.Location = new System.Drawing.Point(515, 280);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(254, 105);
            this.Salir.TabIndex = 3;
            this.Salir.Text = "Salir";
            this.Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salir.UseVisualStyleBackColor = false;
            this.Salir.Click += new System.EventHandler(this.button4_Click);
            // 
            // Liquidar
            // 
            this.Liquidar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Liquidar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Liquidar.FlatAppearance.BorderSize = 0;
            this.Liquidar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Liquidar.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liquidar.Image = global::NOMIGUI.Properties.Resources.money;
            this.Liquidar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Liquidar.Location = new System.Drawing.Point(112, 280);
            this.Liquidar.Name = "Liquidar";
            this.Liquidar.Size = new System.Drawing.Size(247, 105);
            this.Liquidar.TabIndex = 2;
            this.Liquidar.Text = "Liquidaciones";
            this.Liquidar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Liquidar.UseVisualStyleBackColor = false;
            this.Liquidar.Click += new System.EventHandler(this.button3_Click);
            // 
            // Registrar
            // 
            this.Registrar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Registrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Registrar.FlatAppearance.BorderSize = 0;
            this.Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrar.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrar.Image = global::NOMIGUI.Properties.Resources.time;
            this.Registrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Registrar.Location = new System.Drawing.Point(515, 60);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(254, 105);
            this.Registrar.TabIndex = 1;
            this.Registrar.Text = "Llegadas";
            this.Registrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Registrar.UseVisualStyleBackColor = false;
            this.Registrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // Gestionar
            // 
            this.Gestionar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gestionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Gestionar.FlatAppearance.BorderSize = 0;
            this.Gestionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Gestionar.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gestionar.Image = global::NOMIGUI.Properties.Resources.user__1_;
            this.Gestionar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Gestionar.Location = new System.Drawing.Point(112, 60);
            this.Gestionar.Name = "Gestionar";
            this.Gestionar.Size = new System.Drawing.Size(247, 105);
            this.Gestionar.TabIndex = 0;
            this.Gestionar.Text = "Gestionar Empleados";
            this.Gestionar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Gestionar.UseVisualStyleBackColor = false;
            this.Gestionar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::NOMIGUI.Properties.Resources.lista;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(380, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 95);
            this.button1.TabIndex = 4;
            this.button1.Text = "Historial General";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button Liquidar;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button Gestionar;
        private System.Windows.Forms.Button button1;
    }
}

