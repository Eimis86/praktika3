using DBpraktika.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBpraktika.Repositories
{
    internal class SpalvosRepository
    {
        private string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\VIKO\\2 Kursas\\S2\\Praktika\\DBpraktika\\DBpraktika\\Database1.mdf;Integrated Security=True";

        public DataTable ShowSpalva()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT spalvos_id as 'Spalvos ID', spalvos_pavadinimas as 'Pavadinimas', spalvos_kaina as 'Kaina' FROM Spalva", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public DataTable ShowSpalva2()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT spalvos_pavadinimas as 'Pavadinimas', spalvos_kaina as 'Kaina' FROM Spalva", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public void InsertSpalva(string pavadinimas, double kaina)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand sqlCom = new SqlCommand("SELECT COUNT(*) FROM SPALVA WHERE spalvos_pavadinimas=@pavadinimas", sqlcon);
                sqlCom.Parameters.AddWithValue("@pavadinimas", pavadinimas);

                var result = Convert.ToInt32(sqlCom.ExecuteScalar());
                if (result > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Ar norite atnaujinti šią spalvą?", "Tokia spalva jau yra !", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCom = new SqlCommand("UPDATE Spalva SET spalvos_kaina = @kaina WHERE spalvos_pavadinimas=@pavadinimas", sqlcon);
                        sqlCom.Parameters.AddWithValue("@kaina", kaina);
                        sqlCom.Parameters.AddWithValue("@pavadinimas", pavadinimas);
                        sqlCom.ExecuteNonQuery();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Spalva nebuvo pridėta ar atnaujinta !");
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO [Spalva] (spalvos_pavadinimas, spalvos_kaina) VALUES (@pavadinimas, @kaina)", sqlcon);
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

        public void DeleteSpalva(int id)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Spalva WHERE spalvos_id=@id", sqlcon);

                com.Parameters.AddWithValue("@id", id);
                var result = Convert.ToInt32(com.ExecuteScalar());
                if (result > 0)
                {
                    SqlCommand sqlCom = new SqlCommand("SELECT konfiguracijos_id FROM Konfiguracija WHERE spalvos_id=@id", sqlcon);
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
                    a += ("delete from Konfiguracija where spalvos_id = @id ");
                    a += "delete from Spalva where spalvos_id = @id";

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

        public List<Spalva> GetSpalvuList()
        {
            List<Spalva> spalvuList = new List<Spalva>();

            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand sqlCom = new SqlCommand("SELECT * FROM Spalva", sqlCon);

                sqlCon.Open();
                SqlDataReader sdr = sqlCom.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int ID = int.Parse(sdr["spalvos_id"].ToString()); //int.Parse(sdr.GetValue(i).ToString());
                        double kaina = double.Parse(sdr["spalvos_kaina"].ToString());
                        string Pavadinimas = sdr["spalvos_pavadinimas"].ToString(); //sdr.GetValue(i).ToString();

                        Spalva spalva = new Spalva();

                        spalva.Spalvos_ID = ID;
                        spalva.Spalvos_Kaina = kaina;
                        spalva.Spalvos_Pavadinimas = Pavadinimas;

                        spalvuList.Add(spalva);
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
            return spalvuList;
        }
    }
}