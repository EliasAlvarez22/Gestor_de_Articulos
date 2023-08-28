using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        private AccesoDatos datos { get; } = new AccesoDatos();
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> Lista = new List<Categoria>();
            try
            {
                datos.SetearQuery("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.EjecutarQuery();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria
                    {
                        Id = (int)datos.Lector["Id"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                    };
                    Lista.Add(aux);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AgregarCategoria(Categoria categoria)
        {
            try
            {
                string query = "INSERT INTO CATEGORIAS (Descripcion) values(@descripcion)";
                datos.SetearQuery(query);
                datos.setearParametros("@descripcion", categoria.Descripcion);
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
        public void ModificarCategoria(Categoria categoria)
        {
            try
            {
                string query = "UPDATE CATEGORIAS SET Descripcion = @descripcion where Id = @id";
                datos.SetearQuery(query);
                datos.setearParametros("@descripcion",categoria.Descripcion);
                datos.setearParametros("@id", categoria.Id);
                datos.EjecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }finally 
            { datos.cerrarConexion();}
        }
        public void EliminarCategoria(int id)
        {
            try
            {
                string query = "delete from CATEGORIAS where Id = @id";
                datos.SetearQuery(query);
                datos.setearParametros("id", id);
                datos.EjecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion() ;
            }
        }
    }
}
