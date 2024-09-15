﻿using System;
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
                if(idArticulo != -1)
                {
                    datos.SetQuery("INSERT into IMAGENES(IdArticulo, ImagenUrl)VALUES(@IdArticulo, @ImagenUrl)");
                    datos.setParametro("@IdArticulo", idArticulo);
                    datos.setParametro("@ImagenUrl", url);
                    datos.Insertar();
                }
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
    }
}
