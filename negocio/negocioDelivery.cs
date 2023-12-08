using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class negocioDelivery
    {
        public List<OutSide> listarDelivery()
        {
            List<OutSide> lista = new List<OutSide>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select L.ID, L.Nombre, L.Direccion, L.ID_Localidad, L.Descripcion, L.ID_Categoria, L.Barrio as Barrio, Loc.Nombre as Localidad, C.Nombre as Categoria, I.ID_Imagen as ID_Imagen, I.Nombre as Imagen, I.ID as IdFood, L.Afuera as Donde from Locales L inner join Localidades Loc on L.ID_Localidad = Loc.ID_Localidad inner join Categorias C on L.ID_Categoria = C.ID_Categoria inner join Imagenes I on I.ID = L.ID");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    OutSide aux = new OutSide();
                    if ((int)datos.Lector["Donde"] == 0)
                    {
                        aux.id = (int)datos.Lector["ID"];
                        aux.name = (string)datos.Lector["Nombre"];
                        aux.adress = (string)datos.Lector["Direccion"];
                        aux.barrio = (string)datos.Lector["Barrio"];

                        aux.localidad = new Localidad();
                        aux.localidad.id = (int)datos.Lector["Id_Localidad"];
                        aux.localidad.descripcion = (string)datos.Lector["Localidad"];

                        aux.descripcion = (string)datos.Lector["Descripcion"];

                        aux.imagen = new Imagen();
                        aux.imagen.id = (int)datos.Lector["ID_Imagen"];
                        aux.imagen.name = (string)datos.Lector["Imagen"];
                        aux.imagen.Id_Food = (int)datos.Lector["ID"];

                        aux.outside = (int)datos.Lector["Donde"];

                        aux.categoria = new Categoria();
                        aux.categoria.id = (int)datos.Lector["ID_Categoria"];
                        aux.categoria.nombre = (string)datos.Lector["Categoria"];

                        lista.Add(aux);
                    }
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
