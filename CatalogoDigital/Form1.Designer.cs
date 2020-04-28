namespace CatalogoDigital
{
    partial class FormCatalogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCatalogo));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.GBListados = new System.Windows.Forms.GroupBox();
            this.rbtnCategorias = new System.Windows.Forms.RadioButton();
            this.rbtnMarcas = new System.Windows.Forms.RadioButton();
            this.rbtnArticulos = new System.Windows.Forms.RadioButton();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.picArt = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.GBListados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AllowUserToResizeColumns = false;
            this.dgvArticulos.AllowUserToResizeRows = false;
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Enabled = false;
            this.dgvArticulos.Location = new System.Drawing.Point(12, 75);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(392, 264);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvArticulos_MouseClick);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Enabled = false;
            this.txtBusqueda.Location = new System.Drawing.Point(52, 49);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(198, 20);
            this.txtBusqueda.TabIndex = 7;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 52);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(35, 13);
            this.lblFiltro.TabIndex = 8;
            this.lblFiltro.Text = "Filtrar:";
            // 
            // GBListados
            // 
            this.GBListados.Controls.Add(this.rbtnCategorias);
            this.GBListados.Controls.Add(this.rbtnMarcas);
            this.GBListados.Controls.Add(this.rbtnArticulos);
            this.GBListados.Location = new System.Drawing.Point(15, 1);
            this.GBListados.Name = "GBListados";
            this.GBListados.Size = new System.Drawing.Size(389, 42);
            this.GBListados.TabIndex = 9;
            this.GBListados.TabStop = false;
            this.GBListados.Text = "Listados";
            // 
            // rbtnCategorias
            // 
            this.rbtnCategorias.AutoSize = true;
            this.rbtnCategorias.Location = new System.Drawing.Point(267, 19);
            this.rbtnCategorias.Name = "rbtnCategorias";
            this.rbtnCategorias.Size = new System.Drawing.Size(75, 17);
            this.rbtnCategorias.TabIndex = 2;
            this.rbtnCategorias.TabStop = true;
            this.rbtnCategorias.Text = "Categorias";
            this.rbtnCategorias.UseVisualStyleBackColor = true;
            this.rbtnCategorias.CheckedChanged += new System.EventHandler(this.rbtnCategorias_CheckedChanged);
            this.rbtnCategorias.Click += new System.EventHandler(this.rbtnCategorias_Click);
            // 
            // rbtnMarcas
            // 
            this.rbtnMarcas.AutoSize = true;
            this.rbtnMarcas.Location = new System.Drawing.Point(150, 19);
            this.rbtnMarcas.Name = "rbtnMarcas";
            this.rbtnMarcas.Size = new System.Drawing.Size(60, 17);
            this.rbtnMarcas.TabIndex = 1;
            this.rbtnMarcas.TabStop = true;
            this.rbtnMarcas.Text = "Marcas";
            this.rbtnMarcas.UseVisualStyleBackColor = true;
            this.rbtnMarcas.CheckedChanged += new System.EventHandler(this.rbtnMarcas_CheckedChanged);
            this.rbtnMarcas.Click += new System.EventHandler(this.rbtnMarcas_Click);
            // 
            // rbtnArticulos
            // 
            this.rbtnArticulos.AutoSize = true;
            this.rbtnArticulos.Location = new System.Drawing.Point(37, 19);
            this.rbtnArticulos.Name = "rbtnArticulos";
            this.rbtnArticulos.Size = new System.Drawing.Size(65, 17);
            this.rbtnArticulos.TabIndex = 0;
            this.rbtnArticulos.TabStop = true;
            this.rbtnArticulos.Text = "Articulos";
            this.rbtnArticulos.UseVisualStyleBackColor = true;
            this.rbtnArticulos.CheckedChanged += new System.EventHandler(this.rbtnArticulos_CheckedChanged);
            this.rbtnArticulos.Click += new System.EventHandler(this.rbtnArticulos_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Image = global::CatalogoDigital.Properties.Resources.add_item_25362__2_;
            this.btnAgregar.Location = new System.Drawing.Point(419, 75);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(59, 56);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = global::CatalogoDigital.Properties.Resources.documentediting_editdocuments_text_documentedi_2820;
            this.btnModificar.Location = new System.Drawing.Point(475, 128);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(59, 56);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnListar.Enabled = false;
            this.btnListar.Image = global::CatalogoDigital.Properties.Resources.checklist_123014;
            this.btnListar.Location = new System.Drawing.Point(419, 128);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(59, 56);
            this.btnListar.TabIndex = 4;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = global::CatalogoDigital.Properties.Resources._32officeicons_3_89720;
            this.btnEliminar.Location = new System.Drawing.Point(475, 75);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(59, 56);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // picArt
            // 
            this.picArt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picArt.Location = new System.Drawing.Point(419, 223);
            this.picArt.MaximumSize = new System.Drawing.Size(112, 224);
            this.picArt.MinimumSize = new System.Drawing.Size(106, 98);
            this.picArt.Name = "picArt";
            this.picArt.Size = new System.Drawing.Size(112, 116);
            this.picArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picArt.TabIndex = 1;
            this.picArt.TabStop = false;
            // 
            // FormCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 351);
            this.Controls.Add(this.GBListados);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.picArt);
            this.Controls.Add(this.dgvArticulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1015, 600);
            this.MinimumSize = new System.Drawing.Size(562, 390);
            this.Name = "FormCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "";
            this.Text = "Catalogo ";
            this.Load += new System.EventHandler(this.FormCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.GBListados.ResumeLayout(false);
            this.GBListados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picArt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox picArt;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.GroupBox GBListados;
        public System.Windows.Forms.RadioButton rbtnCategorias;
        public System.Windows.Forms.RadioButton rbtnMarcas;
        public System.Windows.Forms.RadioButton rbtnArticulos;
    }
}

