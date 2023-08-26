using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Globalization;
using System.Security.AccessControl;
using System.Xml.Schema;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public int ContarArticulos()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                int total;
                string query = "select count(*) from ARTICULOS";
                datos.SetearQuery(query);
                datos.Abrirconexion();
                total = (int)datos.Comando.ExecuteScalar();
                return total;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string query = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.ImagenUrl, A.Precio, M.Id AS IdMarca, C.Id AS IdCategoria from dbo.ARTICULOS A, dbo.CATEGORIAS C, dbo.MARCAS M where A.IdMarca = M.Id AND A.IdCategoria = C.Id";

                datos.SetearQuery(query);
                datos.EjecutarQuery();
                SqlDataReader lector = datos.Lector;

                while (lector.Read())
                {
                    Articulo articulo = new Articulo
                    {
                        Id = (int)lector["Id"],
                        CodigoArticulo = (string)lector["Codigo"],
                        Nombre = (string)lector["Nombre"],
                        Descripcion = (string)lector["Descripcion"],
                        Precio = (decimal)lector["Precio"],
                        ImagenUrl = lector["ImagenUrl"] is DBNull ? null : (string)lector["ImagenUrl"],
                        Marca = new Marca
                        {
                            Id = (int)lector["IdMarca"],
                            Descripcion = (string)lector["Marca"],
                        },
                        Categoria = new Categoria
                        {
                            Id = (int)lector["IdCategoria"],
                            Descripcion = (string)lector["Categoria"],
                        },
                    };
                    lista.Add(articulo);

                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally { datos.cerrarConexion(); }
        }

        public void Agregar(Articulo Nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("insert into ARTICULOS(Codigo,Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values" +
                    "( @codigoArticulo,@nombre,@descripcion,@IdMarca,@IdCategoria,@Url,@precio)");                
                datos.setearParametros("@codigoArticulo", Nuevo.CodigoArticulo);
                datos.setearParametros("@nombre", Nuevo.Nombre);
                datos.setearParametros("@descripcion", Nuevo.Descripcion);                
                datos.setearParametros("@IdMarca", Nuevo.Marca.Id);                
                datos.setearParametros("@IdCategoria", Nuevo.Categoria.Id);                
                datos.setearParametros("@url", Nuevo.ImagenUrl);
                datos.setearParametros("@precio", Nuevo.Precio);
                datos.EjecutarNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ModificarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.SetearQuery("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion," +
                " IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @imagenUrl, Precio = @precio where Id = @id");

                datos.setearParametros("@codigo", articulo.CodigoArticulo);
                datos.setearParametros("@nombre", articulo.Nombre);
                datos.setearParametros("@descripcion", articulo.Descripcion);
                datos.setearParametros("@idMarca", articulo.Marca.Id);
                datos.setearParametros("@idCategoria", articulo.Categoria.Id);
                datos.setearParametros("@imagenUrl", articulo.ImagenUrl);
                datos.setearParametros("@precio", articulo.Precio);
                datos.setearParametros("@id", articulo.Id);
                datos.EjecutarNonQuery();
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
                datos.SetearQuery("delete from ARTICULOS where Id = @id");
                datos.setearParametros("@id", id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }
        public List<Articulo> Filtrar(string campo, string criterio, string filtro)
        {

            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string query = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.ImagenUrl, A.Precio, M.Id AS IdMarca, C.Id AS IdCategoria from dbo.ARTICULOS A, dbo.CATEGORIAS C, dbo.MARCAS M where A.IdMarca = M.Id AND A.IdCategoria = C.Id And ";



                if (campo == "Precio")
                {
                    switch (criterio)
                    {

                        case "Mayor a":
                            query += " A.Precio > " + filtro;
                            break;
                        case "Menor a":
                            query += "A.Precio < " + filtro;
                            break;
                        case "Igual que":
                            query += "A.Precio = " + filtro;
                            break;
                        default:
                            break;
                    }
                }
                if(campo == "Código")
                {
                    query += "A.Codigo like '" + filtro + "'";
                }
                if(campo == "Categorías")
                {
                    query += " C.Descripcion like '" + criterio + "'";
                }
                if (campo == "Marcas")
                {
                    query += " M.Descripcion like '" + criterio + "'";
                }
                



                    datos.SetearQuery(query);
                datos.EjecutarQuery();
                SqlDataReader lector = datos.Lector;

                while (lector.Read())
                {
                    Articulo articulo = new Articulo
                    {
                        Id = (int)lector["Id"],
                        CodigoArticulo = (string)lector["Codigo"],
                        Nombre = (string)lector["Nombre"],
                        Descripcion = (string)lector["Descripcion"],
                        Precio = (decimal)lector["Precio"],
                        ImagenUrl = lector["ImagenUrl"] is DBNull ? null : (string)lector["ImagenUrl"],
                        Marca = new Marca
                        {
                            Id = (int)lector["IdMarca"],
                            Descripcion = (string)lector["Marca"],
                        },
                        Categoria = new Categoria
                        {
                            Id = (int)lector["IdCategoria"],
                            Descripcion = (string)lector["Categoria"],
                        },
                    };
                    lista.Add(articulo);

                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally { datos.cerrarConexion(); }
        }
    }
}
    

