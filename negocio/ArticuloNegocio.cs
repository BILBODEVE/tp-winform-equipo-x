using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();

            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;

            try 
	        {
                connection.ConnectionString = "server=(local)\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT A.Codigo, A.Nombre, A.Descripcion, A.Id, I.IdArticulo, I.ImagenUrl FROM ARTICULOS A, IMAGENES I WHERE I.IdArticulo = A.Id";
                command.Connection = connection;
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read()) 
                {   
                    Articulo articuloAuxiliar = new Articulo();
                    articuloAuxiliar.Codigo = (string)reader["Codigo"];
                    articuloAuxiliar.Nombre = (string)reader["Nombre"];
                    articuloAuxiliar.Descripcion = (string)reader["Descripcion"];
                    articuloAuxiliar.URLImage = (string)reader["ImagenUrl"];
                    
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
                connection.Close();
            }
        }

    }
}
