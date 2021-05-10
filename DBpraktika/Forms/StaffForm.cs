using DBpraktika.Forms.KonfiguracijosParinktys;
using DBpraktika.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBpraktika.Repositories;
namespace DBpraktika.Forms
{
    public partial class StaffForm : Form
    {
        User user;
        KonfiguracijosRepository konfiguracijosRepos;
        PriedoRepository priedoRepos;
        public StaffForm(User user)
        {
            konfiguracijosRepos = new KonfiguracijosRepository();
            priedoRepos = new PriedoRepository();
            InitializeComponent();
            this.user = user;
            loggedUserTxt.Text = user.Name + " " + user.LastName;
            LoadData();
        }

        private void MarkesModeliaiBtn_Click(object sender, EventArgs e)
        {
            MarkesModeliaiForm mmf = new MarkesModeliaiForm();
            mmf.ShowDialog();
        }

        private void varikliaiBtn_Click(object sender, EventArgs e)
        {
            VarikliuForm varikliuForm = new VarikliuForm();
            varikliuForm.ShowDialog();

        }

        private void PrieduBtn_Click(object sender, EventArgs e)
        {
            PriedoForm priedoForm = new PriedoForm();
            priedoForm.ShowDialog();
        }

        private void spalvaBtn_Click(object sender, EventArgs e)
        {
            SpalvaForm spalvaForm = new SpalvaForm();
            spalvaForm.ShowDialog();
        }

        private void rataiBtn_Click(object sender, EventArgs e)
        {

            RataiForm rataiForm = new RataiForm();
            rataiForm.ShowDialog();
        }

        private void interjeraiBtn_Click(object sender, EventArgs e)
        {

            InterjeraiForm interjeraiForm = new InterjeraiForm();
            interjeraiForm.ShowDialog();
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
