using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CatalogoDigital;
using Dominio;
using Negocio;

namespace CatalogoWeb_TP3
{
    public partial class _Default : Page
    {
        public List<Articulo> lista { get; set; }
        public Articulo articulo = new Articulo();
        ArticuloNegocio negocio = new ArticuloNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {

                lista = negocio.ListarArticulo2();

                if (!IsPostBack)
                {   
                    //pregunto si es la primera carga de la page
                    //esto es lo que necesitamos para el repeater.
                    repetidor.DataSource = lista;
                    repetidor.DataBind();
                }


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void btnSeleccionar_Click(object sender, EventArgs e)
        {

            ArticuloNegocio negocio = new ArticuloNegocio();
            Carro carro = new Carro();

            try
            {

                lista = negocio.ListarArticulo2();
                var articuloSelec = Convert.ToInt32(((Button)sender).CommandArgument);
                articulo = lista.Find(J => J.Id == articuloSelec);
                if (Session[Session.SessionID + "articulo"] != null)
                {
                    carro = (Carro)Session[Session.SessionID + "articulo"];
                }
                if (!carro.Productos.Exists(A => A.Id == articulo.Id))
                {
                    carro.Productos.Add(articulo);
                    carro.AcumuladorPrecio += articulo.Precio;
                    carro.ContadorArticulo++;
                    Session.Add(Session.SessionID + "articulo", carro);
                }

            }
            catch (Exception)
            {


            }

        }

        protected void Filtrar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            try
            {
                lista = negocio.ListarArticulo2();
                if (txtFiltrar.Text == "")
                {
                    listaFiltrada = lista;
                    Session.Add(Session.SessionID + "filtrado", listaFiltrada);
                    repetidor.DataSource = listaFiltrada;
                    repetidor.DataBind();

                }
                else
                {
                    listaFiltrada = lista.FindAll(k => k.Nombre.ToLower().Contains(txtFiltrar.Text.ToLower()) ||
                      k.Marca.DescMarca.ToLower().Contains(txtFiltrar.Text.ToLower()) ||
                      k.Categoria.DescCat.ToLower().Contains(txtFiltrar.Text.ToLower()) ||
                      k.Codigo.ToLower().Contains(txtFiltrar.Text.ToLower()));
                    Session.Add(Session.SessionID + "filtrado", listaFiltrada);
                    repetidor.DataSource = listaFiltrada;
                    repetidor.DataBind();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }

}
