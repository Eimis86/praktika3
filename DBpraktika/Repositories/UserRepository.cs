using DBpraktika.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBpraktika.Repositories
{
    internal class UserRepository
    {
        private string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\VIKO\\2 Kursas\\S2\\Praktika\\DBpraktika\\DBpraktika\\Database1.mdf;Integrated Security=True";

        public User StaffLogin(string Username, string Password)
        {
            User staffLogin = new User();

            try
            {
                SqlConnection sqlCon = new SqlConnection(con);

                SqlCommand cmd = new SqlCommand("SELECT * FROM UserTbl WHERE username=@Username AND password=@Password", sqlCon);
                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Password", Password);

                sqlCon.Open();

                SqlDataReader dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = int.Parse(dataReader["user_id"].ToString());
                    string username = dataReader["username"].ToString();
                    string password = dataReader["password"].ToString();
                    string firstname = dataReader["Name"].ToString();
                    string lastname = dataReader["LastName"].ToString();
                    string userType = dataReader["UserType"].ToString();

                    staffLogin.ID = id;
                    staffLogin.Username = username;
                    staffLogin.Password = password;
                    staffLogin.Name = firstname;
                    staffLogin.LastName = lastname;
                    staffLogin.UserType = userType;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            return staffLogin;
        }

        public DataTable ShowUsers()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT user_id as 'Naudotojo ID', username as 'Username', Name as 'Vardas', LastName as 'Pavardė',  password as 'Slaptažodis', UserType as 'Rolė' FROM UserTbl", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public void InsertUser(string username, string password, string name, string lastName, string usertype)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand sqlCom = new SqlCommand("SELECT COUNT(*) FROM UserTbl WHERE username=@username", sqlcon);
                sqlCom.Parameters.AddWithValue("@username", username);

                var result = Convert.ToInt32(sqlCom.ExecuteScalar());
                if (result > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Ar norite atnaujinti šio Naudotojo informacija?", "Toks naudotojas jau yra !", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCom = new SqlCommand("UPDATE UserTbl SET password=@password, Name=@name, LastName=@lastname WHERE username=@username", sqlcon);
                        sqlCom.Parameters.AddWithValue("@username", username);
                        sqlCom.Parameters.AddWithValue("@password", password);
                        sqlCom.Parameters.AddWithValue("@name", name);
                        sqlCom.Parameters.AddWithValue("@lastname", lastName);
                        sqlCom.ExecuteNonQuery();
                        MessageBox.Show("Naudotojas: " + username + " <- Buvo sėkmingai atnaujintas");
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Naudotojas nebuvo pridėtas ar atnaujintas !");
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO [UserTbl] (username, password, Name, LastName, UserType) VALUES (@username, @password, @name, @lastname, @usertype)", sqlcon);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@lastname", lastName);
                    cmd.Parameters.AddWithValue("@usertype", usertype);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Naudotojas sėkmingai pridėtas !");
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM UserTbl WHERE user_id=@id", sqlcon);

                com.Parameters.AddWithValue("@id", id);
                var result = Convert.ToInt32(com.ExecuteScalar());
                if (result > 0)
                {
                    string a = "delete from UserTbl where user_id = @id";

                    cmd = new SqlCommand(a, sqlcon);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                else
                    MessageBox.Show("Naudotojo su šiuo: " + id + " <- ID nėra !");
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}