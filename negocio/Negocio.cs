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

