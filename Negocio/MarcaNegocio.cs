using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {
        private AccesoDatos datos { get; } = new AccesoDatos();
        public List<Marca> ListarMarcas()
        {
            List<Marca> Lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();
            
            try
            {
                CrearIdDefault();
                datos.SetearQuery("SELECT Id, Descripcion FROM MARCAS");
                datos.EjecutarQuery();

                while (datos.Lector.Read())
                {
                    Marca aux = new Marca
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
            finally { datos.cerrarConexion(); }
        }
        // Crea el Id y descripcion de "Sin Marca" si es que no hay ninguno con ese nombre
        public void CrearIdDefault()
        {
            try
            {
                string query = "select count(*) from MARCAS where Descripcion like 'Sin Marca'";
                datos.SetearQuery(query);
                datos.Abrirconexion();
                int verificador = (int)datos.Comando.ExecuteScalar();
                if(verificador == 0)
                {
                    datos.cerrarConexion();
                    query = "INSERT INTO MARCAS (Descripcion) values('Sin Marca')";
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
        public void AsignarMarcaDefault(int id)
        {
            MarcaNegocio negocio = new();
            try
            {
                int idDefault = negocio.BuscarIdDefault();
                string query = "UPDATE ARTICULOS set IdMarca = @idDefault where Id = @id";
                datos.SetearQuery(query);
                datos.setearParametros("idDefault", idDefault);
                datos.setearParametros("id", id);
                datos.EjecutarNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }finally { datos.cerrarConexion();}
            
        }
        public int BuscarIdDefault()
        {
            try
            {
                CrearIdDefault();
                string query = "select Id from MARCAS where Descripcion like 'Sin Marca'";
                datos.SetearQuery(query);
                datos.Abrirconexion();
                int idDefault = (int)datos.Comando.ExecuteScalar();
                return idDefault;
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
        //Cuenta la marca en uso, si tiene usos no se va a poder eliminar porque tiene las referencias de los articulos
        public int ContarMarcaEnUso(int id)
        {
            AccesoDatos datos = new();
            try
            {
                string query = "select count(*) from ARTICULOS art, MARCAS mar where IdMarca =  @id and mar.Id = IdMarca ";
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
        public int ContarMarcas()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                int totalMarcas;
                string query = "select count(*) from MARCAS";
                datos.SetearQuery(query);
                datos.Abrirconexion();
                totalMarcas = (int)datos.Comando.ExecuteScalar();
                return totalMarcas;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { datos.cerrarConexion();}
        }

        public void AgregarMarca(Marca marca)
        {
            try
            {
                string query = "INSERT INTO MARCAS (Descripcion) values (@descripcion)";
                datos.SetearQuery(query);
                datos.setearParametros("@descripcion", marca.Descripcion);
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

        public void ModificarMarca(Marca marca)
        {
            try
            {
                string query = "UPDATE MARCAS SET Descripcion = @descripcion where Id = @id";
                datos.SetearQuery(query);
                datos.setearParametros("@descripcion", marca.Descripcion);
                datos.setearParametros("@id", marca.Id);
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
        public void EliminarMarca (int id)
        {
            try
            {
                string query = "DELETE FROM MARCAS where Id = @id";
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
                datos.cerrarConexion();
            }
        }
    }
}
