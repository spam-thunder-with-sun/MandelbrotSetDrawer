namespace InsiemeMandelbrot
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDisegna = new System.Windows.Forms.Button();
            this.pnl = new System.Windows.Forms.Panel();
            this.pnl_Scelta = new System.Windows.Forms.Panel();
            this.rdOttima = new System.Windows.Forms.RadioButton();
            this.rdBuona = new System.Windows.Forms.RadioButton();
            this.rdScarsa = new System.Windows.Forms.RadioButton();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.btnRidisegna = new System.Windows.Forms.Button();
            this.pnl_Scelta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDisegna
            // 
            this.btnDisegna.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDisegna.Location = new System.Drawing.Point(307, 12);
            this.btnDisegna.Name = "btnDisegna";
            this.btnDisegna.Size = new System.Drawing.Size(87, 31);
            this.btnDisegna.TabIndex = 0;
            this.btnDisegna.Text = "Disegna!";
            this.btnDisegna.UseVisualStyleBackColor = false;
            this.btnDisegna.Click += new System.EventHandler(this.btnDisegna_Click);
            // 
            // pnl
            // 
            this.pnl.Location = new System.Drawing.Point(12, 49);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(1200, 800);
            this.pnl.TabIndex = 1;
            // 
            // pnl_Scelta
            // 
            this.pnl_Scelta.Controls.Add(this.rdOttima);
            this.pnl_Scelta.Controls.Add(this.rdBuona);
            this.pnl_Scelta.Controls.Add(this.rdScarsa);
            this.pnl_Scelta.Controls.Add(this.lbl_3);
            this.pnl_Scelta.Location = new System.Drawing.Point(12, 12);
            this.pnl_Scelta.Name = "pnl_Scelta";
            this.pnl_Scelta.Size = new System.Drawing.Size(279, 31);
            this.pnl_Scelta.TabIndex = 4;
            // 
            // rdOttima
            // 
            this.rdOttima.AutoSize = true;
            this.rdOttima.Location = new System.Drawing.Point(210, 3);
            this.rdOttima.Name = "rdOttima";
            this.rdOttima.Size = new System.Drawing.Size(55, 17);
            this.rdOttima.TabIndex = 4;
            this.rdOttima.Text = "Ottima";
            this.rdOttima.UseVisualStyleBackColor = true;
            // 
            // rdBuona
            // 
            this.rdBuona.AutoSize = true;
            this.rdBuona.Checked = true;
            this.rdBuona.Location = new System.Drawing.Point(149, 3);
            this.rdBuona.Name = "rdBuona";
            this.rdBuona.Size = new System.Drawing.Size(56, 17);
            this.rdBuona.TabIndex = 3;
            this.rdBuona.TabStop = true;
            this.rdBuona.Text = "Buona";
            this.rdBuona.UseVisualStyleBackColor = true;
            // 
            // rdScarsa
            // 
            this.rdScarsa.AutoSize = true;
            this.rdScarsa.Location = new System.Drawing.Point(87, 3);
            this.rdScarsa.Name = "rdScarsa";
            this.rdScarsa.Size = new System.Drawing.Size(58, 17);
            this.rdScarsa.TabIndex = 2;
            this.rdScarsa.Text = "Scarsa";
            this.rdScarsa.UseVisualStyleBackColor = true;
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_3.Location = new System.Drawing.Point(4, 0);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(63, 20);
            this.lbl_3.TabIndex = 0;
            this.lbl_3.Text = "Qualità:";
            // 
            // btnRidisegna
            // 
            this.btnRidisegna.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRidisegna.Location = new System.Drawing.Point(400, 12);
            this.btnRidisegna.Name = "btnRidisegna";
            this.btnRidisegna.Size = new System.Drawing.Size(87, 31);
            this.btnRidisegna.TabIndex = 5;
            this.btnRidisegna.Text = "Ridisegna";
            this.btnRidisegna.UseVisualStyleBackColor = false;
            this.btnRidisegna.Click += new System.EventHandler(this.btnRidisegna_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1234, 860);
            this.Controls.Add(this.btnRidisegna);
            this.Controls.Add(this.pnl_Scelta);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.btnDisegna);
            this.Name = "FormMain";
            this.Text = "Insieme di Mandelbrot";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.pnl_Scelta.ResumeLayout(false);
            this.pnl_Scelta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisegna;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Panel pnl_Scelta;
        private System.Windows.Forms.RadioButton rdOttima;
        private System.Windows.Forms.RadioButton rdBuona;
        private System.Windows.Forms.RadioButton rdScarsa;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Button btnRidisegna;
    }
}

