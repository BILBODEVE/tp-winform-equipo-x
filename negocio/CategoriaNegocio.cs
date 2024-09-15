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
        public List<Categoria> cargar()
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
    }
}
