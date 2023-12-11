using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class Negocio
    {      
        
        
        public void modificar(OutSide local)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Locales set Nombre = @nombre , Direccion = @direccion, Barrio = @barrio, ID_Localidad = @id_Localidad, Descripcion = @descripcion,ID_Categoria = @id_Categoria where ID = @id");
                datos.setearParametro("@nombre", local.name);
                datos.setearParametro("@direccion",local.adress);
                datos.setearParametro("@barrio", local.barrio);
                datos.setearParametro("@id_Localidad",local.localidad.id);
                datos.setearParametro("@descripcion",local.descripcion);
                datos.setearParametro("@id_Categoria",local.categoria.id);
                datos.setearParametro("@id",local.id);
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
        
        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from Locales where ID = @id");
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
       
        public void modificarCook(Cooking cocina)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Cocinar set Nombre = @nombre , Descripcion = @descripcion, ID_Categoria = @id_Categoria where ID_Cocinar = @id");
                datos.setearParametro("@nombre", cocina.nombre);
                datos.setearParametro("@descripcion", cocina.descripcion);
                datos.setearParametro("@id_Categoria", cocina.categoria);
                datos.setearParametro("@id", cocina.id);
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

