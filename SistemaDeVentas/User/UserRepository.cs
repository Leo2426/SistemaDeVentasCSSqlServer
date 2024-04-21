using SistemaDeVentas.Clientes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SistemaDeVentas.User
{
    public class UserRepository
    {
        private string connectionString = Conexion.stringConexion;

        public void addUser(User user)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("spAddUser", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                command.Parameters.AddWithValue("@UserName", user.Name);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Rol", user.Rol);

                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al agregar usuario: " + ex.Message);

            }


        }


        public List<User> getAllUsers()
        {
            List<User> users = new List<User>();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("spGetAllUsers", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    User user = new User();
                    user.Id = Convert.ToInt32(reader["id"]);
                    user.Name = reader["user_name"].ToString();
                    user.Password = reader["password"].ToString();
                    user.Rol = reader["rol"].ToString();
                    users.Add(user);
                }

                connection.Close();
                return users;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public void deleteUser(int id)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("spDeleteUser", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                command.Parameters.AddWithValue("@UserId", id);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar usuario: " + ex.Message);
            }
        }


        public void updateUser(User user)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("spUpdateUser", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                command.Parameters.AddWithValue("@UserId", user.Id);
                command.Parameters.AddWithValue("@UserName", user.Name);
                command.Parameters.AddWithValue("@Password", user.Password);
                command.Parameters.AddWithValue("@Rol", user.Rol);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar usuario: " + ex.Message);
            }
        }


        public User getUserById(int id)
        {
            User user = new User();
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("spGetUserById", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                connection.Open();
                command.Parameters.AddWithValue("@UserId", id);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    user.Id = Convert.ToInt32(reader["id"]);
                    user.Name = reader["user_name"].ToString();
                    user.Password = reader["password"].ToString();
                    user.Rol = reader["rol"].ToString();
                }
                connection.Close();
                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool Login(User user)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT * FROM users WHERE user_name = @Username AND password = @Password", connection))
                {
                    command.Parameters.AddWithValue("@Username", user.Name);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    using (var reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        internal string getRol(string name)
        {
          
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand(@"
     	        SELECT name
	            FROM users
	            inner join rols on users.rols_id = rols.id
	            where users.user_name = @Username", connection))
                {
                    command.Parameters.AddWithValue("@Username", name);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["name"].ToString();
                        }
                        else
                        {
                            return "";
                        }
                    }
                }   
            }

        }
    }
}
