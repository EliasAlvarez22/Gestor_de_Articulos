using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
        private AccesoDatos Datos { get; } = new AccesoDatos();


        public void CrearIdDefaultCategoria()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string query = "select count(*) from CATEGORIAS where Descripcion like 'Sin Categoría'";
                datos.SetearQuery(query);
                datos.Abrirconexion();
                int verificador = (int)datos.Comando.ExecuteScalar();
                if (verificador == 0)
                {
                    datos.cerrarConexion();
                    query = "INSERT INTO CATEGORIAS (Descripcion) values('Sin Categoría')";
                    datos.SetearQuery(query);
                    datos.EjecutarNonQuery();
                }
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
        public void AsignarCategoriaDefault(int idCategoria)
        {
            CategoriaNegocio negocio = new();
            AccesoDatos datos = new();
            try
            {
                int idDefault = negocio.BuscarIdDefault();
                string query = "UPDATE ARTICULOS set IdCategoria = @idDefault where IdCategoria= @idCategoriaCambiar";
                datos.SetearQuery(query);
                datos.setearParametros("idDefault", idDefault);
                datos.setearParametros("idCategoriaCambiar", idCategoria);
                datos.EjecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }

        }
        public int BuscarIdDefault()
        {
            try
            {
                CrearIdDefaultCategoria();
                string query = "select Id from CATEGORIAS where Descripcion like 'Sin Categoría'";
                Datos.SetearQuery(query);
                Datos.Abrirconexion();
                int idDefault= (int)Datos.Comando.ExecuteScalar();
                return idDefault;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.cerrarConexion();
            }           
        }
        public List<Categoria> ListarCategorias()
        {
            List<Categoria> Lista = new List<Categoria>();
            try
            {
                CrearIdDefaultCategoria();
                Datos.SetearQuery("SELECT Id, Descripcion FROM CATEGORIAS");
                Datos.EjecutarQuery();
                while (Datos.Lector.Read())
                {
                    Categoria aux = new Categoria
                    {
                        Id = (int)Datos.Lector["Id"],
                        Descripcion = (string)Datos.Lector["Descripcion"],
                    };
                    Lista.Add(aux);
                }
                return Lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }finally { Datos.cerrarConexion();}
        }
        public void AgregarCategoria(Categoria categoria)
        {
            try
            {
                string query = "INSERT INTO CATEGORIAS (Descripcion) values(@descripcion)";
                Datos.SetearQuery(query);
                Datos.setearParametros("@descripcion", categoria.Descripcion);
                Datos.EjecutarNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Datos.cerrarConexion();
            }
        }
        public void ModificarCategoria(Categoria categoria)
        {
            try
            {
                string query = "UPDATE CATEGORIAS SET Descripcion = @descripcion where Id = @id";
                Datos.SetearQuery(query);
                Datos.setearParametros("@descripcion",categoria.Descripcion);
                Datos.setearParametros("@id", categoria.Id);
                Datos.EjecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }finally 
            { Datos.cerrarConexion();}
        }
        public void EliminarCategoria(int id)
        {
            try
            {
                string query = "delete from CATEGORIAS where Id = @id";
                Datos.SetearQuery(query);
                Datos.setearParametros("id", id);
                Datos.EjecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Datos.cerrarConexion() ;
            }
        }
        public int ContarCategoriaEnUso(int id)
        {            
            AccesoDatos datos = new();
            try
            {
                string query = "select count(*) from ARTICULOS art, CATEGORIAS  cat where IdCategoria =  @id and cat.Id = IdCategoria ";
                datos.SetearQuery(query);
                datos.setearParametros("@id", id);
                datos.Abrirconexion();
                int totalMarcas = (int)datos.Comando.ExecuteScalar();
                return totalMarcas;
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
    }
}
