using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;


namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> ListarCategoria()
        {
            List<Categoria> ListadoCategoria = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.IdCat = datos.lector.GetInt32(0);
                    aux.DescCat = datos.lector.GetString(1);
                   
                    ListadoCategoria.Add(aux);
                }
                return ListadoCategoria;
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

        public void EliminarCategoria(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from CATEGORIAS where id=" + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarCategoria(Categoria categoria)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("Update CATEGORIAS set Descripcion=@Descripcion where Id=@Id");
                datos.agregarParametro("@Id", categoria.IdCat);
                datos.agregarParametro("@Descripcion", categoria.DescCat);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarCategoria(Categoria nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("insert into CATEGORIAS (Descripcion) Values (@Descripcion)");

                datos.agregarParametro("@Descripcion", nuevo.DescCat);
                
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
