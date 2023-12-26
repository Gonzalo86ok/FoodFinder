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
                datos.setearConsulta("select c.ID, c.Nombre, c.Descripcion,c.Receta, ca.Nombre, ca.ID_CategoriaCook, I.ID_Imagen as ID_Imagen, I.Nombre as Imagen, I.ID as IdFood from Cocinar c inner join CategoriasCook ca on ca.ID_CategoriaCook = c.ID_CategoriaCook inner join Imagenes I on I.ID = c.ID ORDER BY c.Nombre ASC\r\n");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cooking aux = new Cooking();
                    
                    aux.id = (int)datos.Lector["ID"];
                    aux.nombre = (string)datos.Lector["Nombre"];                                           
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.receta = (string)datos.Lector["Receta"];

                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["ID_CategoriaCook"];
                    aux.categoria.nombre = (string)datos.Lector["Nombre"];

                    aux.imagen = new Imagen();
                    aux.imagen.id = (int)datos.Lector["ID_Imagen"];
                    aux.imagen.name = (string)datos.Lector["Imagen"];
                    aux.imagen.Id_Food = (int)datos.Lector["ID"];

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
        public void addCook(Cooking nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Cocinar(Nombre, Receta, Descripcion, ID_CategoriaCook)values(@nombre,@receta, @descripcion,2)");
                datos.setearParametro("@nombre", nuevo.nombre);
                datos.setearParametro("@receta", nuevo.receta);
                datos.setearParametro("@descripcion", nuevo.descripcion);
                datos.setearParametro("@categoria", nuevo.categoria.id);
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
        public int ultimoID()
        {
            int ultimo = new int();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select ID from Cocinar");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    ultimo = (int)datos.Lector["ID"];
                }
                return ultimo;
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
        public void modificar(Cooking local)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Cocinar set Nombre = @nombre, Receta = @receta,Descripcion = @descripcion, ID_Categoria = @id_Categoria where ID = @id");
                datos.setearParametro("@nombre", local.nombre);                               
                datos.setearParametro("@receta", local.receta);
                datos.setearParametro("@descripcion", local.descripcion);
                datos.setearParametro("@id_Categoria", local.categoria.id);
                datos.setearParametro("@id", local.id);
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
        public Cooking buscarID(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select c.ID, c.Nombre, c.Descripcion,c.Receta, ca.Nombre, ca.ID_CategoriaCook from Cocinar c inner join CategoriasCook ca on ca.ID_CategoriaCook = c.ID_CategoriaCook");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Cooking aux = new Cooking();
                    if ((int)datos.Lector["ID"] == id)
                    {
                        aux.id = (int)datos.Lector["ID"];
                        aux.nombre = (string)datos.Lector["Nombre"];
                        aux.receta = (string)datos.Lector["Receta"];
                        aux.descripcion = (string)datos.Lector["Descripcion"];

                        aux.imagen = new Imagen();
                        aux.imagen.id = (int)datos.Lector["ID_Imagen"];
                        aux.imagen.name = (string)datos.Lector["Imagen"];
                        aux.imagen.Id_Food = (int)datos.Lector["ID"];

                        aux.categoria = new Categoria();
                        aux.categoria.id = (int)datos.Lector["ID_CategoriaCook"];
                        aux.categoria.nombre = (string)datos.Lector["Categoria"];

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
