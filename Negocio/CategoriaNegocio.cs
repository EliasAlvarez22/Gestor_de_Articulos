using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {

        public List<Categoria> ListarCategorias()
        {
            List<Categoria> Lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();

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
    }
}
