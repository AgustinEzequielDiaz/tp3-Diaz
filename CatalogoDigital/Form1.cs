using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CatalogoDigital
{
    public partial class FormCatalogo : Form
    {
        private List<Articulo> lista;
        private List<Marca> listaMarca;
        private List<Categoria> listaCategoria;

        public FormCatalogo()
        {
            InitializeComponent();
        }

        private void FormCatalogo_Load(object sender, EventArgs e)
        {
         
        }

        private void cargarDatos()
        { 
            ArticuloNegocio negocio = new ArticuloNegocio();
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            try
            {
                if(rbtnArticulos.Checked == true)
                {
                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = true;
                    btnListar.Enabled = true;
                    btnEliminar.Enabled = true;
                    dgvArticulos.Enabled = true;
                    btnAgregar.Visible = true;
                    btnListar.Visible = true;
                    btnModificar.Visible = true;
                    setToolTip(btnListar, "Listar");
                    setToolTip(btnModificar, "Modificar");
                    setToolTip(btnEliminar, "Eliminar");
                    setToolTip(btnAgregar, "Agregar");
                    picArt.Visible = true;
                    lista =negocio.ListarArticulo2();
                    dgvArticulos.DataSource = lista;
                    dgvArticulos.Columns[0].Visible = false;
                    dgvArticulos.Columns[3].Visible = false;
                    dgvArticulos.Columns[6].Visible = false;
                }
                else if(rbtnMarcas.Checked == true)
                {
                    btnAgregar.Visible = false;
                    btnListar.Visible = false;
                    btnModificar.Visible = false;
                    picArt.Visible = false;
                    listaMarca =negocioMarca.ListarMarca();
                    dgvArticulos.DataSource = listaMarca;
                    dgvArticulos.Columns[0].Visible = true;
                }
                else if(rbtnCategorias.Checked == true)
                {
                    btnAgregar.Visible = false;
                    btnListar.Visible = false;
                    btnModificar.Visible = false;
                    picArt.Visible = false;
                    listaCategoria = negocioCategoria.ListarCategoria();
                    dgvArticulos.DataSource = listaCategoria;    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dgvArticulos_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbtnArticulos.Checked == true)
            {
                try
                {
                    Articulo art;
                    art = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    picArt.Load(art.ImagenURL);
                }
                catch (Exception)
                {
                    picArt.Load("https://icon-icons.com/icons2/564/PNG/48/Add_Image_icon-icons.com_54218.png");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlta alta = new frmAlta();

            if (rbtnArticulos.Checked == true)
            {
                alta.ShowDialog();
                cargarDatos();
            }       
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo modificar;
            modificar = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            frmAlta frmModificar = new frmAlta(modificar);
            if (rbtnArticulos.Checked == true)
            {
                frmModificar.Text = "Modificar Articulo";
                frmModificar.ShowDialog();
                cargarDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Seguro que desea eliminar?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (rbtnArticulos.Checked == true)
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    try
                    {
                        int id = ((Articulo)dgvArticulos.CurrentRow.DataBoundItem).Id;
                        negocio.EliminarArticulo(id);
                        cargarDatos();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }
                }
                else if(rbtnMarcas.Checked == true)
                {
                    MarcaNegocio negocio = new MarcaNegocio();
                    try
                    {
                        int id = ((Marca)dgvArticulos.CurrentRow.DataBoundItem).Id;
                        negocio.EliminarMarca(id);
                        cargarDatos();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }
                }
                else if(rbtnCategorias.Checked == true)
                {
                    CategoriaNegocio negocio = new CategoriaNegocio();
                    try
                    {
                        int id = ((Categoria)dgvArticulos.CurrentRow.DataBoundItem).IdCat;
                        negocio.EliminarCategoria(id);
                        cargarDatos();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (rbtnArticulos.Checked == true)
            {
                try
                {
                    List<Articulo> ListaFiltrada;
                    if (txtBusqueda.Text == "")
                    {
                        ListaFiltrada = lista;
                    }
                    else
                    {
                        ListaFiltrada = lista.FindAll(k => k.Nombre.ToLower().Contains(txtBusqueda.Text.ToLower()) ||
                        k.Marca.DescMarca.ToLower().Contains(txtBusqueda.Text.ToLower()) ||
                        k.Categoria.DescCat.ToLower().Contains(txtBusqueda.Text.ToLower()) ||
                        k.Codigo.ToLower().Contains(txtBusqueda.Text.ToLower()));
                    }
                    dgvArticulos.DataSource = ListaFiltrada;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void setToolTip(System.Windows.Forms.Control e, string texto)
        {
           ToolTip toolTip1 = new ToolTip();
            
           toolTip1.AutoPopDelay = 5000;
           toolTip1.InitialDelay = 500;
           toolTip1.ReshowDelay = 500;
           toolTip1.ShowAlways = true;
           toolTip1.SetToolTip(e, texto);
        }

        private void rbtnArticulos_CheckedChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void rbtnMarcas_CheckedChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void rbtnCategorias_CheckedChanged(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void rbtnArticulos_Click(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = true;
        }

        private void rbtnMarcas_Click(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = false;
        }

        private void rbtnCategorias_Click(object sender, EventArgs e)
        {
            txtBusqueda.Enabled = false;
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente funcionara para ver los detalles, no se saco porque quedan mejor visualmente los botones");
        }
    }
}

            

