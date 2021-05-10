using DBpraktika.Models;
using DBpraktika.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBpraktika.Forms.KonfiguracijosParinktys
{
    public partial class VarikliuForm : Form
    {
        private Variklis variklis;
        private VariklioRepository variklioRepos;

        private PavaruTipai pavaruTipai;
        private PavaruTipas pavaruTipas;
        private KuroTipas kuroTipas;

        private List<KuroTipas> kuroList = new List<KuroTipas>();
        private List<PavaruTipas> pavaruList = new List<PavaruTipas>();

        public VarikliuForm()
        {
            variklioRepos = new VariklioRepository();

            InitializeComponent();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            varikliuDataGridView.DataSource = variklioRepos.ShowVariklis();
            kuroDataGridView.DataSource = variklioRepos.ShowKuras();
            pavaruDataGridView.DataSource = variklioRepos.ShowPavaras();

            kuroBox.Items.Clear();
            pavaruBox.Items.Clear();

            kuroList = variklioRepos.GetKuroList();
            pavaruList = variklioRepos.GetPavaruList();

            for (int i = 0; i < kuroList.Count; i++)
            {
                kuroBox.Items.Add(kuroList[i].Kuro_Tipas);
            }

            for (int i = 0; i < pavaruList.Count; i++)
            {
                pavaruBox.Items.Add(pavaruList[i].Pavaru_Tipas);
            }
        }

        /* Kuras */

        private void AddKuraBtn_Click(object sender, EventArgs e)
        {
            if (kuroPavTxt.Text != string.Empty)
            {
                kuroTipas = new KuroTipas();
                kuroTipas.Kuro_Tipas = kuroPavTxt.Text;
                variklioRepos.InsertKuras(kuroTipas.Kuro_Tipas);
                LoadDataGrid();
            }
            else
                MessageBox.Show("Neįvedėte kuro pavadinimo !");
        }

        private void DeleteKuraBtn_Click(object sender, EventArgs e)
        {
            if (kuroIdTxt.Text != string.Empty)
            {
                if (Int32.TryParse(kuroIdTxt.Text, out int value))
                {
                    kuroTipas = new KuroTipas();
                    kuroTipas.Kuro_ID = Convert.ToInt32(kuroIdTxt.Text);
                    variklioRepos.DeleteKuras(kuroTipas.Kuro_ID);
                    LoadDataGrid();
                }
                else
                    MessageBox.Show("ID privalo būti parašytas skaičiais !");
            }
            else
                MessageBox.Show("Neįvedėte kuro ID !");
        }

        /* Pavaros */

        private void AddPavaraBtn_Click(object sender, EventArgs e)
        {
            if (pavaruPavTxt.Text != string.Empty)
            {
                pavaruTipas = new PavaruTipas();
                pavaruTipas.Pavaru_Tipas = pavaruPavTxt.Text;
                variklioRepos.InsertPavaras(pavaruTipas.Pavaru_Tipas);
                LoadDataGrid();
            }
            else
                MessageBox.Show("Neįvedėte pavarų tipo !");
        }

        private void DeletePavaraBtn_Click(object sender, EventArgs e)
        {
            if (pavaruIDtxt.Text != string.Empty)
            {
                if (Int32.TryParse(pavaruIDtxt.Text, out int value))
                {
                    pavaruTipas = new PavaruTipas();
                    pavaruTipas.Pavaru_ID = Convert.ToInt32(pavaruIDtxt.Text);
                    variklioRepos.DeletePavara(pavaruTipas.Pavaru_ID);
                    LoadDataGrid();
                }
                else
                    MessageBox.Show("ID privalo būti parašytas skaičiais !");
            }
            else
                MessageBox.Show("Privalote įvesti ID !");
        }

        /* Variklis */

        private void AddVarikliBtn_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(variklioKainaTxt.Text, out int value))
            {
                if (varklioPavTxt.Text != string.Empty && variklioKainaTxt.Text != string.Empty && pavaruBox.SelectedItem != null && kuroBox.SelectedItem != null)
                {
                    int pavaruIndex = pavaruBox.SelectedIndex;
                    int kuroIndex = kuroBox.SelectedIndex;
                    variklis = new Variklis();

                    variklis.Variklio_Pavadinimas = varklioPavTxt.Text;
                    variklis.Variklio_Kaina = Convert.ToDouble(variklioKainaTxt.Text);
                    variklis.Pavaru_Tipo_ID = pavaruList[pavaruIndex].Pavaru_ID;
                    variklis.Kuro_ID = kuroList[kuroIndex].Kuro_ID;

                    variklioRepos.InsertVariklis(variklis.Variklio_Pavadinimas, variklis.Variklio_Kaina, variklis.Pavaru_Tipo_ID, variklis.Kuro_ID);

                    LoadDataGrid();
                }
                else
                    MessageBox.Show("Privalote įvesti variklio pavadinimą, kainą, pasirinktit pavarų ir kuro tipą !");
            }
            else
                MessageBox.Show("Kaina privalo būti parašyta skaitmenimis !");
        }

        private void DeleteVarikliBtn_Click(object sender, EventArgs e)
        {
            if(variklioIDtxt.Text != null)
            {
                if (Int32.TryParse(variklioIDtxt.Text, out int value))
                {
                    variklis = new Variklis();

                    variklis.Variklio_ID = Convert.ToInt32(variklioIDtxt.Text);

                    variklioRepos.DeleteVarikli(variklis.Variklio_ID);

                    LoadDataGrid();
                }
                else
                    MessageBox.Show("ID privalo būti parašytas skaičiais !");
            }
            else
            MessageBox.Show("Nieko neįvedėte !");
        }
    }
}