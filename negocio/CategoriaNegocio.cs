using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Cargar()
        {
            AccesoDatos consulta = new AccesoDatos();
            List<Categoria> categorias = new List<Categoria>();

            try
            {
                consulta.SetQuery("SELECT Id, Descripcion FROM CATEGORIAS");
                consulta.Leer();
                while (consulta.Reader.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)consulta.Reader["Id"];
                    categoria.Descripcion = (string)consulta.Reader["Descripcion"];
                    categorias.Add(categoria);
                }
                return categorias;
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
        public void Insertar(string descripcionCategoria)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetQuery("INSERT INTO CATEGORIAS(Descripcion)VALUES(@descripcionCategoria)");
                datos.setParametro("@descripcionCategoria", descripcionCategoria);
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
    }
}
