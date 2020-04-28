namespace CatalogoDigital
{
    partial class frmAlta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlta));
            this.cboMarca = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblAsteriscoDesc = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.lblAsteriscoCod = new System.Windows.Forms.Label();
            this.lblAsterisoNombre = new System.Windows.Forms.Label();
            this.lblAsteriscoMarca = new System.Windows.Forms.Label();
            this.lblAsteriscoCategoria = new System.Windows.Forms.Label();
            this.lblAsteriscoPrecio = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.picTitulo = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).BeginInit();
            this.SuspendLayout();
            // 
            // cboMarca
            // 
            this.cboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMarca.FormattingEnabled = true;
            this.cboMarca.Location = new System.Drawing.Point(119, 182);
            this.cboMarca.Name = "cboMarca";
            this.cboMarca.Size = new System.Drawing.Size(311, 21);
            this.cboMarca.TabIndex = 2;
            this.cboMarca.TextChanged += new System.EventHandler(this.cboMarca_TextChanged);
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(119, 220);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(311, 21);
            this.cboCategoria.TabIndex = 3;
            this.cboCategoria.TextChanged += new System.EventHandler(this.cboCategoria_TextChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(35, 78);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 4;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(35, 115);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // lblAsteriscoDesc
            // 
            this.lblAsteriscoDesc.AutoSize = true;
            this.lblAsteriscoDesc.Location = new System.Drawing.Point(35, 148);
            this.lblAsteriscoDesc.Name = "lblAsteriscoDesc";
            this.lblAsteriscoDesc.Size = new System.Drawing.Size(63, 13);
            this.lblAsteriscoDesc.TabIndex = 6;
            this.lblAsteriscoDesc.Text = "Descripcion";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(35, 185);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 7;
            this.lblMarca.Text = "Marca";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(35, 223);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 8;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(119, 75);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(311, 20);
            this.txtCodigo.TabIndex = 9;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(119, 112);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(311, 20);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(119, 145);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(311, 20);
            this.txtDesc.TabIndex = 11;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(119, 257);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(311, 20);
            this.txtURL.TabIndex = 12;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(119, 289);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(311, 20);
            this.txtPrecio.TabIndex = 13;
            this.txtPrecio.TextChanged += new System.EventHandler(this.txtPrecio_TextChanged);
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(35, 260);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(73, 13);
            this.lblURL.TabIndex = 14;
            this.lblURL.Text = "Imagen (URL)";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(35, 292);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 15;
            this.lblPrecio.Text = "Precio";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoEllipsis = true;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Lime;
            this.lblTitulo.Location = new System.Drawing.Point(69, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(263, 31);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "ARTICULO NUEVO";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Image = global::CatalogoDigital.Properties.Resources.add_icon_icons_com_74429;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(436, 212);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(33, 34);
            this.btnAgregarCategoria.TabIndex = 19;
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            // 
            // lblAsteriscoCod
            // 
            this.lblAsteriscoCod.AutoSize = true;
            this.lblAsteriscoCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoCod.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAsteriscoCod.Location = new System.Drawing.Point(6, 75);
            this.lblAsteriscoCod.Name = "lblAsteriscoCod";
            this.lblAsteriscoCod.Size = new System.Drawing.Size(23, 29);
            this.lblAsteriscoCod.TabIndex = 20;
            this.lblAsteriscoCod.Text = "*";
            // 
            // lblAsterisoNombre
            // 
            this.lblAsterisoNombre.AutoSize = true;
            this.lblAsterisoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsterisoNombre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAsterisoNombre.Location = new System.Drawing.Point(6, 112);
            this.lblAsterisoNombre.Name = "lblAsterisoNombre";
            this.lblAsterisoNombre.Size = new System.Drawing.Size(23, 29);
            this.lblAsterisoNombre.TabIndex = 21;
            this.lblAsterisoNombre.Text = "*";
            // 
            // lblAsteriscoMarca
            // 
            this.lblAsteriscoMarca.AutoSize = true;
            this.lblAsteriscoMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoMarca.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAsteriscoMarca.Location = new System.Drawing.Point(6, 182);
            this.lblAsteriscoMarca.Name = "lblAsteriscoMarca";
            this.lblAsteriscoMarca.Size = new System.Drawing.Size(23, 29);
            this.lblAsteriscoMarca.TabIndex = 23;
            this.lblAsteriscoMarca.Text = "*";
            // 
            // lblAsteriscoCategoria
            // 
            this.lblAsteriscoCategoria.AutoSize = true;
            this.lblAsteriscoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoCategoria.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAsteriscoCategoria.Location = new System.Drawing.Point(6, 223);
            this.lblAsteriscoCategoria.Name = "lblAsteriscoCategoria";
            this.lblAsteriscoCategoria.Size = new System.Drawing.Size(23, 29);
            this.lblAsteriscoCategoria.TabIndex = 24;
            this.lblAsteriscoCategoria.Text = "*";
            // 
            // lblAsteriscoPrecio
            // 
            this.lblAsteriscoPrecio.AutoSize = true;
            this.lblAsteriscoPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsteriscoPrecio.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAsteriscoPrecio.Location = new System.Drawing.Point(6, 289);
            this.lblAsteriscoPrecio.Name = "lblAsteriscoPrecio";
            this.lblAsteriscoPrecio.Size = new System.Drawing.Size(23, 29);
            this.lblAsteriscoPrecio.TabIndex = 26;
            this.lblAsteriscoPrecio.Text = "*";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNota.Location = new System.Drawing.Point(8, 367);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(145, 17);
            this.lblNota.TabIndex = 27;
            this.lblNota.Text = "* Campos obligatorios";
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Image = global::CatalogoDigital.Properties.Resources.add_icon_icons_com_74429;
            this.btnAgregarMarca.Location = new System.Drawing.Point(436, 174);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(33, 35);
            this.btnAgregarMarca.TabIndex = 18;
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            // 
            // picTitulo
            // 
            this.picTitulo.ErrorImage = global::CatalogoDigital.Properties.Resources._1491253396_5document_image_82883__1_;
            this.picTitulo.ImageLocation = "https://icon-icons.com/icons2/217/PNG/48/add-item_25362.png";
            this.picTitulo.InitialImage = global::CatalogoDigital.Properties.Resources.load_a_icon_icons_com_50113;
            this.picTitulo.Location = new System.Drawing.Point(19, 3);
            this.picTitulo.Name = "picTitulo";
            this.picTitulo.Size = new System.Drawing.Size(44, 50);
            this.picTitulo.TabIndex = 16;
            this.picTitulo.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Image = global::CatalogoDigital.Properties.Resources.cancel_77947;
            this.btnCancelar.Location = new System.Drawing.Point(282, 330);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 37);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.Image = global::CatalogoDigital.Properties.Resources.check_ok_accept_apply_1582;
            this.btnAceptar.Location = new System.Drawing.Point(190, 330);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(50, 37);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAlta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 403);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblAsteriscoPrecio);
            this.Controls.Add(this.lblAsteriscoCategoria);
            this.Controls.Add(this.lblAsteriscoMarca);
            this.Controls.Add(this.lblAsterisoNombre);
            this.Controls.Add(this.lblAsteriscoCod);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.btnAgregarMarca);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.picTitulo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblAsteriscoDesc);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboMarca);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(497, 442);
            this.Name = "frmAlta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo Articulo";
            this.Load += new System.EventHandler(this.frmAlta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTitulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cboMarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblAsteriscoDesc;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.PictureBox picTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Label lblAsteriscoCod;
        private System.Windows.Forms.Label lblAsterisoNombre;
        private System.Windows.Forms.Label lblAsteriscoMarca;
        private System.Windows.Forms.Label lblAsteriscoCategoria;
        private System.Windows.Forms.Label lblAsteriscoPrecio;
        private System.Windows.Forms.Label lblNota;
    }
}