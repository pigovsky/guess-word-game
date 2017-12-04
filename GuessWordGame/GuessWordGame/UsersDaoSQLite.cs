using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace GuessWordGame
{
    class UsersDaoSQLite : UserDao
    {
        string ConnectionString = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Directory.GetParent(Directory.GetParent(Environment.CurrentDirectory).ToString()).ToString() + @"\GuessDataBase.mdf;Integrated Security=True");
        SqlConnection connection;
        SqlCommand cmd;
        public User add(User user)
        {
            try
            {
                using (connection = new SqlConnection(ConnectionString))
                {
                    using (cmd = new SqlCommand("INSERT INTO Users (Login,Hash,Surname,Name,EMail,DateOfBirth,Sex,Score,CurrentQuestion) VALUES (@login,@hash,@surname,@name,@email,@dateofbirth,@sex,@score,@currentquestion)", connection))
                    {
                        connection.Open();
                       // cmd.Parameters.AddWithValue("@id", user.id);
                        cmd.Parameters.AddWithValue("@login", user.login);
                        cmd.Parameters.AddWithValue("@surname", user.surname);
                        cmd.Parameters.AddWithValue("@name", user.name);
                        cmd.Parameters.AddWithValue("@email", user.email);
                        cmd.Parameters.AddWithValue("@dateofbirth", user.dateOfBirth);
                        cmd.Parameters.AddWithValue("@sex", user.sex.ToString());
                        cmd.Parameters.AddWithValue("@score", 100);
                        cmd.Parameters.AddWithValue("@currentquestion", 1);
                        cmd.Parameters.AddWithValue("@hash", user.passwordHash);
                        cmd.ExecuteScalar();
                        connection.Close();
                        return user;
                    }
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public List<User> all()
        {
            return GetUsers("SELECT * FROM Users");
        }

        public User findUser(string login, string password = "false")
        {
            string query;
            if (password != "false")
                query = "SELECT * FROM Users" +
                       " WHERE Hash='" + PasswordUtils.MD5(password) + "' AND Login='" +
                       login + "'";
            else
                query = "SELECT * FROM Users" +
                       " WHERE Login='" +
                       login + "'";
            List<User> user = GetUsers(query);
            if (user.Count != 0)
                return user[0];
            else
                return null;
        }

        public User update(User user)
        {
            try
            {
                using (connection = new SqlConnection(ConnectionString))
                {
                    using (cmd = new SqlCommand("UPDATE Users SET Login=@login,Hash=@hash,Surname=@surname," +
                        "Name=@name,EMail=@email," +
                        "Score=@score,CurrentQuestion=@currentquestion WHERE id=@id", connection))
                    {
                        connection.Open();
                        cmd.Parameters.AddWithValue("@id", user.id);
                        cmd.Parameters.AddWithValue("@login", user.login);
                        cmd.Parameters.AddWithValue("@surname", user.surname);
                        cmd.Parameters.AddWithValue("@name", user.name);
                        cmd.Parameters.AddWithValue("@email", user.email);
                        cmd.Parameters.AddWithValue("@dateofbirth", user.dateOfBirth.ToString());
                        cmd.Parameters.AddWithValue("@sex", user.sex.ToString());
                        cmd.Parameters.AddWithValue("@score", user.score);
                        cmd.Parameters.AddWithValue("@currentquestion", user.currentQuestion);
                        cmd.Parameters.AddWithValue("@hash", user.passwordHash);
                        cmd.ExecuteScalar();
                        connection.Close();
                    }
                }
                return user;
            }
            catch(Exception ex)
            {
                return null;
            }

        }
        private List<User> GetUsers(string query)
        {
            using (connection = new SqlConnection(ConnectionString))
            {
                try
                {
                   
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query,
                        connection))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        return
                        (from item in table.AsEnumerable()
                         select new User
                         {
                             id = item.Field<int>("id"),
                             passwordHash = item.Field<string>("Hash").ToString().Replace(" ",""),
                             surname = item.Field<string>("Surname").ToString().Replace(" ", ""),
                             name = item.Field<string>("Name").ToString().Replace(" ", ""),
                             email = item.Field<string>("EMail").ToString().Replace(" ", ""),
                             dateOfBirth = item.Field<DateTime>("DateOfBirth"),
                             sex = (Sex)Enum.Parse(typeof(Sex), item.Field<string>("Sex").ToString()),
                             login = item.Field<string>("Login").ToString().Replace(" ", ""),
                             score = item.Field<int>("Score"),
                             currentQuestion = item.Field<int>("CurrentQuestion")
                         }).ToList();

                    }
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
