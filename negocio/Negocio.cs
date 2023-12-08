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
        public List<OutSide> listarOutSide()
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
                    if ((int)datos.Lector["Donde"] == 1)
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
        public List<OutSide> listarConSP()
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
        public List<Cooking> listarHome()
        {
            List<Cooking> lista = new List<Cooking>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select C.ID as ID, C.Nombre as Nombre, C.Descripcion as Descripcion, Cat.Nombre as Categoria, I.Nombre as Imagen ,I.ID_Imagen as IDImagen, Cat.ID_Categoria as ID_Categoria from Cocinar C inner join Categorias Cat on Cat.ID_Categoria = C.ID_Categoria inner join Imagenes I on I.ID = C.ID");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Cooking aux = new Cooking();
                    aux.id = (int)datos.Lector["ID"];
                    aux.nombre = (string)datos.Lector["Nombre"];                                  
                    aux.descripcion = (string)datos.Lector["Descripcion"];

                    aux.imagen = new Imagen();
                    aux.imagen.id = (int)datos.Lector["IDImagen"];
                    aux.imagen.name = (string)datos.Lector["Imagen"];

                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["ID_Categoria"];
                    aux.categoria.nombre = (string)datos.Lector["Categoria"];

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
                datos.setearConsulta("insert into Cocinar(Nombre, Descripcion, ID_Categoria)values(@nombre, @descripcion, @categoria)");
                datos.setearParametro("@nombre", nuevo.nombre);
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
        public void addOut(OutSide nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Locales(Nombre, Direccion,Barrio , ID_Localidad, Descripcion, ID_Categoria, Afuera)values(@nombre, @direccion,@barrio, @localidad, @descripcion, @categoria, 1)");
                datos.setearParametro("@nombre", nuevo.name);
                datos.setearParametro("@direccion", nuevo.adress);
                datos.setearParametro("@barrio", nuevo.barrio);
                datos.setearParametro("@localidad", nuevo.localidad.id);
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
        public void addOut0(OutSide nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("insert into Locales(Nombre, Direccion,Barrio , ID_Localidad, Descripcion, ID_Categoria, Afuera)values(@nombre, @direccion,@barrio, @localidad, @descripcion, @categoria, 0)");
                datos.setearParametro("@nombre", nuevo.name);
                datos.setearParametro("@direccion", nuevo.adress);
                datos.setearParametro("@barrio", nuevo.barrio);
                datos.setearParametro("@localidad", nuevo.localidad.id);
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
        public void modificarImagen(Imagen imagen)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update Imagenes set Nombre = @nombre where ID_Imagen = @id and ID = @id_Food");
                datos.setearParametro("@id", imagen.id);
                datos.setearParametro("@nombre", imagen.name);
                datos.setearParametro("@id_Food",imagen.Id_Food);
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
        public List<Categoria> listarCategoria()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select ID_Categoria, Nombre from Categorias");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.id = (int)datos.Lector["ID_Categoria"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    lista.Add(aux);
                }
                return lista;
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
        public List<Localidad> listarLocalidad()
        {
            List<Localidad> lista = new List<Localidad>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select ID_Localidad, Nombre from Localidades");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Localidad aux = new Localidad();
                    aux.id = (int)datos.Lector["ID_Localidad"];
                    aux.descripcion = (string)datos.Lector["Nombre"];
                    lista.Add(aux);
                }
                return lista;
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
        public int UltimoRegistro()
        {
            List<OutSide> lista = new List<OutSide>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select ID as id from Locales");
                datos.ejecutarLectura();
                int aux = new int();

                while (datos.Lector.Read())
                {
                    aux = (int)datos.Lector["id"];                    
                }
                return aux;
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
        public int UltimoRegistroCocina()
        {
            List<Cooking> lista = new List<Cooking>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("select ID_Cocinar as id from Cocinar");
                datos.ejecutarLectura();
                int aux = new int();

                while (datos.Lector.Read())
                {
                    aux = (int)datos.Lector["id"];
                }
                return aux;
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

