using DBpraktika.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBpraktika.Repositories
{
    internal class InterjeroRepository
    {
        private string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\VIKO\\2 Kursas\\S2\\Praktika\\DBpraktika\\DBpraktika\\Database1.mdf;Integrated Security=True";

        public DataTable ShowInterjerai()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT interjero_id as 'Interjero ID', interjero_pavadinimas as 'Pavadinimas', interjero_kaina as 'Kaina' FROM Interjeras", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public DataTable ShowInterjerai2()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT interjero_pavadinimas as 'Pavadinimas', interjero_kaina as 'Kaina' FROM Interjeras", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public void InsertInterjeras(string pavadinimas, double kaina)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand sqlCom = new SqlCommand("SELECT COUNT(*) FROM Interjeras WHERE interjero_pavadinimas=@pavadinimas", sqlcon);
                sqlCom.Parameters.AddWithValue("@pavadinimas", pavadinimas);

                var result = Convert.ToInt32(sqlCom.ExecuteScalar());
                if (result > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Ar norite atnaujinti šį interjerą?", "Toks interjeras jau yra !", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCom = new SqlCommand("UPDATE Interjeras SET interjero_kaina = @kaina WHERE interjero_pavadinimas=@pavadinimas", sqlcon);
                        sqlCom.Parameters.AddWithValue("@kaina", kaina);
                        sqlCom.Parameters.AddWithValue("@pavadinimas", pavadinimas);
                        sqlCom.ExecuteNonQuery();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Interjeras nebuvo pridėtas ar atnaujintas !");
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO [Interjeras] (interjero_pavadinimas, interjero_kaina) VALUES (@pavadinimas, @kaina)", sqlcon);
                    cmd.Parameters.AddWithValue("@pavadinimas", pavadinimas);
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

        public void DeleteInterjeras(int id)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Interjeras WHERE interjero_id=@id", sqlcon);

                com.Parameters.AddWithValue("@id", id);
                var result = Convert.ToInt32(com.ExecuteScalar());
                if (result > 0)
                {
                    SqlCommand sqlCom = new SqlCommand("SELECT konfiguracijos_id FROM Konfiguracija WHERE interjero_id=@id", sqlcon);
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
                    a += ("delete from Konfiguracija where interjero_id = @id ");
                    a += ("delete from Interjeras where interjero_id = @id");

                    cmd = new SqlCommand(a, sqlcon);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@konfid", konfID);
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

        public List<Interjeras> GetInterjeruList()
        {
            List<Interjeras> interjeruList = new List<Interjeras>();

            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand sqlCom = new SqlCommand("SELECT * FROM Interjeras", sqlCon);

                sqlCon.Open();
                SqlDataReader sdr = sqlCom.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int ID = int.Parse(sdr["interjero_id"].ToString()); //int.Parse(sdr.GetValue(i).ToString());
                        double kaina = double.Parse(sdr["interjero_kaina"].ToString());
                        string Pavadinimas = sdr["interjero_pavadinimas"].ToString(); //sdr.GetValue(i).ToString();

                        Interjeras interjeras = new Interjeras();

                        interjeras.Interjero_ID = ID;
                        interjeras.Interjero_Kaina = kaina;
                        interjeras.Interjero_Pavadinimas = Pavadinimas;

                        interjeruList.Add(interjeras);
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
            return interjeruList;
        }
    }
}