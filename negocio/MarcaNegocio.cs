using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        private AccesoDatos accesoDatos;

        public MarcaNegocio()
        {
            accesoDatos = new AccesoDatos();
        }
        public List<Marca> Cargar()
        {
            List<Marca> marcas = new List<Marca>();
            marcas.Add(new Marca("Seleccionar"));

            try
            {
                accesoDatos.SetQuery("SELECT Id, Descripcion FROM MARCAS");
                accesoDatos.Leer();
                while(accesoDatos.Reader.Read())
                {
                    Marca marca = new Marca();
                    marca.Id = (int)accesoDatos.Reader["Id"];
                    marca.Descripcion = (string)accesoDatos.Reader["Descripcion"];
                    marcas.Add(marca);
                }

                return marcas;
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

        public void Insertar(string descripcionMarca)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                    datos.SetQuery("INSERT INTO MARCAS(Descripcion)VALUES(@descripcionMarca)");
                    datos.setParametro("@descripcionMarca", descripcionMarca);
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

        public void Modificar(Marca marca)
        {
            try
            {
                accesoDatos.SetQuery("UPDATE MARCAS SET Descripcion = @Descripcion WHERE Id = @Id");
                accesoDatos.setParametro("@Descripcion", marca.Descripcion);
                accesoDatos.setParametro("@Id", marca.Id);
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

        public void EliminarFisica(Marca marca)
        {
            try
            {
                accesoDatos.SetQuery("DELETE FROM MARCAS WHERE Id = @Id");
                accesoDatos.setParametro("@Id", marca.Id);
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

        public bool ExisteRelacion(int IDMarca)
        {
            try
            {
                accesoDatos.SetQuery("SELECT IdMarca FROM ARTICULOS WHERE IdMarca IS NOT NULL");
                accesoDatos.Leer();

                while (accesoDatos.Reader.Read())
                {
                    if (IDMarca == (int)accesoDatos.Reader["IdMarca"])
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
