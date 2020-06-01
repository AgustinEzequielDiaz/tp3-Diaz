using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CatalogoDigital;
using Dominio;
using Negocio;

namespace CatalogoWeb_TP3
{
    public partial class Carrito : System.Web.UI.Page
    {
        private List<Articulo> lista { get; set; }
        public Articulo articulo { get; set; }
        List<Articulo> ListaArticulos = new List<Articulo>();
        Carro carro = new Carro();
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (Session[Session.SessionID + "articulo"] != null)
                {
                    carro = (Carro)Session[Session.SessionID + "articulo"];
                    dgvCarrito.DataSource = carro.Productos;
                    dgvCarrito.DataBind();
                    //repetidor2.DataSource = carro.Productos;
                    //repetidor2.DataBind();
                }
            }
            catch (Exception)
            {


            }
        }

        protected void dgvCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        protected void dgvCarrito_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);
                int idProducto = Convert.ToInt32(dgvCarrito.Rows[index].Cells[0].Text);
                articulo = carro.Productos.Find(J => J.Id == idProducto);
                carro.AcumuladorPrecio -= carro.AcumuladorPrecio;
                carro.ContadorArticulo--;
                carro.Productos.Remove(articulo);
                Response.Redirect("Carrito.aspx");
            }
        }

        //protected void btnEliminar_Click(object sender, EventArgs e)
        //{

        //    ArticuloNegocio negocio = new ArticuloNegocio();
        //    Carro carro = new Carro();

        //    try
        //    {

        //        lista = negocio.ListarArticulo2();
        //        var articuloSelec = Convert.ToInt32(((Button)sender).CommandArgument);
        //        articulo = lista.Find(J => J.Id == articuloSelec);
        //        //if (Session[Session.SessionID + "articulo"] != null)
        //        //{
        //        //    carro = (Carro)Session[Session.SessionID + "articulo"];
        //        //}
        //        if (carro.Productos.Exists(A => A.Id == articulo.Id))
        //        {
        //            lista.Remove(articulo);
        //            //carro.AcumuladorPrecio -= articulo.Precio;
        //            //carro.ContadorArticulo--;
        //            Session.Add(Session.SessionID + "articulo", carro);
        //            //Session[Session.SessionID + "lista"] = lista;

        //            Response.Redirect("Carrito.aspx");
        //        }

        //    }
        //    catch (Exception)
        //    {


        //    }

        //}

        //protected void btnEliminar_Click(object sender, EventArgs e)
        //{
        //    ArticuloNegocio negocio = new ArticuloNegocio();
        //    //Carro carro = new Carro();
        //    try
        //    {
        //        lista = negocio.ListarArticulo2();
        //        var articuloSelec = Convert.ToInt32(((Button)sender).CommandArgument);
        //        articulo = lista.Find(J => J.Id == articuloSelec);
        //        if (Session[Session.SessionID + "articulo"] != null)
        //        {
        //            carro = (Carro)Session[Session.SessionID + "articulo"];
        //        }
        //        if (carro.Productos.Exists(A => A.Id == articulo.Id))
        //        {
        //            carro.Productos.Remove(articulo);
        //            //carro.AcumuladorPrecio += articulo.Precio;
        //            //carro.ContadorArticulo++;
        //            Session.Add(Session.SessionID + "articulo", carro);
        //            //Session[Session.SessionID + "carro"] = carro;
        //        }
        //        //Response.Redirect("Carrito.aspx");
        //    }
        //    catch (Exception)
        //    {


        //    }
        //}
    }
}