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
        private AccesoDatos accesoDatos;

        public CategoriaNegocio()
        {
            accesoDatos = new AccesoDatos();
        }
        public List<Categoria> Cargar()
        {
            List<Categoria> categorias = new List<Categoria>();
            categorias.Add(new Categoria("Todos"));
            try
            {
                accesoDatos.SetQuery("SELECT Id, Descripcion FROM CATEGORIAS");
                accesoDatos.Leer();
                while (accesoDatos.Reader.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = (int)accesoDatos.Reader["Id"];
                    categoria.Descripcion = (string)accesoDatos.Reader["Descripcion"];
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
                accesoDatos.Cerrar();
            }
        }
        public void Insertar(string descripcionCategoria)
        {
            try
            {
                accesoDatos.SetQuery("INSERT INTO CATEGORIAS(Descripcion)VALUES(@descripcionCategoria)");
                accesoDatos.setParametro("@descripcionCategoria", descripcionCategoria);
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

        public void Modificar(Categoria categoria)
        {
            try
            {
                accesoDatos.SetQuery("UPDATE CATEGORIAS SET Descripcion = @Descripcion WHERE Id = @Id");
                accesoDatos.setParametro("@Descripcion", categoria.Descripcion);
                accesoDatos.setParametro("@Id", categoria.Id);
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

        public void EliminarFisica(Categoria categoria)
        {
            try
            {
                accesoDatos.SetQuery("DELETE FROM CATEGORIAS WHERE Id = @Id");
                accesoDatos.setParametro("@Id", categoria.Id);
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

        public bool ExisteRelacion(Categoria categoria)
        {
            try
            {
                accesoDatos.SetQuery("SELECT IdCategoria FROM ARTICULOS WHERE IdCategoria IS NOT NULL");
                accesoDatos.Leer();

                while (accesoDatos.Reader.Read())
                {
                    if(categoria.Id == (int)accesoDatos.Reader["IdCategoria"])
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.Cerrar();
            }

            return false;
        }
    }
}
