namespace vistas
{
    partial class agregarCategoria
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
            this.lblNuevaCategoria = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.txtNuevaCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNuevaCategoria
            // 
            this.lblNuevaCategoria.AutoSize = true;
            this.lblNuevaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCategoria.Location = new System.Drawing.Point(60, 24);
            this.lblNuevaCategoria.Name = "lblNuevaCategoria";
            this.lblNuevaCategoria.Size = new System.Drawing.Size(197, 16);
            this.lblNuevaCategoria.TabIndex = 5;
            this.lblNuevaCategoria.Text = "Ingrese el nombre de categoria:";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(83, 79);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(123, 30);
            this.btnAgregarCategoria.TabIndex = 4;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // txtNuevaCategoria
            // 
            this.txtNuevaCategoria.Location = new System.Drawing.Point(83, 53);
            this.txtNuevaCategoria.Name = "txtNuevaCategoria";
            this.txtNuevaCategoria.Size = new System.Drawing.Size(121, 20);
            this.txtNuevaCategoria.TabIndex = 3;
            // 
            // agregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 156);
            this.Controls.Add(this.lblNuevaCategoria);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.txtNuevaCategoria);
            this.Name = "agregarCategoria";
            this.Text = "agregarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox txtNuevaCategoria;
    }
}