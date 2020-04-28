using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        public List<Marca> ListarMarca()
        {
            List<Marca> ListadoMarca = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("SELECT Id, Descripcion from MARCAS");
                datos.ejecutarLector();
                while (datos.lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = datos.lector.GetInt32(0);
                    aux.DescMarca = datos.lector.GetString(1);
                    ListadoMarca.Add(aux);
                }
                return ListadoMarca;
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

        public void EliminarMarca(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearQuery("delete from MARCAS where id=" + id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void ModificarMarca(Marca marca)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("Update MARCAS set Descripcion=@Descripcion where Id=@Id");
                datos.agregarParametro("@Id", marca.Id);
                datos.agregarParametro("@Descripcion", marca.DescMarca);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AgregarMarca(Marca nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearQuery("insert into MARCAS (Descripcion) Values (@Descripcion)");
                datos.agregarParametro("@Descripcion", nuevo.DescMarca);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
