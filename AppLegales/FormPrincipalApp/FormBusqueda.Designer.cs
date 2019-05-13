namespace FormPrincipalApp
{
    partial class FormBusqueda
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblBusquedaPorNombre = new System.Windows.Forms.Label();
            this.lblBusquedaPorDni = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblBusquedaPorNombre
            // 
            this.lblBusquedaPorNombre.AutoSize = true;
            this.lblBusquedaPorNombre.Location = new System.Drawing.Point(12, 29);
            this.lblBusquedaPorNombre.Name = "lblBusquedaPorNombre";
            this.lblBusquedaPorNombre.Size = new System.Drawing.Size(113, 13);
            this.lblBusquedaPorNombre.TabIndex = 2;
            this.lblBusquedaPorNombre.Text = "Busqueda por Nombre";
            // 
            // lblBusquedaPorDni
            // 
            this.lblBusquedaPorDni.AutoSize = true;
            this.lblBusquedaPorDni.Location = new System.Drawing.Point(267, 29);
            this.lblBusquedaPorDni.Name = "lblBusquedaPorDni";
            this.lblBusquedaPorDni.Size = new System.Drawing.Size(92, 13);
            this.lblBusquedaPorDni.TabIndex = 3;
            this.lblBusquedaPorDni.Text = "Busqueda por Dni";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(270, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(427, 43);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // FormBusqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 82);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblBusquedaPorDni);
            this.Controls.Add(this.lblBusquedaPorNombre);
            this.Controls.Add(this.textBox1);
            this.Name = "FormBusqueda";
            this.Text = "FormBusqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblBusquedaPorNombre;
        private System.Windows.Forms.Label lblBusquedaPorDni;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnBuscar;
    }
}