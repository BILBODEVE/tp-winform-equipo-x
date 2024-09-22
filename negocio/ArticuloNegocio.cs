using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Runtime.Remoting.Messaging;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos consulta = new AccesoDatos();
            try
            {
                consulta.SetQuery("SELECT A.Id, I.IdArticulo, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.Precio, A.Activo, I.ImagenUrl, M.Id, M.Descripcion, C.Id, C.Descripcion FROM ARTICULOS A, IMAGENES I, MARCAS M, CATEGORIAS C WHERE I.IdArticulo = A.Id AND A.IdMarca = M.Id AND A.IdCategoria = C.Id AND A.Activo = @activo");
                consulta.setParametro("@activo", true);
                consulta.Leer();

                while (consulta.Reader.Read())
                {
                    Articulo articuloAuxiliar = new Articulo();

                    articuloAuxiliar.Id = (int)consulta.Reader["Id"];
                    articuloAuxiliar.Codigo = (string)consulta.Reader["Codigo"];
                    articuloAuxiliar.Nombre = (string)consulta.Reader["Nombre"];
                    articuloAuxiliar.Descripcion = (string)consulta.Reader["Descripcion"];
                    articuloAuxiliar.Marca.Id = (int)consulta.Reader["IdMarca"];
                    articuloAuxiliar.Marca.Descripcion = (string)consulta.Reader["Descripcion"];
                    articuloAuxiliar.Categoria.Id = (int)consulta.Reader["IdCategoria"];
                    articuloAuxiliar.Categoria.Descripcion = (string)consulta.Reader["Descripcion"];
                    articuloAuxiliar.Precio = (decimal)consulta.Reader["Precio"];
                    articuloAuxiliar.Imagen.ImagenUrl = (string)consulta.Reader["ImagenUrl"];

                    articulos.Add(articuloAuxiliar);
                }
                return articulos;
            }
            catch (Exception ex)
            {
                throw ex; 
            }
            finally
            {
                consulta.Cerrar();
            }
        }
        public void Cargar(Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetQuery("INSERT into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.setParametro("@Codigo", nuevoArticulo.Codigo);
                datos.setParametro("@Nombre", nuevoArticulo.Nombre);
                datos.setParametro("@Descripcion", nuevoArticulo.Descripcion);
                datos.setParametro("@IdMarca", nuevoArticulo.Marca.Id);
                datos.setParametro("@IdCategoria", nuevoArticulo.Categoria.Id);
                datos.setParametro("@Precio", nuevoArticulo.Precio);

                datos.EjecutarAccion();

                int idArticulo = ObtenerId(nuevoArticulo.Codigo);

                ImagenNegocio imagenNegocio = new ImagenNegocio();
                imagenNegocio.Insertar(idArticulo, nuevoArticulo.Imagen.ImagenUrl);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.Cerrar();
            }
        }
        public void Modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            ImagenNegocio imagen = new ImagenNegocio();

            try
            {
                datos.SetQuery("UPDATE ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion , IdMarca = @IdMarca, IdCategoria = @IdCategoria, Precio = @Precio WHERE Id = @Id");
                datos.setParametro("@Codigo", articulo.Codigo);
                datos.setParametro("@Nombre", articulo.Nombre);
                datos.setParametro("@Descripcion", articulo.Descripcion);
                datos.setParametro("@IdMarca", articulo.Marca.Id);
                datos.setParametro("@IdCategoria", articulo.Categoria.Id);
                datos.setParametro("@Precio", articulo.Precio);
                datos.setParametro("@Id", articulo.Id);

                datos.EjecutarAccion();

                imagen.Modificar(articulo.Id, articulo.Imagen.ImagenUrl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.Cerrar();
            }
        }

        public void EliminarFisico(Articulo articulo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetQuery("DELETE FROM ARTICULOS WHERE Id = @Id");
                accesoDatos.setParametro("@Id", articulo.Id);
                accesoDatos.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.Cerrar();
            }
        }
        public void EliminarLogico(Articulo articulo)
        {
            AccesoDatos dato = new AccesoDatos();
            try
            {
                dato.SetQuery("UPDATE ARTICULOS set Activo = @value WHERE Id = @Id");
                dato.setParametro("@value", false);
                dato.setParametro("@Id", articulo.Id);
                dato.EjecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dato.Cerrar();
            }
        }
        public int ObtenerId(string codigo)
        {
            AccesoDatos consulta = new AccesoDatos();
            try
            {
                int id = -1;
                consulta.SetQuery("SELECT Id FROM ARTICULOS WHERE Codigo = @codigo");
                consulta.setParametro("@codigo", codigo);
                consulta.Leer();
                if (consulta.Reader.Read())
                    id = (int)consulta.Reader["Id"];

                return id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                consulta.Cerrar();
            }
        }

    }
}
