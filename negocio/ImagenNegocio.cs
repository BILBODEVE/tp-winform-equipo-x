using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using static System.Net.Mime.MediaTypeNames;


namespace negocio
{
    public class ImagenNegocio
    {
        public void Insertar(int idArticulo, string url)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetQuery("INSERT into IMAGENES(IdArticulo, ImagenUrl)VALUES(@IdArticulo, @ImagenUrl)");
                datos.setParametro("@IdArticulo", idArticulo);
                datos.setParametro("@ImagenUrl", url);
                datos.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.Cerrar();
            }
        }

        public void Modificar(int idArticulo, string url)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetQuery("UPDATE IMAGENES set ImagenUrl = @url WHERE IdArticulo = @Id");
                datos.setParametro("@url", url);
                datos.setParametro("Id", idArticulo);
                datos.EjecutarAccion();
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
        
        public void CargarImagen(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                
                datos.SetQuery("SELECT DISTINCT ImagenUrl FROM IMAGENES AS I INNER JOIN ARTICULOS AS A ON I.IdArticulo = @idArticulo");
                datos.setParametro("@idArticulo", articulo.Id);
                datos.Leer();
                while(datos.Reader.Read())
                {
                    string url = (string)datos.Reader["ImagenUrl"];
                    articulo.Imagen.Add(url);
                }
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
    }
}
