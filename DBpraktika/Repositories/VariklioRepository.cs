using DBpraktika.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBpraktika.Repositories
{
    internal class VariklioRepository
    {
        private string con = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ASUS\\Desktop\\VIKO\\2 Kursas\\S2\\Praktika\\DBpraktika\\DBpraktika\\Database1.mdf;Integrated Security=True";

        /* Variklis */

        public DataTable ShowVariklis()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT Variklis.variklio_id as 'Variklio ID', " +
                    " Variklis.variklio_pavadinimas as 'Pavadinimas', " +
                    " Variklis.variklio_kaina as 'Kaina', " +
                    " Kuro_tipas.kuro_tipas as 'Kuro Tipas', " +
                    " Pavaru_tipas.pavaru_tipas as 'Pavarų Tipas' " +
                    " FROM Variklis " +
                    " INNER JOIN Kuro_tipas ON Variklis.kuro_id = Kuro_tipas.kuro_id " +
                    " INNER JOIN Pavaru_tipai ON Variklis.pavaru_tipo_id = Pavaru_tipai.pavaru_tipo_id " +
                    " INNER JOIN Pavaru_tipas ON Pavaru_tipai.pavaru_id = pavaru_tipas.pavaru_id", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public DataTable ShowVariklis2()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT" +
                    " Variklis.variklio_pavadinimas as 'Variklis', " +
                    " Pavaru_tipas.pavaru_tipas as 'Pavarų Tipas', " +
                    " Kuro_tipas.kuro_tipas as 'Kuro Tipas', " +
                    " Variklis.variklio_kaina as 'Kaina' " +
                    " FROM Variklis " +
                    " INNER JOIN Kuro_tipas ON Variklis.kuro_id = Kuro_tipas.kuro_id " +
                    " INNER JOIN Pavaru_tipai ON Variklis.pavaru_tipo_id = Pavaru_tipai.pavaru_tipo_id " +
                    " INNER JOIN Pavaru_tipas ON Pavaru_tipai.pavaru_id = pavaru_tipas.pavaru_id", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public void InsertVariklis(string pavadinimas, double kaina, int pavaru_id, int kuro_id)
        {
            try
            {
                // REIKIA SUTVARKYTI ŠITĄ INSERTINIMĄ DĖL PAVARŲ ID !!
                PavaruTipai pavaruTipai = new PavaruTipai();
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT * FROM Pavaru_tipai WHERE pavaru_id = @id", sqlcon);
                com.Parameters.AddWithValue("@id", pavaru_id);

                SqlDataReader dataReader = com.ExecuteReader();
                while (dataReader.Read())
                {
                    int id = int.Parse(dataReader["pavaru_tipo_id"].ToString());
                    Console.WriteLine(id);
                    pavaruTipai.Pavaru_Tipo_ID = id;
                }
                sqlcon.Close();

                sqlcon.Open();
                SqlCommand sqlCom = new SqlCommand("SELECT COUNT(*) FROM Variklis WHERE variklio_pavadinimas=@pavadinimas", sqlcon);
                sqlCom.Parameters.AddWithValue("@pavadinimas", pavadinimas);

                var result = Convert.ToInt32(sqlCom.ExecuteScalar());
                if (result > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Ar norite atnaujinti šį variklį?", "Toks variklis jau egzistuoja !", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        //sqlcon.Open();
                        sqlCom = new SqlCommand("UPDATE Variklis SET variklio_kaina = @kaina, pavaru_tipo_id = @pavaru_id, kuro_id = @kuro_id WHERE variklio_pavadinimas = @pavadinimas", sqlcon);

                        sqlCom.Parameters.AddWithValue("@pavadinimas", pavadinimas);
                        sqlCom.Parameters.AddWithValue("@kaina", kaina);
                        sqlCom.Parameters.AddWithValue("@pavaru_id", pavaruTipai.Pavaru_Tipo_ID);
                        sqlCom.Parameters.AddWithValue("@kuro_id", kuro_id);
                        sqlCom.ExecuteNonQuery();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Variklis nebuvo pridėtas ar atnaujintas !");
                    }
                }
                else
                {
                    //sqlcon.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Variklis (variklio_pavadinimas, variklio_kaina, pavaru_tipo_id, kuro_id) VALUES (@pavadinimas, @kaina, @pavaru_id, @kuro_id)", sqlcon);
                    cmd.Parameters.AddWithValue("@pavadinimas", pavadinimas);
                    cmd.Parameters.AddWithValue("@kaina", kaina);
                    cmd.Parameters.AddWithValue("@pavaru_id", pavaruTipai.Pavaru_Tipo_ID);
                    cmd.Parameters.AddWithValue("@kuro_id", kuro_id);
                    cmd.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DeleteVarikli(int id)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Variklis WHERE variklio_id=@id", sqlcon);

                com.Parameters.AddWithValue("@id", id);
                var result = Convert.ToInt32(com.ExecuteScalar());
                if (result > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Ar norite ištrinti šį variklį (jeigu ištrinsite variklį" +
                        " išsitrins ir konfiguracijos kuriose jis yra) !", "DĖMESIO !", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        int konfID = -1;
                        SqlCommand sqlCom = new SqlCommand("SELECT konfiguracijos_id FROM Konfiguracija WHERE variklio_id=@id", sqlcon);
                        sqlCom.Parameters.AddWithValue("@id", id);
                        using (SqlDataReader sdr = sqlCom.ExecuteReader())
                        {
                            while (sdr.Read())
                            {
                                konfID = int.Parse(sdr["konfiguracijos_id"].ToString());
                            }
                        }
                        string a = ("delete from Papildomi where konfiguracijos_id=@konfid ");
                        a += ("delete from Konfiguracija where variklio_id = @id ");
                        a += ("delete from Variklis where variklio_id = @id");
                        cmd = new SqlCommand(a, sqlcon);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.Parameters.AddWithValue("konfid", konfID);
                        cmd.ExecuteNonQuery();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        MessageBox.Show("Variklis nebuvo ištrintas !");
                    }
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

        public List<Variklis> GetVarikliuList()
        {
            List<Variklis> varikliuList = new List<Variklis>();

            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand sqlCom = new SqlCommand("SELECT * FROM Variklis", sqlCon);

                sqlCon.Open();
                SqlDataReader sdr = sqlCom.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        string Pavadinimas = sdr["variklio_pavadinimas"].ToString(); //sdr.GetValue(i).ToString();
                        double kaina = Convert.ToDouble(sdr["variklio_kaina"].ToString());
                        Variklis variklis = new Variklis();

                        variklis.Variklio_Pavadinimas = Pavadinimas;
                        variklis.Variklio_Kaina = kaina;

                        varikliuList.Add(variklis);
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
            return varikliuList;
        }

        /* Kuras */

        public DataTable ShowKuras()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT kuro_id as 'Kuro ID', kuro_tipas as 'Tipas' FROM Kuro_tipas", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public void InsertKuras(string tipas)
        {
            try
            {
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand sqlCom = new SqlCommand("SELECT COUNT(*) FROM Kuro_tipas WHERE kuro_tipas=@tipas", sqlcon);
                sqlCom.Parameters.AddWithValue("@tipas", tipas);

                var result = Convert.ToInt32(sqlCom.ExecuteScalar());
                if (result > 0)
                {
                    MessageBox.Show("Toks kuro tipas jau egzituoja !");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Kuro_tipas (kuro_tipas) VALUES (@tipas)", sqlcon);
                    cmd.Parameters.AddWithValue("@tipas", tipas);
                    cmd.ExecuteNonQuery();
                }
                sqlcon.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DeleteKuras(int id)
        {
            try
            {
                SqlCommand cmd;
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Kuro_tipas WHERE kuro_id=@id", sqlcon);

                com.Parameters.AddWithValue("@id", id);
                var result = Convert.ToInt32(com.ExecuteScalar());
                if (result > 0)
                {
                    SqlCommand getVariklis = new SqlCommand("SELECT variklio_id FROM Variklis WHERE kuro_id=@kuro_id", sqlcon);
                    getVariklis.Parameters.AddWithValue("@kuro_id", id);

                    int variklioID = -1;
                    using (SqlDataReader sdr = getVariklis.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            variklioID = int.Parse(sdr["variklio_id"].ToString());
                        }
                    }

                    int konfID = -1;
                    SqlCommand sqlCom = new SqlCommand("SELECT konfiguracijos_id FROM Konfiguracija WHERE variklio_id=@id", sqlcon);
                    sqlCom.Parameters.AddWithValue("@id", variklioID);
                    using (SqlDataReader sdr = sqlCom.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            konfID = int.Parse(sdr["konfiguracijos_id"].ToString());
                        }
                    }

                    string a = ("Delete from Papildomi where konfiguracijos_id=@konfid ");
                    a += ("Delete From Konfiguracija Where konfiguracijos_id = @konfid ");
                    a += ("Delete From Variklis Where kuro_id = @id ");
                    a += ("Delete From Kuro_tipas Where kuro_id = @id ");

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

        public List<KuroTipas> GetKuroList()
        {
            List<KuroTipas> kuroList = new List<KuroTipas>();

            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand sqlCom = new SqlCommand("SELECT * FROM Kuro_Tipas", sqlCon);

                sqlCon.Open();
                SqlDataReader sdr = sqlCom.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int ID = int.Parse(sdr["kuro_id"].ToString()); //int.Parse(sdr.GetValue(i).ToString());
                        string KuroTipas = sdr["kuro_tipas"].ToString(); //sdr.GetValue(i).ToString();

                        KuroTipas kuroTipas = new KuroTipas();

                        kuroTipas.Kuro_ID = ID;
                        kuroTipas.Kuro_Tipas = KuroTipas;

                        kuroList.Add(kuroTipas);
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
            return kuroList;
        }

        /* Pavaros */

        public DataTable ShowPavaras()
        {
            SqlConnection sqlCon = new SqlConnection(con);
            sqlCon.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT pavaru_id as 'Pavarų ID', pavaru_tipas as 'Tipas' FROM Pavaru_tipas", sqlCon);
            DataTable dataTable = new DataTable();
            sda.Fill(dataTable);

            return dataTable;
        }

        public void InsertPavaras(string tipas)
        {
            try
            {
                PavaruTipai pavaruTipai = new PavaruTipai();
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand sqlCom = new SqlCommand("SELECT COUNT(*) FROM Pavaru_tipas WHERE pavaru_tipas=@tipas", sqlcon);
                sqlCom.Parameters.AddWithValue("@tipas", tipas);

                var result = Convert.ToInt32(sqlCom.ExecuteScalar());
                if (result > 0)
                {
                    MessageBox.Show("Toks pavarų tipas jau egzituoja !");
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO Pavaru_tipas (pavaru_tipas) VALUES (@tipas)", sqlcon);

                    cmd.Parameters.AddWithValue("@tipas", tipas);
                    cmd.ExecuteNonQuery();
                    sqlcon.Close();

                    sqlcon.Open();
                    SqlCommand com = new SqlCommand("SELECT * FROM Pavaru_tipas WHERE pavaru_tipas = @tipas", sqlcon);
                    com.Parameters.AddWithValue("@tipas", tipas);

                    SqlDataReader dataReader = com.ExecuteReader();
                    while (dataReader.Read())
                    {
                        int id = int.Parse(dataReader["pavaru_id"].ToString());
                        Console.WriteLine(id);
                        pavaruTipai.Pavaru_ID = id;
                    }
                    sqlcon.Close();

                    sqlcon.Open();

                    SqlCommand sqlCmd = new SqlCommand("INSERT INTO [Pavaru_tipai] (pavaru_id) Values (@id)", sqlcon);
                    sqlCmd.Parameters.AddWithValue("@id", pavaruTipai.Pavaru_ID);
                    sqlCmd.ExecuteNonQuery();
                    sqlcon.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void DeletePavara(int id)
        {
            try
            {
                PavaruTipai pavaruTipai = new PavaruTipai();
                SqlCommand cmd;
                SqlConnection sqlcon = new SqlConnection(con);
                sqlcon.Open();

                SqlCommand com = new SqlCommand("SELECT COUNT(*) FROM Pavaru_tipas WHERE pavaru_id=@id", sqlcon);

                com.Parameters.AddWithValue("@id", id);
                var result = Convert.ToInt32(com.ExecuteScalar());
                if (result > 0)
                {
                    SqlCommand sqlCom = new SqlCommand("SELECT * FROM Pavaru_tipai WHERE pavaru_id = @id", sqlcon);
                    sqlCom.Parameters.AddWithValue("@id", id);

                    SqlDataReader dataReader = sqlCom.ExecuteReader();
                    while (dataReader.Read())
                    {
                        int pavaros_id = int.Parse(dataReader["pavaru_tipo_id"].ToString());
                        Console.WriteLine(pavaros_id);
                        pavaruTipai.Pavaru_Tipo_ID = pavaros_id;
                    }
                    sqlcon.Close();

                    sqlcon.Open();

                    SqlCommand getVariklis = new SqlCommand("SELECT variklio_id FROM Variklis WHERE pavaru_tipo_id=@pavaru_tipo_id", sqlcon);
                    getVariklis.Parameters.AddWithValue("@pavaru_tipo_id", pavaruTipai.Pavaru_Tipo_ID);

                    int variklioID = -1;
                    using (SqlDataReader sdr = getVariklis.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            variklioID = int.Parse(sdr["variklio_id"].ToString());
                        }
                    }

                    Console.WriteLine("Variklio ID: " + variklioID);
                    SqlCommand getKonfiguracija = new SqlCommand("SELECT * FROM Konfiguracija WHERE variklio_id=@variklioID", sqlcon);
                    getKonfiguracija.Parameters.AddWithValue("@variklioID", variklioID);
                    int konfID = -1;
                    using (SqlDataReader sdr = getKonfiguracija.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            konfID = int.Parse(sdr["konfiguracijos_id"].ToString());
                        }
                    }
                    Console.WriteLine("Konfiguracijos ID: " + konfID);
                    string a = ("DELETE from Papildomi where konfiguracijos_id = @konfig_id ");
                    a += ("DELETE from Konfiguracija where variklio_id = @variklio_id ");
                    a += ("Delete From Variklis Where pavaru_tipo_id = @pavaru_tipo_id ");
                    a += ("Delete From Pavaru_tipai Where pavaru_id = @id ");
                    a += ("Delete From Pavaru_tipas Where pavaru_id = @id ");

                    cmd = new SqlCommand(a, sqlcon);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@pavaru_tipo_id", pavaruTipai.Pavaru_Tipo_ID);
                    cmd.Parameters.AddWithValue("@variklio_id", variklioID);
                    cmd.Parameters.AddWithValue("@konfig_id", konfID);
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

        public List<PavaruTipas> GetPavaruList()
        {
            List<PavaruTipas> pavaruList = new List<PavaruTipas>();

            try
            {
                SqlConnection sqlCon = new SqlConnection(con);
                SqlCommand sqlCom = new SqlCommand("SELECT * FROM pavaru_tipas", sqlCon);

                sqlCon.Open();
                SqlDataReader sdr = sqlCom.ExecuteReader();

                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        int ID = int.Parse(sdr["pavaru_id"].ToString()); //int.Parse(sdr.GetValue(i).ToString());
                        string PavaruTipas = sdr["pavaru_tipas"].ToString(); //sdr.GetValue(i).ToString();

                        PavaruTipas pavaruTipas = new PavaruTipas();

                        pavaruTipas.Pavaru_ID = ID;
                        pavaruTipas.Pavaru_Tipas = PavaruTipas;

                        pavaruList.Add(pavaruTipas);
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
            return pavaruList;
        }
    }
}