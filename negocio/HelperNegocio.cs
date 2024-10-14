using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class HelperNegocio
    {
        private AccesoDatos accesoDatos;
        public HelperNegocio()
        {
            accesoDatos = new AccesoDatos();
        }
        public bool ValidarNuevoItem(string query, string descripcion)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.SetQuery(query);
                accesoDatos.Leer();
                while (accesoDatos.Reader.Read())
                {
                    string campo = (string)accesoDatos.Reader["Descripcion"];

                    if (campo.ToUpper() == descripcion.ToUpper()) return false;
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
            return true;
        }
    }
}
