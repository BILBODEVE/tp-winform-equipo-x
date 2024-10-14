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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vistaArticulos));
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblFiltroMarca = new System.Windows.Forms.Label();
            this.cbFiltroMarca = new System.Windows.Forms.ComboBox();
            this.lblFiltroCategoria = new System.Windows.Forms.Label();
            this.cbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.lblFiltroPrecio = new System.Windows.Forms.Label();
            this.cbFiltroPrecio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.lblDetalleMarca = new System.Windows.Forms.Label();
            this.lblDetalleCategoria = new System.Windows.Forms.Label();
            this.lblDetallePrecio = new System.Windows.Forms.Label();
            this.btnVerDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(26, 97);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(757, 234);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(26, 347);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(191, 234);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 1;
            this.pbImagen.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(802, 97);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(124, 30);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(802, 133);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(124, 30);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(802, 169);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 30);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminaciónLógica
            // 
            this.btnEliminaciónLógica.Location = new System.Drawing.Point(802, 205);
            this.btnEliminaciónLógica.Name = "btnEliminaciónLógica";
            this.btnEliminaciónLógica.Size = new System.Drawing.Size(124, 30);
            this.btnEliminaciónLógica.TabIndex = 4;
            this.btnEliminaciónLógica.Text = "Eliminación Lógica";
            this.btnEliminaciónLógica.UseVisualStyleBackColor = true;
            this.btnEliminaciónLógica.Click += new System.EventHandler(this.btnEliminaciónLógica_Click);
            // 
            // btnGestionarMarcas
            // 
            this.btnGestionarMarcas.Location = new System.Drawing.Point(802, 245);
            this.btnGestionarMarcas.Name = "btnGestionarMarcas";
            this.btnGestionarMarcas.Size = new System.Drawing.Size(124, 30);
            this.btnGestionarMarcas.TabIndex = 5;
            this.btnGestionarMarcas.Text = "Gestionar Marcas";
            this.btnGestionarMarcas.UseVisualStyleBackColor = true;
            this.btnGestionarMarcas.Click += new System.EventHandler(this.btnGestionarMarcas_Click);
            // 
            // btnGestionarCategorias
            // 
            this.btnGestionarCategorias.Location = new System.Drawing.Point(802, 284);
            this.btnGestionarCategorias.Name = "btnGestionarCategorias";
            this.btnGestionarCategorias.Size = new System.Drawing.Size(124, 30);
            this.btnGestionarCategorias.TabIndex = 6;
            this.btnGestionarCategorias.Text = "Gestionar Categorías";
            this.btnGestionarCategorias.UseVisualStyleBackColor = true;
            this.btnGestionarCategorias.Click += new System.EventHandler(this.btnGestionarCategorias_Click);
            // 
            // btnSiguienteImagen
            // 
            this.btnSiguienteImagen.Location = new System.Drawing.Point(142, 587);
            this.btnSiguienteImagen.Name = "btnSiguienteImagen";
            this.btnSiguienteImagen.Size = new System.Drawing.Size(75, 23);
            this.btnSiguienteImagen.TabIndex = 7;
            this.btnSiguienteImagen.Text = "Siguiente";
            this.btnSiguienteImagen.UseVisualStyleBackColor = true;
            this.btnSiguienteImagen.Click += new System.EventHandler(this.btnSiguienteImagen_Click);
            // 
            // btnRetrocederImagen
            // 
            this.btnRetrocederImagen.Location = new System.Drawing.Point(26, 587);
            this.btnRetrocederImagen.Name = "btnRetrocederImagen";
            this.btnRetrocederImagen.Size = new System.Drawing.Size(75, 23);
            this.btnRetrocederImagen.TabIndex = 8;
            this.btnRetrocederImagen.Text = "Atras";
            this.btnRetrocederImagen.UseVisualStyleBackColor = true;
            this.btnRetrocederImagen.Click += new System.EventHandler(this.btnRetrocederImagen_Click);
            // 
            // imgListArticulo
            // 
            this.imgListArticulo.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListArticulo.ImageSize = new System.Drawing.Size(256, 256);
            this.imgListArticulo.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(105, 68);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 20);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblFiltroMarca
            // 
            this.lblFiltroMarca.AutoSize = true;
            this.lblFiltroMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroMarca.Location = new System.Drawing.Point(303, 47);
            this.lblFiltroMarca.Name = "lblFiltroMarca";
            this.lblFiltroMarca.Size = new System.Drawing.Size(50, 18);
            this.lblFiltroMarca.TabIndex = 11;
            this.lblFiltroMarca.Text = "Marca";
            // 
            // cbFiltroMarca
            // 
            this.cbFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroMarca.FormattingEnabled = true;
            this.cbFiltroMarca.Location = new System.Drawing.Point(306, 69);
            this.cbFiltroMarca.Name = "cbFiltroMarca";
            this.cbFiltroMarca.Size = new System.Drawing.Size(158, 21);
            this.cbFiltroMarca.TabIndex = 12;
            this.cbFiltroMarca.SelectedIndexChanged += new System.EventHandler(this.cbFiltroMarca_SelectedIndexChanged);
            // 
            // lblFiltroCategoria
            // 
            this.lblFiltroCategoria.AutoSize = true;
            this.lblFiltroCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblFiltroCategoria.Location = new System.Drawing.Point(470, 47);
            this.lblFiltroCategoria.Name = "lblFiltroCategoria";
            this.lblFiltroCategoria.Size = new System.Drawing.Size(72, 18);
            this.lblFiltroCategoria.TabIndex = 13;
            this.lblFiltroCategoria.Text = "Categoría";
            // 
            // cbFiltroCategoria
            // 
            this.cbFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroCategoria.FormattingEnabled = true;
            this.cbFiltroCategoria.Location = new System.Drawing.Point(473, 69);
            this.cbFiltroCategoria.Name = "cbFiltroCategoria";
            this.cbFiltroCategoria.Size = new System.Drawing.Size(175, 21);
            this.cbFiltroCategoria.TabIndex = 14;
            this.cbFiltroCategoria.SelectedIndexChanged += new System.EventHandler(this.cbFiltroCategoria_SelectedIndexChanged);
            // 
            // lblFiltroPrecio
            // 
            this.lblFiltroPrecio.AutoSize = true;
            this.lblFiltroPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltroPrecio.Location = new System.Drawing.Point(651, 47);
            this.lblFiltroPrecio.Name = "lblFiltroPrecio";
            this.lblFiltroPrecio.Size = new System.Drawing.Size(51, 18);
            this.lblFiltroPrecio.TabIndex = 15;
            this.lblFiltroPrecio.Text = "Precio";
            // 
            // cbFiltroPrecio
            // 
            this.cbFiltroPrecio.FormattingEnabled = true;
            this.cbFiltroPrecio.Location = new System.Drawing.Point(654, 69);
            this.cbFiltroPrecio.Name = "cbFiltroPrecio";
            this.cbFiltroPrecio.Size = new System.Drawing.Size(76, 21);
            this.cbFiltroPrecio.TabIndex = 16;
            this.cbFiltroPrecio.SelectedIndexChanged += new System.EventHandler(this.cbFiltroPrecio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(102, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(24, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Filtrar por:";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.Image")));
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(736, 68);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(47, 23);
            this.btnLimpiarFiltros.TabIndex = 22;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // lblDetalleMarca
            // 
            this.lblDetalleMarca.AutoSize = true;
            this.lblDetalleMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleMarca.Location = new System.Drawing.Point(242, 347);
            this.lblDetalleMarca.Name = "lblDetalleMarca";
            this.lblDetalleMarca.Size = new System.Drawing.Size(58, 18);
            this.lblDetalleMarca.TabIndex = 23;
            this.lblDetalleMarca.Text = "Marca: ";
            // 
            // lblDetalleCategoria
            // 
            this.lblDetalleCategoria.AutoSize = true;
            this.lblDetalleCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalleCategoria.Location = new System.Drawing.Point(242, 393);
            this.lblDetalleCategoria.Name = "lblDetalleCategoria";
            this.lblDetalleCategoria.Size = new System.Drawing.Size(80, 18);
            this.lblDetalleCategoria.TabIndex = 24;
            this.lblDetalleCategoria.Text = "Categoría: ";
            // 
            // lblDetallePrecio
            // 
            this.lblDetallePrecio.AutoSize = true;
            this.lblDetallePrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallePrecio.Location = new System.Drawing.Point(242, 447);
            this.lblDetallePrecio.Name = "lblDetallePrecio";
            this.lblDetallePrecio.Size = new System.Drawing.Size(55, 18);
            this.lblDetallePrecio.TabIndex = 25;
            this.lblDetallePrecio.Text = "Precio:";
            // 
            // btnVerDetalle
            // 
            this.btnVerDetalle.Location = new System.Drawing.Point(243, 558);
            this.btnVerDetalle.Name = "btnVerDetalle";
            this.btnVerDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnVerDetalle.TabIndex = 26;
            this.btnVerDetalle.Text = "Ver detalle";
            this.btnVerDetalle.UseVisualStyleBackColor = true;
            this.btnVerDetalle.Click += new System.EventHandler(this.btnVerDetalle_Click);
            // 
            // vistaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(988, 621);
            this.Controls.Add(this.btnVerDetalle);
            this.Controls.Add(this.lblDetallePrecio);
            this.Controls.Add(this.lblDetalleCategoria);
            this.Controls.Add(this.lblDetalleMarca);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFiltroPrecio);
            this.Controls.Add(this.lblFiltroPrecio);
            this.Controls.Add(this.cbFiltroCategoria);
            this.Controls.Add(this.lblFiltroCategoria);
            this.Controls.Add(this.cbFiltroMarca);
            this.Controls.Add(this.lblFiltroMarca);
            this.Controls.Add(this.txtBuscar);
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
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblFiltroMarca;
        private System.Windows.Forms.ComboBox cbFiltroMarca;
        private System.Windows.Forms.Label lblFiltroCategoria;
        private System.Windows.Forms.ComboBox cbFiltroCategoria;
        private System.Windows.Forms.Label lblFiltroPrecio;
        private System.Windows.Forms.ComboBox cbFiltroPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label lblDetalleMarca;
        private System.Windows.Forms.Label lblDetalleCategoria;
        private System.Windows.Forms.Label lblDetallePrecio;
        private System.Windows.Forms.Button btnVerDetalle;
    }
}