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
    public partial class InterjeraiForm : Form
    {
        Interjeras interjeras;
        InterjeroRepository interjeroRepository;
        public InterjeraiForm()
        {
            interjeroRepository = new InterjeroRepository();
            InitializeComponent();
            LoadDataGrid();
        }

        private void addInterjeraBtn_Click(object sender, EventArgs e)
        {
            if (interjeroPavTxt.Text != string.Empty && interjeroKainaTxt.Text != string.Empty)
            {
                if (Int32.TryParse(interjeroKainaTxt.Text, out int value))
                {
                    interjeras = new Interjeras();
                    interjeras.Interjero_Pavadinimas = interjeroPavTxt.Text;
                    interjeras.Interjero_Kaina = Convert.ToDouble(interjeroKainaTxt.Text);

                    interjeroRepository.InsertInterjeras(interjeras.Interjero_Pavadinimas, interjeras.Interjero_Kaina);
                    LoadDataGrid();
                }
                else
                    MessageBox.Show("Privalote įvesti kainą skaičiais !");
            }
            else
                MessageBox.Show("Privalote įvesti interjero pavadinimą ir kainą !");
        }

        private void deleteInterjeraBtn_Click(object sender, EventArgs e)
        {
            if (interjeroIDtxt.Text != string.Empty)
            {
                if (Int32.TryParse(interjeroIDtxt.Text, out int value))
                {
                    interjeras = new Interjeras();
                    interjeras.Interjero_ID = Convert.ToInt32(interjeroIDtxt.Text);
                    interjeroRepository.DeleteInterjeras(interjeras.Interjero_ID);
                    LoadDataGrid();
                }
                else
                    MessageBox.Show("ID Privalo būti skaičius !");
            }
            else
                MessageBox.Show("Privalote įvesti interjero ID !");
        }
        private void LoadDataGrid()
        {
            interjeruDataGridView.DataSource = interjeroRepository.ShowInterjerai();
        }

    }
}
