using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class NegocioImagen
    {
        public void addImagen(Imagen nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Imagenes(Nombre, ID)values(@name,@id)");
                datos.setearParametro("@name", nuevo.name);
                datos.setearParametro("@id", nuevo.Id_Food);
                datos.ejecutarAcccion();
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
        public void modificarImagen(Imagen imagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Imagenes set Nombre = @nombre where ID = @id_Food");
                datos.setearParametro("@nombre", imagen.name);
                datos.setearParametro("@id_Food", imagen.Id_Food);
                datos.ejecutarAcccion();
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
        public void eliminarImagen(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from Imagenes where ID = @id");
                datos.setearParametro("@id", id);
                datos.ejecutarAcccion();
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
        public Imagen buscarID(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select ID_Imagen, Nombre, ID from Imagenes");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Imagen aux = new Imagen();
                  
                    if ((int)datos.Lector["ID"] == id)
                    {                                                 
                        aux.id = (int)datos.Lector["ID_Imagen"];
                        aux.name = (string)datos.Lector["Nombre"];
                        aux.Id_Food = (int)datos.Lector["ID"];
                        
                        return aux;
                    }
                }
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
            return null;
        }
    }
}
