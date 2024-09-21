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
        public List<Marca> Cargar()
        {
            List<Marca> marcas = new List<Marca>();
            AccesoDatos consulta =  new AccesoDatos();

            try
            {
                consulta.SetQuery("SELECT Id, Descripcion FROM MARCAS");
                consulta.Leer();
                while(consulta.Reader.Read())
                {
                   Marca marca = new Marca();
                   marca.Id = (int)consulta.Reader["Id"];
                   marca.Descripcion = (string)consulta.Reader["Descripcion"];
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
                consulta.Cerrar(); 
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
