namespace ObtenerUUID
{
    partial class formObtenerUUID
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
            this.btObtenerUUID = new System.Windows.Forms.Button();
            this.txtUUID = new System.Windows.Forms.TextBox();
            this.btCopiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btObtenerUUID
            // 
            this.btObtenerUUID.Location = new System.Drawing.Point(12, 17);
            this.btObtenerUUID.Name = "btObtenerUUID";
            this.btObtenerUUID.Size = new System.Drawing.Size(91, 29);
            this.btObtenerUUID.TabIndex = 0;
            this.btObtenerUUID.Text = "Obtener UUID";
            this.btObtenerUUID.UseVisualStyleBackColor = true;
            this.btObtenerUUID.Click += new System.EventHandler(this.btObtenerUUID_Click);
            // 
            // txtUUID
            // 
            this.txtUUID.Location = new System.Drawing.Point(109, 22);
            this.txtUUID.Name = "txtUUID";
            this.txtUUID.Size = new System.Drawing.Size(382, 20);
            this.txtUUID.TabIndex = 1;
            // 
            // btCopiar
            // 
            this.btCopiar.Location = new System.Drawing.Point(503, 22);
            this.btCopiar.Name = "btCopiar";
            this.btCopiar.Size = new System.Drawing.Size(54, 23);
            this.btCopiar.TabIndex = 2;
            this.btCopiar.Text = "Copiar";
            this.btCopiar.UseVisualStyleBackColor = true;
            this.btCopiar.Click += new System.EventHandler(this.btCopiar_Click);
            // 
            // formObtenerUUID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 70);
            this.Controls.Add(this.btCopiar);
            this.Controls.Add(this.txtUUID);
            this.Controls.Add(this.btObtenerUUID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formObtenerUUID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obtener Identificador de dispositivo - ProyectoA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btObtenerUUID;
        private System.Windows.Forms.TextBox txtUUID;
        private System.Windows.Forms.Button btCopiar;
    }
}

