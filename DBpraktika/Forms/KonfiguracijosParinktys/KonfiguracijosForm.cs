using DBpraktika.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBpraktika.Forms.KonfiguracijosParinktys
{
    public partial class KonfiguracijosForm : Form
    {
        KonfiguracijosRepository konfiguracijosRepos;
        PriedoRepository priedoRepos;
        public KonfiguracijosForm()
        {
            konfiguracijosRepos = new KonfiguracijosRepository();
            priedoRepos = new PriedoRepository();
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            konfiguracijosDataGridView.DataSource = konfiguracijosRepos.ShowKonfiguracijas();
        }

        private void ShowPriedaiBtn_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool isNumber = false;

            isNumber = int.TryParse(konfigIDTxt.Text, out id);
            if (konfigIDTxt.Text != string.Empty && isNumber == true)
            {
                //int id = int.Parse(konfigIDTxt.Text);
                prieduDataGridView.DataSource = priedoRepos.ShowKonfiguracijosPriedus(id);
            }
            else
                MessageBox.Show("Privalote įvesti konfigūracijos ID !");
        }

        private void DeleteKonfigBtn_Click(object sender, EventArgs e)
        {
            int id = 0;
            bool isNumber = false;

            isNumber = int.TryParse(deleteIDtxt.Text, out id);
            if (deleteIDtxt.Text != string.Empty && isNumber == true)
            {
                konfiguracijosRepos.DeleteKonfiguracija(id);
                LoadData();
            }
            else
                MessageBox.Show("Privalote įvesti konfigūracijos ID !");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
