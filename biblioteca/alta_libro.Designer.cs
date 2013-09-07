namespace biblioteca
{
    partial class alta_libro
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpaginas = new System.Windows.Forms.TextBox();
            this.txtisbn = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblpaginas = new System.Windows.Forms.Label();
            this.lblisbn = new System.Windows.Forms.Label();
            this.cmdguardar = new System.Windows.Forms.Button();
            this.cmdcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(112, 35);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(185, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // txtpaginas
            // 
            this.txtpaginas.Location = new System.Drawing.Point(112, 98);
            this.txtpaginas.Name = "txtpaginas";
            this.txtpaginas.Size = new System.Drawing.Size(185, 20);
            this.txtpaginas.TabIndex = 1;
            // 
            // txtisbn
            // 
            this.txtisbn.Location = new System.Drawing.Point(112, 159);
            this.txtisbn.Name = "txtisbn";
            this.txtisbn.Size = new System.Drawing.Size(185, 20);
            this.txtisbn.TabIndex = 2;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(26, 41);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(47, 13);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre:";
            // 
            // lblpaginas
            // 
            this.lblpaginas.AutoSize = true;
            this.lblpaginas.Location = new System.Drawing.Point(26, 105);
            this.lblpaginas.Name = "lblpaginas";
            this.lblpaginas.Size = new System.Drawing.Size(77, 13);
            this.lblpaginas.TabIndex = 4;
            this.lblpaginas.Text = "Nº de páginas:";
            // 
            // lblisbn
            // 
            this.lblisbn.AutoSize = true;
            this.lblisbn.Location = new System.Drawing.Point(26, 166);
            this.lblisbn.Name = "lblisbn";
            this.lblisbn.Size = new System.Drawing.Size(35, 13);
            this.lblisbn.TabIndex = 5;
            this.lblisbn.Text = "ISBN:";
            // 
            // cmdguardar
            // 
            this.cmdguardar.Location = new System.Drawing.Point(112, 247);
            this.cmdguardar.Name = "cmdguardar";
            this.cmdguardar.Size = new System.Drawing.Size(75, 23);
            this.cmdguardar.TabIndex = 6;
            this.cmdguardar.Text = "Guardar";
            this.cmdguardar.UseVisualStyleBackColor = true;
            this.cmdguardar.Click += new System.EventHandler(this.cmdguardar_Click);
            // 
            // cmdcancelar
            // 
            this.cmdcancelar.Location = new System.Drawing.Point(222, 247);
            this.cmdcancelar.Name = "cmdcancelar";
            this.cmdcancelar.Size = new System.Drawing.Size(75, 23);
            this.cmdcancelar.TabIndex = 7;
            this.cmdcancelar.Text = "Cancelar";
            this.cmdcancelar.UseVisualStyleBackColor = true;
            this.cmdcancelar.Click += new System.EventHandler(this.cmdcancelar_Click);
            // 
            // alta_libro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 304);
            this.Controls.Add(this.cmdcancelar);
            this.Controls.Add(this.cmdguardar);
            this.Controls.Add(this.lblisbn);
            this.Controls.Add(this.lblpaginas);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txtisbn);
            this.Controls.Add(this.txtpaginas);
            this.Controls.Add(this.txtnombre);
            this.Name = "alta_libro";
            this.Text = "Nuevo Libro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpaginas;
        private System.Windows.Forms.TextBox txtisbn;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblpaginas;
        private System.Windows.Forms.Label lblisbn;
        private System.Windows.Forms.Button cmdguardar;
        private System.Windows.Forms.Button cmdcancelar;
    }
}

