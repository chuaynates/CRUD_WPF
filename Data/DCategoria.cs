using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Data
{
   public class DCategoria
    {

     public   List<Categoria> Listar(Categoria categoria)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            List<Categoria> categorias = null;

            try
            {
                //Instanciar
                comandText = "USP_GetCategoria";
                parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idcategoria", System.Data.SqlDbType.Int);
                parameters[0].Value = categoria.IdCategoria;
                categorias = new List<Categoria>();

                //Porque se utiliza automaticamente se borra de la memoria.
                using (SqlDataReader reader = SqlHelper.ExecuteReader(SqlHelper.Connection, comandText, 
                    System.Data.CommandType.StoredProcedure, parameters))
                    //SQL Helper te asegura que se van a cerrar siempre las conexiones
                {
                    while (reader.Read())
                    {
                        categorias.Add(new Categoria
                        {
                            IdCategoria = reader["idcategoria"] != null ? Convert.ToInt32(reader["idcategoria"]) : 0,
                            NombreCategoria = reader["nombrecategoria"] != null ? Convert.ToString(reader["nombrecategoria"]) : "",
                            Descripcion = reader["descripcion"] != null ? Convert.ToString(reader["descripcion"]) : "",
                        });
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return categorias;
        }

        public void Actualizar(Categoria categoria)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            try
            {
                comandText = "USP_UpdateCategoria";
                parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@idcategoria",SqlDbType.Int);
                parameters[0].Value = categoria.IdCategoria;
                parameters[1] = new SqlParameter("@nombrecategoria", SqlDbType.VarChar);
                parameters[1].Value = categoria.NombreCategoria;
                parameters[2] = new SqlParameter("@descripcion",SqlDbType.Text);
                parameters[2].Value = categoria.Descripcion;
                SqlHelper.ExecuteNonQuery(SqlHelper.Connection, comandText, CommandType.StoredProcedure, parameters);
            }
            catch(Exception ex)
            {
                throw ex;
            }
           }
        public void Insertar(Categoria categoria)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            try
            {
                comandText = "USP_InsertarCategoria";
                parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@nombrecategoria", SqlDbType.VarChar);
                parameters[0].Value = categoria.NombreCategoria;
                parameters[1] = new SqlParameter("@descripcion", SqlDbType.Text);
                parameters[1].Value = categoria.Descripcion;
                
                SqlHelper.ExecuteNonQuery(SqlHelper.Connection, comandText, CommandType.StoredProcedure, parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Eliminar(int IdCategoria)
        {
            SqlParameter[] parameters = null;
            string comandText = string.Empty;
            try
            {
                comandText = "USP_DeleteCategoria";
                parameters = new SqlParameter[1];
                parameters[0] = new SqlParameter("@idcategoria", SqlDbType.Int);
                parameters[0].Value = IdCategoria;
                SqlHelper.ExecuteNonQuery(SqlHelper.Connection, comandText, CommandType.StoredProcedure, parameters);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
