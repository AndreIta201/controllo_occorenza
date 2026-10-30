namespace controllo_occorenza
{
    partial class Form1
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
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.btn_verifica = new System.Windows.Forms.Button();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.btn_cerca = new System.Windows.Forms.Button();
            this.txt_n2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.Location = new System.Drawing.Point(136, 9);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(385, 55);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "Inserire la frase:";
            // 
            // txt_n1
            // 
            this.txt_n1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_n1.Location = new System.Drawing.Point(208, 84);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(241, 29);
            this.txt_n1.TabIndex = 1;
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.Location = new System.Drawing.Point(322, 190);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(13, 20);
            this.lbl_n2.TabIndex = 2;
            this.lbl_n2.Text = ".";
            // 
            // btn_verifica
            // 
            this.btn_verifica.Location = new System.Drawing.Point(286, 136);
            this.btn_verifica.Name = "btn_verifica";
            this.btn_verifica.Size = new System.Drawing.Size(84, 35);
            this.btn_verifica.TabIndex = 3;
            this.btn_verifica.Text = "VERIFICA";
            this.btn_verifica.UseVisualStyleBackColor = true;
            this.btn_verifica.Click += new System.EventHandler(this.btn_verifica_Click);
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n3.Location = new System.Drawing.Point(595, 34);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(265, 24);
            this.lbl_n3.TabIndex = 4;
            this.lbl_n3.Text = "Quale lettere si vuole cercare?";
            // 
            // btn_cerca
            // 
            this.btn_cerca.Location = new System.Drawing.Point(688, 99);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(75, 23);
            this.btn_cerca.TabIndex = 5;
            this.btn_cerca.Text = "button1";
            this.btn_cerca.UseVisualStyleBackColor = true;
            this.btn_cerca.Click += new System.EventHandler(this.btn_cerca_Click);
            // 
            // txt_n2
            // 
            this.txt_n2.Location = new System.Drawing.Point(708, 61);
            this.txt_n2.Name = "txt_n2";
            this.txt_n2.Size = new System.Drawing.Size(32, 20);
            this.txt_n2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 587);
            this.Controls.Add(this.txt_n2);
            this.Controls.Add(this.btn_cerca);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.btn_verifica);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Button btn_verifica;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.Button btn_cerca;
        private System.Windows.Forms.TextBox txt_n2;
    }
}

