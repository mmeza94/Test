using Microsoft.Data.SqlClient;
using System.Data;

namespace ApiExamenDll
{
    public class DataAccess
    {


        public string connectionString = "Data Source=.;Initial Catalog=Prueba;Integrated Security=true";

        public DataTable GetExamenes(string Nombre, string Descripcion)
        {

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SpConsultar", connection);
                cmd.CommandType= CommandType.StoredProcedure;
                var parametroNombre = new SqlParameter
                {
                    ParameterName = "@Nombre",
                    DbType = DbType.String,
                    Value = Nombre
                };

                var parametroDescripcion = new SqlParameter
                {
                    ParameterName = "@Descripcion",
                    DbType = DbType.String,
                    Value = Descripcion
                };

                cmd.Parameters.Add(parametroNombre);
                cmd.Parameters.Add(parametroDescripcion);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                var dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();
                return dt;

            }


        }




        public DataTable AgregarExamen(int Id,string Nombre, string Descripcion)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SpAgregar", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                var parametroId = new SqlParameter
                {
                    ParameterName = "@Id",
                    DbType = DbType.Int32,
                    Value = Id
                };

                var parametroNombre = new SqlParameter
                {
                    ParameterName = "@Nombre",
                    DbType = DbType.String,
                    Value = Nombre
                };

                var parametroDescripcion = new SqlParameter
                {
                    ParameterName = "@Descripcion",
                    DbType = DbType.String,
                    Value = Descripcion
                };

                cmd.Parameters.Add(parametroId);
                cmd.Parameters.Add(parametroNombre);
                cmd.Parameters.Add(parametroDescripcion);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                var dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();
                return dt;

            }


        }


        public DataTable ActualizarExamen(int Id, string Nombre, string Descripcion)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SpActualizar", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                var parametroId = new SqlParameter
                {
                    ParameterName = "@Id",
                    DbType = DbType.Int32,
                    Value = Id
                };

                var parametroNombre = new SqlParameter
                {
                    ParameterName = "@Nombre",
                    DbType = DbType.String,
                    Value = Nombre
                };

                var parametroDescripcion = new SqlParameter
                {
                    ParameterName = "@Descripcion",
                    DbType = DbType.String,
                    Value = Descripcion
                };

                cmd.Parameters.Add(parametroId);
                cmd.Parameters.Add(parametroNombre);
                cmd.Parameters.Add(parametroDescripcion);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                var dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();
                return dt;

            }


        }



        public DataTable EliminarExamen(int Id)
        {

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("SpEliminar", connection);
                cmd.CommandType = CommandType.StoredProcedure;


                var parametroId = new SqlParameter
                {
                    ParameterName = "@Id",
                    DbType = DbType.Int32,
                    Value = Id
                };

                

                cmd.Parameters.Add(parametroId);


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                var dt = new DataTable();

                adapter.Fill(dt);

                connection.Close();
                return dt;

            }


        }




    }
}