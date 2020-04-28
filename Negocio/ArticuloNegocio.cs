using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalogoDigital;
using Dominio;
using System.Data.SqlClient;
using System.Linq.Expressions;


namespace Negocio
{
    public class ArticuloNegocio
    { 
        public List<Articulo> ListarArticulo2()
        {
            List<Articulo> ListadoArticulo = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.ImagenUrl, A.Precio, M.Descripcion as DescMarca, M.Id as IdMarca, C.Descripcion as DescCat, C.Id as IdCat From ARTICULOS as A Inner Join MARCAS as M on M.Id = A.IdMarca Inner join CATEGORIAS as C on C.Id = A.IdCategoria");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = datos.lector.GetInt32(0);
                    aux.Codigo = datos.lector.GetString(1);
                    aux.Nombre = datos.lector.GetString(2);
                    aux.Descripcion = datos.lector.GetString(3);
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.lector["IdMarca"];
                    aux.Marca.DescMarca = (string)datos.lector["DescMarca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCat = (int)datos.lector["IdCat"];
                    aux.Categoria.DescCat = (string)datos.lector["DescCat"];
                    aux.ImagenURL = datos.lector.GetString(6);
                    aux.Precio = Decimal.Round((decimal)datos.lector["Precio"], 2);
                    ListadoArticulo.Add(aux);
                
                }
                return ListadoArticulo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void EliminarArticulo(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from ARTICULOS where id=" + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("Update ARTICULOS set Codigo=@Codigo,Nombre=@Nombre, Descripcion=@Descripcion, ImagenURL=@ImagenURL, Precio=@Precio where Id=@Id");
                datos.agregarParametro("@Codigo", articulo.Codigo);
                datos.agregarParametro("@Nombre", articulo.Nombre);
                datos.agregarParametro("@Id", articulo.Id);
                datos.agregarParametro("@Descripcion", articulo.Descripcion);
                datos.agregarParametro("@ImagenURL", articulo.ImagenURL);
                datos.agregarParametro("@Precio", articulo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                datos.setearQuery("insert into ARTICULOS (Nombre, Codigo, Descripcion, IdCategoria, IdMarca, ImagenURL, Precio) Values (@Nombre,@Codigo,@Descripcion,@IdCategoria,@IdMarca,@ImagenURL,@Precio)");
               
                datos.agregarParametro("@Nombre", nuevo.Nombre);
                datos.agregarParametro("@Codigo", nuevo.Codigo);
                datos.agregarParametro("@Descripcion", nuevo.Descripcion);
                datos.agregarParametro("@IdCategoria", nuevo.Categoria.IdCat); ;
                datos.agregarParametro("@IdMarca", nuevo.Marca.Id);
                datos.agregarParametro("@ImagenURL", nuevo.ImagenURL);
                datos.agregarParametro("@Precio", nuevo.Precio);
                datos.ejecutarAccion();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}





