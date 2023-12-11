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
                datos.setearConsulta("update Imagenes set Nombre = @nombre where ID_Imagen = @id and ID = @id_Food");
                datos.setearParametro("@id", imagen.id);
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
    }
}
