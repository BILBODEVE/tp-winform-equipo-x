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
        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos consulta = new AccesoDatos();
            try
            {
                consulta.SetQuery("SELECT A.Codigo, A.Nombre, A.Descripcion, A.Id, I.IdArticulo, I.ImagenUrl FROM ARTICULOS A, IMAGENES I WHERE I.IdArticulo = A.Id");
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

                datos.Insertar();
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

        public void Eliminar(Articulo articulo)
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
                {
                    id = (int)consulta.Reader["Id"];
                }

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
