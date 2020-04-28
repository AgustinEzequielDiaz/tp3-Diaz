using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace CatalogoDigital
{
    public partial class frmAlta : Form
    {
        private Articulo articulo = null; 
        FormCatalogo form = new FormCatalogo();
        ArticuloNegocio negocio = new ArticuloNegocio();
        public frmAlta()
        {
            InitializeComponent();
        }

        public frmAlta(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo(); 
                }
                articulo.Codigo = txtCodigo.Text.Trim();
                articulo.Nombre = txtNombre.Text.Trim();
                articulo.Descripcion = txtDesc.Text.Trim();
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.ImagenURL = txtURL.Text.Trim();
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text.Trim());

                if(articulo.Id != 0)
                {
                    if (MessageBox.Show("¿Finalizar modificacion?", "Modificar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        negocio.modificar(articulo);
                }
                else
                {
                    ValidarTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Dispose();
        }

        private void frmAlta_Load(object sender, EventArgs e)
        {
            CargarDatosAlta();
            form.setToolTip(btnAceptar, "Aceptar");
            form.setToolTip(btnCancelar, "Cancelar");
        }

        private void CargarDatosAlta()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            MarcaNegocio marca = new MarcaNegocio();
            try
            {
                cboMarca.DataSource = marca.ListarMarca();
                cboMarca.DisplayMember = "DescMarca";
                cboMarca.ValueMember = "Id";
                cboMarca.SelectedIndex = -1;

                cboCategoria.DataSource = categoria.ListarCategoria();
                cboCategoria.DisplayMember = "DescCat"; 
                cboCategoria.ValueMember = "IdCat";
                cboCategoria.SelectedIndex = -1;
                
                if (articulo != null)
                {
                    Text = "Modificar";
                    lblTitulo.Text = "MODIFICAR ARTICULO";
                    picTitulo.ImageLocation = "https://icon-icons.com/icons2/34/PNG/48/documentediting_editdocuments_text_documentedi_2820.png";
                    txtNombre.Text = articulo.Nombre;
                    txtDesc.Text = articulo.Descripcion;
                    txtCodigo.Text = articulo.Codigo;
                    txtURL.Text = articulo.ImagenURL;
                    txtPrecio.Text = Convert.ToString(articulo.Precio);
                    if (articulo.Marca != null)
                    {
                        cboMarca.SelectedValue = articulo.Marca.Id;
                    }

                    if (articulo.Categoria != null)
                    {
                        cboCategoria.SelectedValue = articulo.Categoria.IdCat;
                    } 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ValidarTextBox()
        {
            int contador = 0;

            if (txtCodigo.Text.Length == 0)
            {
                contador++;
            }


            if (txtNombre.Text.Length == 0)
            { 
                contador++;
            }


            if (txtDesc.Text.Length == 0)
            {
                contador++;
            }

            if (cboCategoria.Text.Length == 0)
            {
                contador++;
            }

            if (cboMarca.Text.Length == 0)
            {
                contador++;
            }
            if (contador == 0)
                if(MessageBox.Show("¿Finalizar alta?", "Alta", MessageBoxButtons.YesNo) == DialogResult.Yes)
                negocio.Agregar(articulo);
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            lblAsteriscoCod.Visible = false;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            lblAsterisoNombre.Visible = false;
        }

        private void cboMarca_TextChanged(object sender, EventArgs e)
        {
            lblAsteriscoMarca.Visible = false;
        }

        private void cboCategoria_TextChanged(object sender, EventArgs e)
        {
            lblAsteriscoCategoria.Visible = false;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            lblAsteriscoPrecio.Visible = false;
        }
    }
}
                   


                


