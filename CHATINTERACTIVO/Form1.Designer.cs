namespace CHATINTERACTIVO
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
            this.TxtFrase = new System.Windows.Forms.TextBox();
            this.BTNENVIAR = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pene = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtFrase
            // 
            this.TxtFrase.Location = new System.Drawing.Point(22, 25);
            this.TxtFrase.Name = "TxtFrase";
            this.TxtFrase.Size = new System.Drawing.Size(100, 20);
            this.TxtFrase.TabIndex = 0;
            // 
            // BTNENVIAR
            // 
            this.BTNENVIAR.Location = new System.Drawing.Point(144, 21);
            this.BTNENVIAR.Name = "BTNENVIAR";
            this.BTNENVIAR.Size = new System.Drawing.Size(75, 23);
            this.BTNENVIAR.TabIndex = 1;
            this.BTNENVIAR.Text = "ENVIAR";
            this.BTNENVIAR.UseVisualStyleBackColor = true;
            this.BTNENVIAR.Click += new System.EventHandler(this.BTNENVIAR_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(160, 54);
            this.dataGridView1.TabIndex = 2;
            // 
            // pene
            // 
            this.pene.Location = new System.Drawing.Point(60, 155);
            this.pene.Name = "pene";
            this.pene.Size = new System.Drawing.Size(100, 20);
            this.pene.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pene);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTNENVIAR);
            this.Controls.Add(this.TxtFrase);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtFrase;
        private System.Windows.Forms.Button BTNENVIAR;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pene;
    }
}

