using DBpraktika.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBpraktika.Repositories
{
    internal class RatuRepository
    {
        private string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\VIKO\\2 Kursas\\S2\\Praktika\\DBpraktika\\DBpraktika\\Database1.mdf;Integrated Security=True";

        public DataTable ShowRatai()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT ratu_id as 'Ratų ID', ratu_tipas as 'Pavadinimas', ratu_kaina as 'Kaina' FROM Ratai", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public DataTable ShowRatai2()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT ratu_tipas as 'Pavadinimas', ratu_kaina as 'Kaina' FROM Ratai", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public void InsertRatai(string tipas, double kaina)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand sqlCom = new SqlCommand("SELECT COUNT(*) FROM Ratai WHERE ratu_tipas=@pavadinimas", sqlcon);
                sqlCom.Parameters.AddWithValue("@pavadinimas", tipas);

                var result = Convert.ToInt32(sqlCom.ExecuteScalar());
                if (result > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Ar norite atnaujinti šį ratų tipą?", "Tokie ratai jau yra !", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCom = new SqlCommand("UPDATE Ratai SET ratu_kaina = @kaina WHERE ratu_tipas=@pavadinimas", sqlcon);
                        sqlCom.Parameters.AddWithValue("@kaina", kaina);
                        sqlCom.Parameters.AddWithValue("@pavadinimas", tipas);
                        sqlCom.ExecuteNonQuery();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Ratai nebuvo pridėti ar atnaujinti !");
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO [Ratai] (ratu_tipas, ratu_kaina) VALUES (@tipas, @kaina)", sqlcon);
                    cmd.Parameters.AddWithValue("@tipas", tipas);
                    cmd.Parameters.AddWithValue("@kaina", kaina);
                    cmd.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DeleteRatai(int id)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT COUNT(*) from Ratai WHERE ratu_id=@id", sqlcon);

                com.Parameters.AddWithValue("@id", id);
                var result = Convert.ToInt32(com.ExecuteScalar());
                if (result > 0)
                {
                    SqlCommand sqlCom = new SqlCommand("SELECT konfiguracijos_id FROM Konfiguracija WHERE ratu_id=@id", sqlcon);
                    int konfID = -1;
                    sqlCom.Parameters.AddWithValue("@id", id);
                    using (SqlDataReader sdr = sqlCom.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            konfID = int.Parse(sdr["konfiguracijos_id"].ToString());
                        }
                    }

                    string a = ("delete from Papildomi where Konfiguracijos_id = @konfid ");
                    a += ("delete from Konfiguracija where ratu_id = @id ");
                    a += ("delete from Ratai where ratu_id = @id");

                    cmd = new SqlCommand(a, sqlcon);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("konfid", konfID);
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

        public List<Ratai> GetRatuList()
        {
            List<Ratai> ratuList = new List<Ratai>();

            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand sqlCom = new SqlCommand("SELECT * FROM Ratai", sqlCon);

                sqlCon.Open();
                SqlDataReader sdr = sqlCom.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int ID = int.Parse(sdr["ratu_id"].ToString()); //int.Parse(sdr.GetValue(i).ToString());
                        double kaina = double.Parse(sdr["ratu_kaina"].ToString());
                        string Pavadinimas = sdr["ratu_tipas"].ToString(); //sdr.GetValue(i).ToString();

                        Ratai ratai = new Ratai();

                        ratai.Ratu_ID = ID;
                        ratai.Ratu_Kaina = kaina;
                        ratai.Ratu_Tipas = Pavadinimas;

                        ratuList.Add(ratai);
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
            return ratuList;
        }
    }
}