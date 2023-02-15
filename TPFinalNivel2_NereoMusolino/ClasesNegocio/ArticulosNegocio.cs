using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesDominio;


namespace ClasesNegocio
{
    public class ArticulosNegocio
    {
        public List<Articulos> Listar()
        {
            AccesoDatos acceso = new AccesoDatos();
            List<Articulos> lista = new List<Articulos>();

            try
            {
                acceso.setearConsulta("select A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, M.Descripcion as Marca, C.Descripcion as Categoria, A.ImagenUrl, A.Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id");
                acceso.ejecutarConsulta();

                while (acceso.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.MarcaArticulo = new Marca();
                    aux.CategoriaArticulo = new Categoria();
                    if (!(acceso.Lector["Codigo"] is DBNull))
                        aux.CodigoArticulo = (string)acceso.Lector["Codigo"];
                    if (!(acceso.Lector["Nombre"] is DBNull))
                        aux.Nombre = acceso.Lector["Nombre"].ToString();
                    if (!(acceso.Lector["Descripcion"] is DBNull)) 
                        aux.Descripcion = (string)acceso.Lector["Descripcion"];
                    if (!(acceso.Lector["IdMarca"] is DBNull))
                        aux.MarcaArticulo.Id = (int)acceso.Lector["IdMarca"];
                    if (!(acceso.Lector["Marca"] is DBNull)) 
                        aux.MarcaArticulo.Descripcion = acceso.Lector["Marca"].ToString();
                    if (!(acceso.Lector["IdCategoria"] is DBNull)) 
                        aux.CategoriaArticulo.Id = (int)acceso.Lector["IdCategoria"];
                    if (!(acceso.Lector["Categoria"] is DBNull)) 
                        aux.CategoriaArticulo.Descripcion = acceso.Lector["Categoria"].ToString();
                    if (!(acceso.Lector["ImagenUrl"] is DBNull)) 
                        aux.UrlImagen = (string)acceso.Lector["ImagenUrl"];
                    if (!(acceso.Lector["Precio"] is DBNull)) 
                        aux.Precio = float.Parse(acceso.Lector["Precio"].ToString());

                    lista.Add(aux);
                }

                return lista;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                acceso.cerrarConsulta();
            }
        }

        public void Agregar (Articulos obj)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                //datos.setearConsulta("insert into ARTICULOS ");
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
