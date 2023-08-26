using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class MarcaNegocio
    {

        public List<Marca> ListarMarcas()
        {
            List<Marca> Lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
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
        }
    }
}
