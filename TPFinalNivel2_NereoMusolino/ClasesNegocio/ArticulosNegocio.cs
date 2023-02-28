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
                acceso.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, M.Descripcion as Marca, C.Descripcion as Categoria, A.ImagenUrl, A.Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id and Activo = 1");
                acceso.ejecutarConsulta();

                while (acceso.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.MarcaArticulo = new Marca();
                    aux.CategoriaArticulo = new Categoria();

                    if (!(acceso.Lector["Id"] is DBNull))
                        aux.Id = (int)acceso.Lector["Id"];
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
                        aux.Precio = acceso.Lector["Precio"].ToString();

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

        public List<Articulos> ListarPapelera()
        {
            AccesoDatos acceso = new AccesoDatos();
            List<Articulos> lista = new List<Articulos>();

            try
            {
                acceso.setearConsulta("select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, M.Descripcion as Marca, C.Descripcion as Categoria, A.ImagenUrl, A.Precio from ARTICULOS A, MARCAS M, CATEGORIAS C where A.IdMarca = M.Id and A.IdCategoria = C.Id and Activo = 0");
                acceso.ejecutarConsulta();

                while (acceso.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.MarcaArticulo = new Marca();
                    aux.CategoriaArticulo = new Categoria();

                    if (!(acceso.Lector["Id"] is DBNull))
                        aux.Id = (int)acceso.Lector["Id"];
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
                        aux.Precio = acceso.Lector["Precio"].ToString();

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
                datos.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values (@codigo,@nombre,@descripcion,@marca,@categoria,@url,@precio)");
                datos.setearParametros("@codigo", obj.CodigoArticulo);
                datos.setearParametros("@nombre", obj.Nombre);
                datos.setearParametros("@descripcion", obj.Descripcion);
                datos.setearParametros("@marca", obj.MarcaArticulo.Id);
                datos.setearParametros("@categoria", obj.CategoriaArticulo.Id);
                datos.setearParametros("@url", obj.UrlImagen);
                datos.setearParametros("@precio", obj.Precio);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConsulta();
            }
        }
        
        public void Modificar(Articulos aux)
        {
            AccesoDatos datos = new AccesoDatos();           
            try
            {
                datos.setearConsulta("Update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagenUrl, Precio = @precio where Id = @id and Activo = 1");
                datos.setearParametros("@id", aux.Id);
                datos.setearParametros("@codigo", aux.CodigoArticulo);
                datos.setearParametros("@nombre", aux.Nombre);
                datos.setearParametros("@descripcion", aux.Descripcion);
                datos.setearParametros("@idMarca", aux.MarcaArticulo.Id);
                datos.setearParametros("@idCategoria", aux.CategoriaArticulo.Id);
                datos.setearParametros("@imagenUrl", aux.UrlImagen);
                datos.setearParametros("@precio", aux.Precio);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConsulta();
            }
        }
        
        public void EliminarLogico(Articulos obj)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update ARTICULOS set Activo = 0 where Id = @Id");
                datos.setearParametros("@Id", obj.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConsulta();
            }
        }

        public void Restaurar(Articulos obj)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Update ARTICULOS set Activo = 1 where Id = @Id");
                datos.setearParametros("@Id", obj.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConsulta();
            }
        }

        public void EliminarFisico(Articulos obj)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Delete from ARTICULOS where Id = @Id");
                datos.setearParametros("@Id", obj.Id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConsulta();
            }
        }
    }
}
