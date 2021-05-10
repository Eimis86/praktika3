using DBpraktika.Models;
using DBpraktika.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBpraktika.Forms.KonfiguracijosParinktys
{
    public partial class MarkesModeliaiForm : Form
    {
        private Modelis modelis;
        private Marke marke;
        private ModelioRepository modelioRepository;
        private MarkesRepository markesRepository;

        private List<Marke> markiuList = new List<Marke>();

        public MarkesModeliaiForm()
        {
            modelioRepository = new ModelioRepository();
            markesRepository = new MarkesRepository();
            InitializeComponent();
            LoadDataGrid();
        }

        private void AddMarkeBtn_Click(object sender, EventArgs e)
        {
            if (markesPavTxt.Text != string.Empty)
            {
                marke = new Marke();

                marke.Markes_Pavadinimas = markesPavTxt.Text;

                markesRepository.InsertMarke(marke.Markes_Pavadinimas);

                LoadDataGrid();
            }
            else
                MessageBox.Show("Neįvedėte markės pavadinimo !");
        }

        private void DeleteMarkeBtn_Click(object sender, EventArgs e)
        {
            if (markesIDtxt.Text != string.Empty)
            {
                if (Int32.TryParse(markesIDtxt.Text, out int value))
                {
                    marke = new Marke();

                    marke.Markes_ID = Convert.ToInt32(markesIDtxt.Text);

                    markesRepository.DeleteMarke(marke.Markes_ID);

                    LoadDataGrid();
                }
                else
                    MessageBox.Show("ID Privalo būti parašytas skaičiais !");
            }
            else
                MessageBox.Show("Privalote įvesti markės ID !");
        }

        private void AddModeliBtn_Click(object sender, EventArgs e)
        {
            if (modelioPavTxt.Text != string.Empty && markesComboBox.SelectedItem != null)
            {
                int selectedIndex = markesComboBox.SelectedIndex;

                modelis = new Modelis();

                modelis.Modelio_Pavadinimas = modelioPavTxt.Text;
                modelis.Markes_ID = markiuList[selectedIndex].Markes_ID;

                modelioRepository.InsertModelis(modelis.Modelio_Pavadinimas, modelis.Markes_ID);

                LoadDataGrid();
            }
            else
                MessageBox.Show("Privalote įvesti modelio pavadinimą ir pasirinkti markę !");
        }

        private void DeleteModeliBtn_Click(object sender, EventArgs e)
        {
            if (modelioIDtxt.Text != string.Empty)
            {if (Int32.TryParse(modelioIDtxt.Text, out int value))
                {
                    modelis = new Modelis();
                    modelis.Modelio_ID = Convert.ToInt32(modelioIDtxt.Text);
                    modelioRepository.DeleteModelis(modelis.Modelio_ID);
                    LoadDataGrid();
                }
                else
                    MessageBox.Show("ID Privalo būti parašytas skaičiais !"); 
            }
            else
                MessageBox.Show("Privalote įvesti modelio ID !");
        }

        private void LoadDataGrid()
        {
            markesDataGridView.DataSource = markesRepository.ShowMarke();
            modeliuDataGridView.DataSource = modelioRepository.ShowModelis();

            markesComboBox.Items.Clear();

            markiuList = markesRepository.GetMarkiuList();

            for (int i = 0; i < markiuList.Count; i++)
            {
                markesComboBox.Items.Add(markiuList[i].Markes_Pavadinimas);
            }
        }
    }
}