using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBpraktika.Models;
using DBpraktika.Repositories;

namespace DBpraktika.Repositories
{
    class KonfiguracijosRepository
    {
        private string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\VIKO\\2 Kursas\\S2\\Praktika\\DBpraktika\\DBpraktika\\Database1.mdf;Integrated Security=True";

        Konfiguracija konfiguracija;

        public Konfiguracija InsertKonfiguracija(string modelis, string variklis, string spalva, string ratai, string interjeras, double suma)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);

                sqlCon.Open();
                konfiguracija = new Konfiguracija();
                /*Select from modelis */
                SqlCommand cmdM = new SqlCommand("SELECT modelio_id FROM Modelis WHERE modelio_pavadinimas=@modelis", sqlCon);
                cmdM.Parameters.AddWithValue("@modelis", modelis);

                SqlDataReader sqlReader = cmdM.ExecuteReader();
                while (sqlReader.Read())
                {
                    konfiguracija.Modelio_ID = int.Parse(sqlReader["modelio_id"].ToString());
                    Console.WriteLine("Modelio ID: " +konfiguracija.Modelio_ID);
                }
                sqlCon.Close();

                sqlCon.Open();
                SqlCommand cmdV = new SqlCommand("SELECT variklio_id FROM Variklis WHERE variklio_pavadinimas=@variklis", sqlCon);
                cmdV.Parameters.AddWithValue("@variklis", variklis);

                sqlReader = cmdV.ExecuteReader();
                while (sqlReader.Read())
                {
                    konfiguracija.Variklio_ID = int.Parse(sqlReader["variklio_id"].ToString());
                    Console.WriteLine("Variklio ID" + konfiguracija.Variklio_ID);
                }

                sqlCon.Close();

                sqlCon.Open();
                SqlCommand cmdS = new SqlCommand("SELECT spalvos_id FROM Spalva WHERE spalvos_pavadinimas=@spalva", sqlCon);
                cmdS.Parameters.AddWithValue("@spalva", spalva);

                sqlReader = cmdS.ExecuteReader();
                while (sqlReader.Read())
                {
                    konfiguracija.Spalvos_ID = int.Parse(sqlReader["spalvos_id"].ToString());
                    Console.WriteLine("Spalvos ID: " + konfiguracija.Spalvos_ID);
                }
                sqlCon.Close();

                sqlCon.Open();

                SqlCommand cmdR = new SqlCommand("SELECT ratu_id FROM Ratai WHERE ratu_tipas = @ratai", sqlCon);
                cmdR.Parameters.AddWithValue("@ratai", ratai);

                sqlReader = cmdR.ExecuteReader();
                while (sqlReader.Read())
                {
                    konfiguracija.Ratu_ID = int.Parse(sqlReader["ratu_id"].ToString());
                    Console.WriteLine("Ratu ID: " +konfiguracija.Ratu_ID);
                }
                sqlCon.Close();

                sqlCon.Open();

                SqlCommand cmdI = new SqlCommand("SELECT interjero_id FROM Interjeras WHERE interjero_pavadinimas=@interjeras", sqlCon);
                cmdI.Parameters.AddWithValue("@interjeras", interjeras);

                sqlReader = cmdI.ExecuteReader();
                while (sqlReader.Read())
                {
                    konfiguracija.Interjero_ID = int.Parse(sqlReader["interjero_id"].ToString());
                    Console.WriteLine("Interjero ID " + konfiguracija.Interjero_ID);
                }
                sqlCon.Close();

                sqlCon.Open();
                konfiguracija.Galutine_Kaina = suma;
                SqlCommand cmd = new SqlCommand("INSERT INTO Konfiguracija (variklio_id, spalvos_id, interjero_id, ratu_id, modelio_id, galutine_kaina) " +
                    "VALUES (@variklis, @spalva, @interjeras, @ratai, @modelis, @suma)", sqlCon);
                cmd.Parameters.AddWithValue("@variklis",konfiguracija.Variklio_ID);
                cmd.Parameters.AddWithValue("@spalva", konfiguracija.Spalvos_ID);
                cmd.Parameters.AddWithValue("@interjeras", konfiguracija.Interjero_ID);
                cmd.Parameters.AddWithValue("@ratai", konfiguracija.Ratu_ID);
                cmd.Parameters.AddWithValue("@modelis", konfiguracija.Modelio_ID);
                cmd.Parameters.AddWithValue("@suma", konfiguracija.Galutine_Kaina);

                cmd.ExecuteNonQuery();

                sqlCon.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return konfiguracija;
        }

        public Konfiguracija GetKonfiguracija(int modelis, int variklis, int spalva, int ratai, int interjeras, double suma)
        {
            try
            {
                SqlConnection sqlCon = new SqlConnection(con);

                sqlCon.Open();
                konfiguracija = new Konfiguracija();

                SqlCommand cmd = new SqlCommand("SELECT * FROM Konfiguracija WHERE variklio_id = @variklis AND spalvos_id = @spalva" +
                    " AND interjero_id = @interjeras " + "AND ratu_id = @ratai AND modelio_id = @modelis AND galutine_kaina = @suma ", sqlCon);
                cmd.Parameters.AddWithValue("@variklis", variklis);
                cmd.Parameters.AddWithValue("@spalva", spalva);
                cmd.Parameters.AddWithValue("@interjeras", interjeras);
                cmd.Parameters.AddWithValue("@ratai", ratai);
                cmd.Parameters.AddWithValue("@modelis", modelis);
                cmd.Parameters.AddWithValue("@suma", suma);

                SqlDataReader sqlReader = cmd.ExecuteReader();
                while (sqlReader.Read())
                {
                    konfiguracija.Konfiguracijos_ID = int.Parse(sqlReader["konfiguracijos_id"].ToString());
                    Console.WriteLine("Konfiguracijos ID " + konfiguracija.Konfiguracijos_ID);
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return konfiguracija;
        }

        public DataTable ShowKonfiguracijas()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();


            SqlDataAdapter sda = new SqlDataAdapter("SELECT Konfiguracija.konfiguracijos_id as 'Konfiguracijos ID', " +
                "Modelis.modelio_pavadinimas as 'Modelis', Variklis.variklio_pavadinimas as 'Variklis', " +
                "Interjeras.interjero_pavadinimas as 'Interjeras', Spalva.spalvos_pavadinimas as 'Spalva', " +
                "Ratai.ratu_tipas as 'Ratai', Konfiguracija.galutine_kaina as 'Suma' " +
                "FROM Konfiguracija INNER JOIN Modelis ON Konfiguracija.modelio_id = Modelis.modelio_id " +
                "INNER JOIN Variklis ON Konfiguracija.variklio_id = Variklis.variklio_id " +
                "INNER JOIN Interjeras ON Konfiguracija.interjero_id = Interjeras.interjero_id " +
                "INNER JOIN Spalva ON Konfiguracija.spalvos_id = Spalva.spalvos_id " +
                "INNER JOIN Ratai ON Konfiguracija.ratu_id = Ratai.ratu_id", sqlCon);

            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }



        public void DeleteKonfiguracija(int id)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Konfiguracija WHERE konfiguracijos_id=@id", sqlcon);

                com.Parameters.AddWithValue("@id", id);
                var result = Convert.ToInt32(com.ExecuteScalar());
                if (result > 0)
                {
                    string a = "Delete from Papildomi where konfiguracijos_id = @id ";
                    a += ("Delete from Konfiguracija where konfiguracijos_id = @id ");

                    //a += ();
                    cmd = new SqlCommand(a, sqlcon);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                else
                    MessageBox.Show(id + " <- Tokio ID nėra !");
                sqlcon.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
