using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class HelperNegocio
    {
        public bool ValidarNuevoItem(string query, string descripcion)
        {
            AccesoDatos consulta = new AccesoDatos();

            try
            {
                consulta.SetQuery(query);
                consulta.Leer();
                while (consulta.Reader.Read())
                {
                    string campo = (string)consulta.Reader["Descripcion"];

                    if (campo.ToUpper() == descripcion.ToUpper()) return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                consulta.Cerrar();
            }
            return true;
        }

        public bool ValidarCampo(string campo)
        {
            if(campo == null || campo == "")
                return false;

            return true;
        }
    }
}
