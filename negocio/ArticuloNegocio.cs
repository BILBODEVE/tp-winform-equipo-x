﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;
using System.Runtime.Remoting.Messaging;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos consulta = new AccesoDatos();
            try
            {
                consulta.SetQuery("SELECT A.Codigo, A.Nombre, A.Descripcion, A.Id, I.IdArticulo, I.ImagenUrl FROM ARTICULOS A, IMAGENES I WHERE I.IdArticulo = A.Id");
                consulta.Leer();

                while (consulta.Reader.Read())
                {
                    Articulo articuloAuxiliar = new Articulo();
                    articuloAuxiliar.Codigo = (string)consulta.Reader["Codigo"];
                    articuloAuxiliar.Nombre = (string)consulta.Reader["Nombre"];
                    articuloAuxiliar.Descripcion = (string)consulta.Reader["Descripcion"];
                    articuloAuxiliar.URLImage = (string)consulta.Reader["ImagenUrl"];

                    articulos.Add(articuloAuxiliar);
                }
                return articulos;
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
        public void Cargar(Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetQuery("INSERT into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)");
                datos.setParametro("@Codigo", nuevoArticulo.Codigo);
                datos.setParametro("@Nombre", nuevoArticulo.Nombre);
                datos.setParametro("@Descripcion", nuevoArticulo.Descripcion);
                datos.setParametro("@IdMarca", nuevoArticulo.Marca.Id);
                datos.setParametro("@IdCategoria", nuevoArticulo.Categoria.Id);
                datos.setParametro("@Precio", nuevoArticulo.Precio);

                datos.Insertar();
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

        public int ObtenerId(string codigo)
        {
            AccesoDatos consulta = new AccesoDatos();
            try
            {
                int id = -1;
                consulta.SetQuery("SELECT Id FROM ARTICULOS WHERE Codigo = @codigo");
                consulta.setParametro("@codigo", codigo);
                consulta.Leer();
                if (consulta.Reader.Read())
            {
                    id = (int)consulta.Reader["Id"];
                }

                return id;
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
