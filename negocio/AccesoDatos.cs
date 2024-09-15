using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace negocio
{
    internal class AccesoDatos
    {
        private SqlConnection connection;
        private SqlCommand command; 
        private SqlDataReader reader;
        public SqlDataReader Reader
        {
            get { return reader; }
        }
        public AccesoDatos(string cadenaConexion)
        {
            connection = new SqlConnection(cadenaConexion);
            command = new SqlCommand();

        }
        public AccesoDatos()
        {
            connection = new SqlConnection("server=(local)\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            command = new SqlCommand();
        }

        public void SetQuery(string query)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }

        public void Leer()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insertar()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Cerrar()
        {
            if(reader != null)
                reader.Close();
            
            connection.Close();
        }
    }
}
