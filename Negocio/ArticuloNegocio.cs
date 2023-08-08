using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using System.Globalization;

namespace Negocio
{
    public class ArticuloNegocio
    {
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

            } finally { datos.cerrarConexion(); }
        }

        public void Agregar (Articulo Nuevo)
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
                datos.InsertarDB();


            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
    

