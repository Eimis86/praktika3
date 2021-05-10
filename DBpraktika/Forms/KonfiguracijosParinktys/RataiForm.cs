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
using DBpraktika.Models;

namespace DBpraktika.Forms.KonfiguracijosParinktys
{
    public partial class RataiForm : Form
    {
        Ratai ratai;
        RatuRepository ratuRepository;
        public RataiForm()
        {
            ratuRepository = new RatuRepository();
            InitializeComponent();
            LoadDataGrid();
        }

        private void addRataiBtn_Click(object sender, EventArgs e)
        {
            if (ratuPavTxt.Text != string.Empty && ratuKainaTxt.Text != string.Empty)
            {
                if (Int32.TryParse(ratuKainaTxt.Text, out int value))
                {
                    ratai = new Ratai();
                    ratai.Ratu_Tipas = ratuPavTxt.Text;
                    ratai.Ratu_Kaina = Convert.ToDouble(ratuKainaTxt.Text);
                    ratuRepository.InsertRatai(ratai.Ratu_Tipas, ratai.Ratu_Kaina);
                    LoadDataGrid();
                }
                else
                    MessageBox.Show("Kaina privalo būti parašyta skaičiais !");
            }
            else
                MessageBox.Show("Privalote įvesti ratų pavadinimą ir kainą !");
        }

        private void deleteRataiBtn_Click(object sender, EventArgs e)
        {
            if (ratuIDtxt.Text != string.Empty)
            {
                if (Int32.TryParse(ratuIDtxt.Text, out int value))
                {
                    ratai = new Ratai();
                    ratai.Ratu_ID = Convert.ToInt32(ratuIDtxt.Text);
                    ratuRepository.DeleteRatai(ratai.Ratu_ID);
                    LoadDataGrid();
                }
                else
                    MessageBox.Show("ID Privalo būti parašytas skaičiais !");
            }
            else
                MessageBox.Show("Privalote įvesti ratų ID !");
        }
        private void LoadDataGrid()
        {
            ratuDataGridView.DataSource = ratuRepository.ShowRatai();
        }
    }
}
