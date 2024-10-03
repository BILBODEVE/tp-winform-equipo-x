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
    }
}
