using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBpraktika.Models;
using DBpraktika.Repositories;

namespace DBpraktika.Forms.KonfiguracijosParinktys
{
    public partial class PriedoForm : Form
    {
        PriedoRepository priedoRepository;
        Priedas priedas;
        public PriedoForm()
        {
            priedoRepository = new PriedoRepository();
            InitializeComponent();
            LoadDataGrid();
        }

        private void LoadDataGrid()
        {
            prieduDataGridView.DataSource = priedoRepository.ShowPriedai();
        }

        private void AddPriedaBtn_Click(object sender, EventArgs e)
        {
            if (priedoPavTxt.Text != string.Empty && priedoKainaTxt.Text != string.Empty)
            {
                if (Int32.TryParse(priedoKainaTxt.Text, out int value))
                {
                    priedas = new Priedas();
                    priedas.Priedo_Pavadinimas = priedoPavTxt.Text;
                    priedas.Priedo_Kaina = Convert.ToDouble(priedoKainaTxt.Text);

                    priedoRepository.InsertPrieda(priedas.Priedo_Pavadinimas, priedas.Priedo_Kaina);
                    LoadDataGrid();
                }
                else
                    MessageBox.Show("Kaina kaina privalo būti parašyta skaičiais !");
            }
            else
                MessageBox.Show("Privalote įvesti priedo pavadinimą ir kainą !");
        }

        private void DeletePriedaBtn_Click(object sender, EventArgs e)
        {
            if (priedoIDtxt.Text != string.Empty)
            {
                if (Int32.TryParse(priedoIDtxt.Text, out int value))
                {
                    priedas = new Priedas();
                    priedas.Priedo_ID = Convert.ToInt32(priedoIDtxt.Text);
                    priedoRepository.DeletePrieda(priedas.Priedo_ID);
                    LoadDataGrid();
                }
                else
                    MessageBox.Show("ID Privalo būti parašytas skaičiais !");
            }
            else
                MessageBox.Show("Privalote įvesti priedo ID !");
        }
    }
}
