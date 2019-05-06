namespace VistaForm
{
    partial class FormMenu
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
            this.btnLlamada = new System.Windows.Forms.Button();
            this.btnFacturacionTotal = new System.Windows.Forms.Button();
            this.btnLocal = new System.Windows.Forms.Button();
            this.btnProvincial = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlamada
            // 
            this.btnLlamada.Location = new System.Drawing.Point(12, 12);
            this.btnLlamada.Name = "btnLlamada";
            this.btnLlamada.Size = new System.Drawing.Size(284, 58);
            this.btnLlamada.TabIndex = 0;
            this.btnLlamada.Text = "Generar Llamada";
            this.btnLlamada.UseVisualStyleBackColor = true;
            this.btnLlamada.Click += new System.EventHandler(this.btnLlamada_Click);
            // 
            // btnFacturacionTotal
            // 
            this.btnFacturacionTotal.Location = new System.Drawing.Point(12, 76);
            this.btnFacturacionTotal.Name = "btnFacturacionTotal";
            this.btnFacturacionTotal.Size = new System.Drawing.Size(284, 58);
            this.btnFacturacionTotal.TabIndex = 1;
            this.btnFacturacionTotal.Text = "Facturacion Total";
            this.btnFacturacionTotal.UseVisualStyleBackColor = true;
            this.btnFacturacionTotal.Click += new System.EventHandler(this.btnFacturacionTotal_Click);
            // 
            // btnLocal
            // 
            this.btnLocal.Location = new System.Drawing.Point(12, 140);
            this.btnLocal.Name = "btnLocal";
            this.btnLocal.Size = new System.Drawing.Size(284, 58);
            this.btnLocal.TabIndex = 2;
            this.btnLocal.Text = "Facturacion Local";
            this.btnLocal.UseVisualStyleBackColor = true;
            // 
            // btnProvincial
            // 
            this.btnProvincial.Location = new System.Drawing.Point(12, 204);
            this.btnProvincial.Name = "btnProvincial";
            this.btnProvincial.Size = new System.Drawing.Size(284, 58);
            this.btnProvincial.TabIndex = 3;
            this.btnProvincial.Text = "Facturacion Provincial";
            this.btnProvincial.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 267);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(284, 58);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 338);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProvincial);
            this.Controls.Add(this.btnLocal);
            this.Controls.Add(this.btnFacturacionTotal);
            this.Controls.Add(this.btnLlamada);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefonica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlamada;
        private System.Windows.Forms.Button btnFacturacionTotal;
        private System.Windows.Forms.Button btnLocal;
        private System.Windows.Forms.Button btnProvincial;
        private System.Windows.Forms.Button btnSalir;
    }
}

