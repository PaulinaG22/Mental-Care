namespace Mental_Care_Programación
{
    partial class Bienvenido
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
            this.lblbienvenido = new System.Windows.Forms.Label();
            this.lbla = new System.Windows.Forms.Label();
            this.lblMentalCare = new System.Windows.Forms.Label();
            this.lblpedircita = new System.Windows.Forms.Label();
            this.BttnIngrese = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbienvenido
            // 
            this.lblbienvenido.AutoSize = true;
            this.lblbienvenido.BackColor = System.Drawing.Color.LightCyan;
            this.lblbienvenido.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbienvenido.Location = new System.Drawing.Point(12, 143);
            this.lblbienvenido.Name = "lblbienvenido";
            this.lblbienvenido.Size = new System.Drawing.Size(216, 38);
            this.lblbienvenido.TabIndex = 1;
            this.lblbienvenido.Text = "Bienvenido";
            // 
            // lbla
            // 
            this.lbla.AutoSize = true;
            this.lbla.BackColor = System.Drawing.Color.LightCyan;
            this.lbla.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbla.Location = new System.Drawing.Point(90, 203);
            this.lbla.Name = "lbla";
            this.lbla.Size = new System.Drawing.Size(38, 38);
            this.lbla.TabIndex = 2;
            this.lbla.Text = "a";
            // 
            // lblMentalCare
            // 
            this.lblMentalCare.AutoSize = true;
            this.lblMentalCare.BackColor = System.Drawing.Color.LightCyan;
            this.lblMentalCare.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentalCare.Location = new System.Drawing.Point(12, 272);
            this.lblMentalCare.Name = "lblMentalCare";
            this.lblMentalCare.Size = new System.Drawing.Size(230, 38);
            this.lblMentalCare.TabIndex = 3;
            this.lblMentalCare.Text = "Mental Care";
            // 
            // lblpedircita
            // 
            this.lblpedircita.AutoSize = true;
            this.lblpedircita.BackColor = System.Drawing.Color.LightCyan;
            this.lblpedircita.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpedircita.Location = new System.Drawing.Point(588, 152);
            this.lblpedircita.Name = "lblpedircita";
            this.lblpedircita.Size = new System.Drawing.Size(283, 29);
            this.lblpedircita.TabIndex = 4;
            this.lblpedircita.Text = "Si desea pedir una cita";
            // 
            // BttnIngrese
            // 
            this.BttnIngrese.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BttnIngrese.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.BttnIngrese.Location = new System.Drawing.Point(637, 213);
            this.BttnIngrese.Name = "BttnIngrese";
            this.BttnIngrese.Size = new System.Drawing.Size(188, 63);
            this.BttnIngrese.TabIndex = 5;
            this.BttnIngrese.Text = "Ingrese aquí";
            this.BttnIngrese.UseVisualStyleBackColor = false;
            this.BttnIngrese.Click += new System.EventHandler(this.bttnIngrese_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Mental_Care_Programación.Properties.Resources.Salud_Mental__1_;
            this.pictureBox1.Location = new System.Drawing.Point(1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(926, 469);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 455);
            this.Controls.Add(this.BttnIngrese);
            this.Controls.Add(this.lblpedircita);
            this.Controls.Add(this.lblMentalCare);
            this.Controls.Add(this.lbla);
            this.Controls.Add(this.lblbienvenido);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Bienvenido";
            this.Text = "Bienvenido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblbienvenido;
        private System.Windows.Forms.Label lbla;
        private System.Windows.Forms.Label lblMentalCare;
        private System.Windows.Forms.Label lblpedircita;
        private System.Windows.Forms.Button BttnIngrese;
    }
}

