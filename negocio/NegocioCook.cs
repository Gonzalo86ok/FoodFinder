using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class NegocioCook
    {
        public List<Cooking> listarCook()
        {
            List<Cooking> lista = new List<Cooking>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select c.ID, c.Nombre, c.Descripcion, ca.Nombre, ca.ID_Categoria from Cocinar c inner join Categorias ca on ca.ID_Categoria = c.ID_Categoria");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cooking aux = new Cooking();
                    
                        aux.id = (int)datos.Lector["ID"];
                        aux.nombre = (string)datos.Lector["Nombre"];                                           
                        aux.descripcion = (string)datos.Lector["Descripcion"];               

                        aux.categoria = new Categoria();
                        aux.categoria.id = (int)datos.Lector["ID_Categoria"];
                        aux.categoria.nombre = (string)datos.Lector["Nombre"];

                        lista.Add(aux);                  
                }
                return lista;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
