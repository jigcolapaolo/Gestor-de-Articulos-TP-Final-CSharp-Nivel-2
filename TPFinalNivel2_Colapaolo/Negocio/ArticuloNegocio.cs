using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT  Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.IdMarca, A.IdCategoria, A.Id  FROM ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND Precio > 0");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.Id = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    if (!(datos.Lector["IdMarca"] is DBNull))
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    if (!(datos.Lector["IdCategoria"] is DBNull))
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    if (!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> listarPapelera()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();

            try
            {
                datos.setearConsulta("SELECT  Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.IdMarca, A.IdCategoria, A.Id  FROM ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND Precio = 0");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    if (!(datos.Lector["IdMarca"] is DBNull))
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    if (!(datos.Lector["IdCategoria"] is DBNull))
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    if (!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@codigo, @nombre, @descripcion, @idMarca, @idCategoria, @imagenUrl, @precio)");
                datos.setearParametros("@codigo", nuevo.Codigo);
                datos.setearParametros("@nombre", nuevo.Nombre);
                datos.setearParametros("@descripcion", nuevo.Descripcion);
                datos.setearParametros("@idMarca", nuevo.Marca.Id);
                datos.setearParametros("@idCategoria", nuevo.Categoria.Id);
                datos.setearParametros("@imagenUrl", nuevo.ImagenUrl);
                datos.setearParametros("@precio", nuevo.Precio);
                datos.ejecutarAccion();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio WHERE Id = @Id");
                datos.setearParametros("@Codigo", articulo.Codigo);
                datos.setearParametros("@Nombre", articulo.Nombre);
                datos.setearParametros("@Descripcion", articulo.Descripcion);
                datos.setearParametros("@IdMarca", articulo.Marca.Id);
                datos.setearParametros("@IdCategoria", articulo.Categoria.Id);
                datos.setearParametros("@ImagenUrl", articulo.ImagenUrl);
                datos.setearParametros("@Precio", articulo.Precio);
                datos.setearParametros("@Id", articulo.Id);
                datos.ejecutarAccion();

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminarPapelera(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Precio = 0 WHERE Id = @Id");
                datos.setearParametros("@Id", articulo.Id);

                datos.ejecutarAccion();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void recuperar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Precio = 1 WHERE Id = @Id");
                datos.setearParametros("@Id", articulo.Id);

                datos.ejecutarAccion();

            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datos.setearParametros("@Id", articulo.Id);

                datos.ejecutarAccion();
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulo> filtrar(string campo, string condicion, string filtro)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();

            try
            {

                string consulta = "SELECT  Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.IdMarca, A.IdCategoria, A.Id  FROM ARTICULOS A, CATEGORIAS C, MARCAS M WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND Precio > 0 AND ";

                if(campo == "Precio")
                {
                    switch (condicion)
                    {
                        case "Mayor a..":
                            consulta += "Precio > " + filtro;
                            break;
                        case "Menor a..":
                            consulta += "Precio < " + filtro;
                            break;
                        default:
                            consulta += "Precio = " + filtro;
                            break;
                    }
                }
                else if(campo == "Código")
                {
                    switch (condicion)
                    {
                        case "Empieza con..":
                            consulta += "Codigo LIKE '" + filtro + "%'";
                            break;
                        case "Termina con..":
                            consulta += "Codigo LIKE '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Codigo LIKE '%" + filtro + "%'";
                            break;
                    }
                }
                else if(campo == "Nombre")
                {
                    switch (condicion)
                    {
                        case "Empieza con..":
                            consulta += "Nombre LIKE '" + filtro + "%'";
                            break;
                        case "Termina con..":
                            consulta += "Nombre LIKE '%" + filtro + "'";
                            break;
                        default:
                            consulta += "Nombre LIKE '%" + filtro + "%'";
                            break;
                    }
                }
                else if(campo == "Descripción")
                {
                    switch (condicion)
                    {
                        case "Empieza con..":
                            consulta += "A.Descripcion LIKE '" + filtro + "%'";
                            break;
                        case "Termina con..":
                            consulta += "A.Descripcion LIKE '%" + filtro + "'";
                            break;
                        default:
                            consulta += "A.Descripcion LIKE '%" + filtro + "%'";
                            break;

                    }
                }
                else if (campo == "Marca")
                {
                    switch (condicion)
                    {
                        case "Empieza con..":
                            consulta += "M.Descripcion LIKE '" + filtro + "%'";
                            break;
                        case "Termina con..":
                            consulta += "M.Descripcion LIKE '%" + filtro + "'";
                            break;
                        default:
                            consulta += "M.Descripcion LIKE '%" + filtro + "%'";
                            break;
                    }
                }
                else
                {
                    switch (condicion)
                    {
                        case "Empieza con..":
                            consulta += "C.Descripcion LIKE '" + filtro + "%'";
                            break;
                        case "Termina con..":
                            consulta += "C.Descripcion LIKE '%" + filtro + "'";
                            break;
                        default:
                            consulta += "C.Descripcion LIKE '%" + filtro + "%'";
                            break;

                    }
                }



                datos.setearConsulta(consulta);
                datos.ejecutarLectura();


                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    if (!(datos.Lector["Codigo"] is DBNull))
                        aux.Codigo = (string)datos.Lector["Codigo"];
                    if (!(datos.Lector["Nombre"] is DBNull))
                        aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    if (!(datos.Lector["IdMarca"] is DBNull))
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    if (!(datos.Lector["Marca"] is DBNull))
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    if (!(datos.Lector["IdCategoria"] is DBNull))
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    if (!(datos.Lector["Categoria"] is DBNull))
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    if (!(datos.Lector["Precio"] is DBNull))
                        aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception e)
            {

                throw e;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        
    }
}
