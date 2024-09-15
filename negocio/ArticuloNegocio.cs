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
                    articuloAuxiliar.Codigo = (string)consulta.Reader["Codigo"];
                    articuloAuxiliar.Nombre = (string)consulta.Reader["Nombre"];
                    articuloAuxiliar.Descripcion = (string)consulta.Reader["Descripcion"];
                    articuloAuxiliar.URLImage = (string)consulta.Reader["ImagenUrl"];

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

            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
