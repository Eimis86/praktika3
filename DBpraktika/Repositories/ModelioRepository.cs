using DBpraktika.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBpraktika.Repositories
{
    internal class ModelioRepository
    {
        private string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\VIKO\\2 Kursas\\S2\\Praktika\\DBpraktika\\DBpraktika\\Database1.mdf;Integrated Security=True";

        public DataTable ShowModelis()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Modelis.modelio_id as 'Modelio ID', Marke.markes_pavadinimas as 'Markės Pavadinimas', Modelis.modelio_pavadinimas as 'Modelio Pavadinimas' FROM Modelis INNER JOIN Marke ON Marke.markes_id = Modelis.markes_id ", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public void InsertModelis(string pavadinimas, int id)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand sqlCom = new SqlCommand("SELECT COUNT(*) FROM Modelis WHERE modelio_pavadinimas=@pavadinimas", sqlcon);
                sqlCom.Parameters.AddWithValue("@pavadinimas", pavadinimas);

                var result = Convert.ToInt32(sqlCom.ExecuteScalar());
                if (result > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Ar norite atnaujinti šį modelį?", "Toks modelis jau yra !", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCom = new SqlCommand("UPDATE Modelis SET markes_id = @id WHERE modelio_pavadinimas=@pavadinimas", sqlcon);
                        sqlCom.Parameters.AddWithValue("@id", id);
                        sqlCom.Parameters.AddWithValue("@pavadinimas", pavadinimas);
                        sqlCom.ExecuteNonQuery();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Modelis nebuvo pridėtas ar atnaujintas !");
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO [Modelis] (modelio_pavadinimas, markes_id) VALUES (@pavadinimas, @id)", sqlcon);
                    cmd.Parameters.AddWithValue("@pavadinimas", pavadinimas);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DeleteModelis(int id)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Modelis WHERE modelio_id=@id", sqlcon);

                com.Parameters.AddWithValue("@id", id);
                var result = Convert.ToInt32(com.ExecuteScalar());
                if (result > 0)
                {
                    SqlCommand sqlCom = new SqlCommand("SELECT konfiguracijos_id FROM Konfiguracija WHERE modelio_id=@id", sqlcon);
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
                    a += ("delete from Konfiguracija where modelio_id = @id ");
                    a += ("delete from Modelis where modelio_id = @id");

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

        public List<Modelis> GetModeliuList(int id)
        {
            List<Modelis> modeliuList = new List<Modelis>();

            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand sqlCom = new SqlCommand("SELECT * FROM Modelis where markes_id = @id", sqlCon);
                sqlCom.Parameters.AddWithValue("@id", id);
                sqlCon.Open();
                SqlDataReader sdr = sqlCom.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int ID = int.Parse(sdr["modelio_id"].ToString()); //int.Parse(sdr.GetValue(i).ToString());
                        int markesID = int.Parse(sdr["markes_id"].ToString());
                        string Pavadinimas = sdr["modelio_pavadinimas"].ToString(); //sdr.GetValue(i).ToString();

                        Modelis modelis = new Modelis();

                        modelis.Modelio_ID = ID;
                        modelis.Markes_ID = markesID;
                        modelis.Modelio_Pavadinimas = Pavadinimas;

                        modeliuList.Add(modelis);
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
            return modeliuList;
        }
    }
}