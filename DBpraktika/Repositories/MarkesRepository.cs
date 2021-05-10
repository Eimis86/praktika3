using DBpraktika.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBpraktika.Repositories
{
    internal class MarkesRepository
    {
        private string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\VIKO\\2 Kursas\\S2\\Praktika\\DBpraktika\\DBpraktika\\Database1.mdf;Integrated Security=True";

        public DataTable ShowMarke()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT markes_id as 'Markes ID', markes_pavadinimas as 'Pavadinimas' FROM Marke", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public void InsertMarke(string pavadinimas)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Marke WHERE markes_pavadinimas = @pavadinimas", sqlcon);

                com.Parameters.AddWithValue("@pavadinimas", pavadinimas);
                var result = Convert.ToInt32(com.ExecuteScalar());
                if (result > 0)
                {
                    MessageBox.Show("Toks markės pavadinimas jau egzistuoja !");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO [Marke] (markes_pavadinimas) VALUES (@pavadinimas)", sqlcon);
                    cmd.Parameters.AddWithValue("@pavadinimas", pavadinimas);
                    cmd.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DeleteMarke(int id)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Marke WHERE markes_id=@id", sqlcon);

                com.Parameters.AddWithValue("@id", id);
                var result = Convert.ToInt32(com.ExecuteScalar());
                if (result > 0)
                {
                    SqlCommand commmand = new SqlCommand("SELECT modelio_id FROM Modelis WHERE markes_id=@id", sqlcon);
                    int modID = -1;
                    commmand.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader sdr = commmand.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            modID = int.Parse(sdr["modelio_id"].ToString());
                        }
                    }

                    SqlCommand sqlCom = new SqlCommand("SELECT konfiguracijos_id FROM Konfiguracija WHERE modelio_id=@modID", sqlcon);
                    int konfID = -1;
                    sqlCom.Parameters.AddWithValue("@modID", modID);
                    using (SqlDataReader sdr = sqlCom.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            konfID = int.Parse(sdr["konfiguracijos_id"].ToString());
                        }
                    }

                    string a = ("delete from Papildomi where Konfiguracijos_id = @konfid ");
                    a += ("Delete from Konfiguracija where modelio_id = @modID ");
                    a += ("Delete From Modelis Where markes_id = @id ");
                    a += ("Delete From Marke Where markes_id = @id ");

                    cmd = new SqlCommand(a, sqlcon);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@konfid", konfID);
                    cmd.Parameters.AddWithValue("@modID", modID);
                    cmd.ExecuteNonQuery();
                }
                else
                    MessageBox.Show(id + " <- Tokio ID nėra !");
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public List<Marke> GetMarkiuList()
        {
            List<Marke> markiuList = new List<Marke>();

            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand sqlCom = new SqlCommand("SELECT * FROM Marke", sqlCon);

                sqlCon.Open();
                SqlDataReader sdr = sqlCom.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int ID = int.Parse(sdr["markes_id"].ToString()); //int.Parse(sdr.GetValue(i).ToString());
                        string Pavadinimas = sdr["markes_pavadinimas"].ToString(); //sdr.GetValue(i).ToString();

                        Marke marke = new Marke();

                        marke.Markes_ID = ID;
                        marke.Markes_Pavadinimas = Pavadinimas;

                        markiuList.Add(marke);
                    }
                    sdr.Close();
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            return markiuList;
        }
    }
}