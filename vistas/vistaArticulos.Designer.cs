namespace vistas
{
    partial class vistaArticulos
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
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEliminaciónLógica = new System.Windows.Forms.Button();
            this.btnGestionarMarcas = new System.Windows.Forms.Button();
            this.btnGestionarCategorias = new System.Windows.Forms.Button();
            this.btnSiguienteImagen = new System.Windows.Forms.Button();
            this.btnRetrocederImagen = new System.Windows.Forms.Button();
            this.imgListArticulo = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(23, 34);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(454, 234);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(72, 283);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(191, 234);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(483, 34);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(483, 70);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(124, 30);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(483, 106);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 30);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminaciónLógica
            // 
            this.btnEliminaciónLógica.Location = new System.Drawing.Point(483, 142);
            this.btnEliminaciónLógica.Name = "btnEliminaciónLógica";
            this.btnEliminaciónLógica.Size = new System.Drawing.Size(121, 33);
            this.btnEliminaciónLógica.TabIndex = 4;
            this.btnEliminaciónLógica.Text = "Eliminación Lógica";
            this.btnEliminaciónLógica.UseVisualStyleBackColor = true;
            this.btnEliminaciónLógica.Click += new System.EventHandler(this.btnEliminaciónLógica_Click);
            // 
            // btnGestionarMarcas
            // 
            this.btnGestionarMarcas.Location = new System.Drawing.Point(486, 182);
            this.btnGestionarMarcas.Name = "btnGestionarMarcas";
            this.btnGestionarMarcas.Size = new System.Drawing.Size(117, 33);
            this.btnGestionarMarcas.TabIndex = 5;
            this.btnGestionarMarcas.Text = "Gestionar Marcas";
            this.btnGestionarMarcas.UseVisualStyleBackColor = true;
            this.btnGestionarMarcas.Click += new System.EventHandler(this.btnGestionarMarcas_Click);
            // 
            // btnGestionarCategorias
            // 
            this.btnGestionarCategorias.Location = new System.Drawing.Point(489, 221);
            this.btnGestionarCategorias.Name = "btnGestionarCategorias";
            this.btnGestionarCategorias.Size = new System.Drawing.Size(114, 44);
            this.btnGestionarCategorias.TabIndex = 6;
            this.btnGestionarCategorias.Text = "Gestionar Categorías";
            this.btnGestionarCategorias.UseVisualStyleBackColor = true;
            this.btnGestionarCategorias.Click += new System.EventHandler(this.btnGestionarCategorias_Click);
            // 
            // btnSiguienteImagen
            // 
            this.btnSiguienteImagen.Location = new System.Drawing.Point(188, 523);
            this.btnSiguienteImagen.Name = "btnSiguienteImagen";
            this.btnSiguienteImagen.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteImagen.TabIndex = 7;
            this.btnSiguienteImagen.Text = "Siguiente";
            this.btnSiguienteImagen.UseVisualStyleBackColor = true;
            // 
            // btnRetrocederImagen
            // 
            this.btnRetrocederImagen.Location = new System.Drawing.Point(72, 523);
            this.btnRetrocederImagen.Name = "btnRetrocederImagen";
            this.btnRetrocederImagen.Size = new System.Drawing.Size(75, 23);
            this.btnRetrocederImagen.TabIndex = 8;
            this.btnRetrocederImagen.Text = "Atras";
            this.btnRetrocederImagen.UseVisualStyleBackColor = true;
            // 
            // imgListArticulo
            // 
            this.imgListArticulo.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListArticulo.ImageSize = new System.Drawing.Size(256, 256);
            this.imgListArticulo.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // vistaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.btnRetrocederImagen);
            this.Controls.Add(this.btnSiguienteImagen);
            this.Controls.Add(this.btnGestionarCategorias);
            this.Controls.Add(this.btnGestionarMarcas);
            this.Controls.Add(this.btnEliminaciónLógica);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "vistaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo artículos";
            this.Load += new System.EventHandler(this.vistaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEliminaciónLógica;
        private System.Windows.Forms.Button btnGestionarMarcas;
        private System.Windows.Forms.Button btnGestionarCategorias;
        private System.Windows.Forms.Button btnSiguienteImagen;
        private System.Windows.Forms.Button btnRetrocederImagen;
        private System.Windows.Forms.ImageList imgListArticulo;
    }
}