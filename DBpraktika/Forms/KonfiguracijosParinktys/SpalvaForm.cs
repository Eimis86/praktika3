using DBpraktika.Repositories;
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

namespace DBpraktika.Forms.KonfiguracijosParinktys
{
    public partial class SpalvaForm : Form
    {
        private SpalvosRepository spalvosRepository;
        private Spalva spalva;
        public SpalvaForm()
        {
            InitializeComponent();
            spalvosRepository = new SpalvosRepository();
            LoadDataGrid();

        }

        private void addSpalvaBtn_Click(object sender, EventArgs e)
        {
            if (spalvosPavTxt.Text != string.Empty && spalvosKainaTxt.Text != string.Empty)
            {
                if (Int32.TryParse(spalvosKainaTxt.Text, out int value))
                {
                    spalva = new Spalva();
                    spalva.Spalvos_Pavadinimas = spalvosPavTxt.Text;
                    spalva.Spalvos_Kaina = Convert.ToDouble(spalvosKainaTxt.Text);
                    spalvosRepository.InsertSpalva(spalva.Spalvos_Pavadinimas, spalva.Spalvos_Kaina);
                    LoadDataGrid();
                }
                else
                    MessageBox.Show("Kaina privalo būti parašyta skaičiais !");
            }
            else
                MessageBox.Show("Privalote įvesti spalvos pavadinimą ir kainą");
        }

        private void deleteSpalvaBtn_Click(object sender, EventArgs e)
        {
            if(spalvosIDtxt.Text != string.Empty)
            {
                if (Int32.TryParse(spalvosIDtxt.Text, out int value))
                {
                    spalva = new Spalva();
                    spalva.Spalvos_ID = Int32.Parse(spalvosIDtxt.Text.Trim());

                    spalvosRepository.DeleteSpalva(spalva.Spalvos_ID);
                    spalvuDataGridView.DataSource = spalvosRepository.ShowSpalva();
                }
                else
                    MessageBox.Show("ID privalo būti parašytas skaičiais !");
            }
            else
                MessageBox.Show("Privalote įvesti spalvos ID");
        }
        private void LoadDataGrid()
        {
            spalvuDataGridView.DataSource = spalvosRepository.ShowSpalva();
        }
    }
}
