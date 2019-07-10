namespace Carreras
{
    partial class Form1
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
            this.lblCarril1 = new System.Windows.Forms.Label();
            this.lblCarril2 = new System.Windows.Forms.Label();
            this.pgbCarril1 = new System.Windows.Forms.ProgressBar();
            this.pgbCarril2 = new System.Windows.Forms.ProgressBar();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCarril1
            // 
            this.lblCarril1.AutoSize = true;
            this.lblCarril1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarril1.Location = new System.Drawing.Point(12, 9);
            this.lblCarril1.Name = "lblCarril1";
            this.lblCarril1.Size = new System.Drawing.Size(66, 20);
            this.lblCarril1.TabIndex = 0;
            this.lblCarril1.Text = "Carril 1";
            // 
            // lblCarril2
            // 
            this.lblCarril2.AutoSize = true;
            this.lblCarril2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarril2.Location = new System.Drawing.Point(12, 35);
            this.lblCarril2.Name = "lblCarril2";
            this.lblCarril2.Size = new System.Drawing.Size(66, 20);
            this.lblCarril2.TabIndex = 1;
            this.lblCarril2.Text = "Carril 2";
            // 
            // pgbCarril1
            // 
            this.pgbCarril1.Location = new System.Drawing.Point(84, 7);
            this.pgbCarril1.Name = "pgbCarril1";
            this.pgbCarril1.Size = new System.Drawing.Size(648, 22);
            this.pgbCarril1.TabIndex = 2;
            // 
            // pgbCarril2
            // 
            this.pgbCarril2.Location = new System.Drawing.Point(84, 35);
            this.pgbCarril2.Name = "pgbCarril2";
            this.pgbCarril2.Size = new System.Drawing.Size(648, 22);
            this.pgbCarril2.TabIndex = 3;
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(29, 124);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(105, 36);
            this.btnCorrer.TabIndex = 4;
            this.btnCorrer.Text = "Correr";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 185);
            this.Controls.Add(this.btnCorrer);
            this.Controls.Add(this.pgbCarril2);
            this.Controls.Add(this.pgbCarril1);
            this.Controls.Add(this.lblCarril2);
            this.Controls.Add(this.lblCarril1);
            this.Name = "Form1";
            this.Text = "Corredores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarril1;
        private System.Windows.Forms.Label lblCarril2;
        private System.Windows.Forms.ProgressBar pgbCarril1;
        private System.Windows.Forms.ProgressBar pgbCarril2;
        private System.Windows.Forms.Button btnCorrer;
    }
}

