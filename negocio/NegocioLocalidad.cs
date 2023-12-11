using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class NegocioLocalidad
    {
        public List<Localidad> listarLocalidad()
        {
            List<Localidad> lista = new List<Localidad>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select * from Localidades");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Localidad aux = new Localidad();

                    aux.id = (int)datos.Lector["Id_Localidad"];
                    aux.descripcion = (string)datos.Lector["Nombre"];
                       
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
