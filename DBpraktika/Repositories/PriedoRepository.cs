using DBpraktika.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBpraktika.Repositories
{
    internal class PriedoRepository
    {
        private string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\VIKO\\2 Kursas\\S2\\Praktika\\DBpraktika\\DBpraktika\\Database1.mdf;Integrated Security=True";

        public DataTable ShowPriedai()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT priedo_id as 'Priedo ID', priedo_pavadinimas as 'Pavadinimas', priedo_kaina as 'Kaina' FROM Priedas", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public DataTable ShowPriedai2()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT priedo_pavadinimas as 'Pavadinimas', priedo_kaina as 'Kaina' FROM Priedas", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public void InsertPrieda(string pavadinimas, double kaina)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand sqlCom = new SqlCommand("SELECT COUNT(*) FROM Priedas WHERE priedo_pavadinimas=@pavadinimas", sqlcon);
                sqlCom.Parameters.AddWithValue("@pavadinimas", pavadinimas);

                var result = Convert.ToInt32(sqlCom.ExecuteScalar());
                if (result > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Ar norite atnaujinti ši priedą?", "Toks priedas jau yra !", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        sqlCom = new SqlCommand("UPDATE Priedas SET priedo_kaina = @kaina WHERE priedo_pavadinimas=@pavadinimas", sqlcon);
                        sqlCom.Parameters.AddWithValue("@kaina", kaina);
                        sqlCom.Parameters.AddWithValue("@pavadinimas", pavadinimas);
                        sqlCom.ExecuteNonQuery();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Priedas nebuvo pridėtas ar atnaujintas !");
                    }
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO [Priedas] (priedo_pavadinimas, priedo_kaina) VALUES (@pavadinimas, @kaina)", sqlcon);
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

        public void DeletePrieda(int id)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Priedas WHERE priedo_id=@id", sqlcon);

                com.Parameters.AddWithValue("@id", id);
                var result = Convert.ToInt32(com.ExecuteScalar());
                if (result > 0)
                {
                    string a = ("delete from Papildomi where priedo_id = @id ");
                    a += ("delete from Priedas where priedo_id = @id");

                    cmd = new SqlCommand(a, sqlcon);
                    cmd.Parameters.AddWithValue("@id", id);
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

        public List<Priedas> GetPrieduList()
        {
            List<Priedas> prieduList = new List<Priedas>();

            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand sqlCom = new SqlCommand("SELECT * FROM Priedas", sqlCon);

                sqlCon.Open();
                SqlDataReader sdr = sqlCom.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int ID = int.Parse(sdr["priedo_id"].ToString()); //int.Parse(sdr.GetValue(i).ToString());
                        double kaina = double.Parse(sdr["priedo_kaina"].ToString());
                        string Pavadinimas = sdr["priedo_pavadinimas"].ToString(); //sdr.GetValue(i).ToString();

                        Priedas priedas = new Priedas();

                        priedas.Priedo_ID = ID;
                        priedas.Priedo_Kaina = kaina;
                        priedas.Priedo_Pavadinimas = Pavadinimas;

                        prieduList.Add(priedas);
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
            return prieduList;
        }

        public void InsertKonfiguracijosPrieda(string pavadinimas, int konfiguracijosID)
        {
            try
            {
                Priedas priedas = new Priedas();

                SqlConnection sqlCon = new SqlConnection(con);

                sqlCon.Open();

                SqlCommand cmd = new SqlCommand("SELECT priedo_id FROM Priedas WHERE priedo_pavadinimas=@pavadinimas ", sqlCon);
                cmd.Parameters.AddWithValue("@pavadinimas", pavadinimas);

                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    priedas.Priedo_ID = int.Parse(sqlDataReader["priedo_id"].ToString());
                }
                sqlCon.Close();

                sqlCon.Open();

                SqlCommand command = new SqlCommand("INSERT INTO Papildomi (priedo_id, konfiguracijos_id) VALUES (@priedas, @konfiguracija) ", sqlCon);
                command.Parameters.AddWithValue("@priedas", priedas.Priedo_ID);
                command.Parameters.AddWithValue("@konfiguracija", konfiguracijosID);

                command.ExecuteNonQuery();

                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public DataTable ShowKonfiguracijosPriedus(int id)
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT konfiguracijos_id as 'Konfiguracijos ID', " +
                 "Priedas.priedo_pavadinimas as 'Priedo pavadinimas' FROM Papildomi " +
                 "INNER JOIN Priedas ON Priedas.priedo_id = Papildomi.priedo_id " +
                 "WHERE konfiguracijos_id = @id", sqlCon);

            sda.SelectCommand.Parameters.AddWithValue("@id", id);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }
    }
}