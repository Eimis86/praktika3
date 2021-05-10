using DBpraktika.Forms;
using DBpraktika.Models;
using DBpraktika.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DBpraktika
{
    public partial class MainWindow : Form
    {
        private Modelis modelis = new Modelis();
        private MarkesRepository markesRepository;
        private ModelioRepository modelioRepository;

        private List<Marke> markiuList = new List<Marke>();
        private List<Modelis> modeliuList = new List<Modelis>();

        private VariklioRepository variklioRepository;
        private List<Variklis> varikliuList = new List<Variklis>();

        private InterjeroRepository interjeroRepository;
        private List<Interjeras> interjeruList = new List<Interjeras>();

        private RatuRepository ratuRepository;
        private List<Ratai> ratuList = new List<Ratai>();

        private PriedoRepository priedoRepository;
        private List<Priedas> prieduList = new List<Priedas>();

        private SpalvosRepository spalvosRepository;
        private List<Spalva> spalvuList = new List<Spalva>();

        private KonfiguracijosRepository konfiguracijosRepository;
        private double variklioSuma = 0;
        private double ratuSuma = 0;
        private double spalvosSuma = 0;
        private double interjeroSuma = 0;
        private double prieduKaina = 0;

        public MainWindow()
        {
            InitRepos();
            InitializeComponent();
            AllFalse();
        }

        private void AdminLoginBtn_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void InitRepos()
        {
            ratuRepository = new RatuRepository();
            markesRepository = new MarkesRepository();
            modelioRepository = new ModelioRepository();
            variklioRepository = new VariklioRepository();
            interjeroRepository = new InterjeroRepository();
            priedoRepository = new PriedoRepository();
            spalvosRepository = new SpalvosRepository();
            konfiguracijosRepository = new KonfiguracijosRepository();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
        }

        /* Markes / Modeliai */

        private void GalutineSuma()
        {
            galutineKainaTxt.Text = (variklioSuma + ratuSuma + spalvosSuma + interjeroSuma + prieduKaina).ToString();
        }

        private void MarkeBtn_Click(object sender, EventArgs e)
        {
            MarkiuLoadDataGrid();
            AllFalse();
            markeFlow.Visible = true;
        }

        private void MarkiuLoadDataGrid()
        {
            markiuList.Clear();
            markeComboBox.Items.Clear();

            markiuList = markesRepository.GetMarkiuList();

            for (int i = 0; i < markiuList.Count; i++)
            {
                markeComboBox.Items.Add(markiuList[i].Markes_Pavadinimas);
            }
        }

        private void LoadModelBtn_Click(object sender, EventArgs e)
        {
            if (markeComboBox.SelectedIndex != -1)
            {
                modelisComboBox.Items.Clear();

                modeliuList.Clear();
                int selectedIndex = markeComboBox.SelectedIndex;

                modelis = new Modelis();

                modelis.Markes_ID = markiuList[selectedIndex].Markes_ID;

                modeliuList = modelioRepository.GetModeliuList(modelis.Markes_ID);
                //getMarke.Text = markiuList[selectedIndex].Markes_Pavadinimas;
                for (int i = 0; i < modeliuList.Count; i++)
                {
                    modelisComboBox.Items.Add(modeliuList[i].Modelio_Pavadinimas);
                }
            }
            else
                MessageBox.Show("Nieko nepasirinkote !");
            // MarkiuLoadDataGrid();
        }

        private void AddMarkModBtn_Click(object sender, EventArgs e)
        {
            if (markeComboBox.SelectedIndex != -1 && modelisComboBox.SelectedIndex != -1)
            {
                markesLbl.Text = markiuList[markeComboBox.SelectedIndex].Markes_Pavadinimas;
                modelisLbl.Text = modeliuList[modelisComboBox.SelectedIndex].Modelio_Pavadinimas;
            }
            else
                MessageBox.Show("Privalote pasirinkti marke ir modelį !");
        }

        /* VARIKLIS */

        private void VariklisBtn_Click(object sender, EventArgs e)
        {
            VarikliuLoadDataGrid();
            AllFalse();
            varikliuFlow.Visible = true;
        }

        private void VarikliuLoadDataGrid()
        {
            varikliuList.Clear();
            varikliuComboBox.Items.Clear();

            varikliuDataGridView.DataSource = variklioRepository.ShowVariklis2();

            varikliuList = variklioRepository.GetVarikliuList();

            for (int i = 0; i < varikliuList.Count; i++)
            {
                varikliuComboBox.Items.Add(varikliuList[i].Variklio_Pavadinimas);
            }
        }

        private void AddVarikliBtn_Click(object sender, EventArgs e)
        {
            if (varikliuComboBox.SelectedIndex != -1)
            {
                variklioLbl.Text = varikliuList[varikliuComboBox.SelectedIndex].Variklio_Pavadinimas;
                variklioSuma = varikliuList[varikliuComboBox.SelectedIndex].Variklio_Kaina;
                GalutineSuma();
            }
            else
                MessageBox.Show("Nieko nepasirinkote !");
        }

        /* SPALVA */

        private void SpalvaBtn_Click(object sender, EventArgs e)
        {
            SpalvuLoadComboBox();
            AllFalse();
            spalvosFlow.Visible = true;
        }

        private void SpalvuLoadComboBox()
        {
            spalvuList.Clear();
            spalvuComboBox.Items.Clear();
            spalvuList = spalvosRepository.GetSpalvuList();

            spalvuDataGridView.DataSource = spalvosRepository.ShowSpalva2();

            for (int i = 0; i < spalvuList.Count; i++)
            {
                spalvuComboBox.Items.Add(spalvuList[i].Spalvos_Pavadinimas);
            }
        }

        private void AddSpalvaBtn_Click(object sender, EventArgs e)
        {
            if (spalvuComboBox.SelectedIndex != -1)
            {
                spalvosLbl.Text = spalvuList[spalvuComboBox.SelectedIndex].Spalvos_Pavadinimas;
                spalvosSuma = spalvuList[spalvuComboBox.SelectedIndex].Spalvos_Kaina;
                GalutineSuma();
            }
            else
                MessageBox.Show("Nieko nepasirinkote !");
        }

        /* RATAI */

        private void RataiBtn_Click(object sender, EventArgs e)
        {
            RatuLoadDataGrid();

            AllFalse();
            rataiFlow.Visible = true;
        }

        private void AddRataiBtn_Click(object sender, EventArgs e)
        {
            if (ratuComboBox.SelectedIndex != -1)
            {
                rataiLbl.Text = ratuList[ratuComboBox.SelectedIndex].Ratu_Tipas;
                ratuSuma = ratuList[ratuComboBox.SelectedIndex].Ratu_Kaina;
                GalutineSuma();
            }
            else
                MessageBox.Show("Nieko nepasirinkote !");
        }

        private void RatuLoadDataGrid()
        {
            ratuList.Clear();
            ratuComboBox.Items.Clear();
            ratuDataGridView.DataSource = ratuRepository.ShowRatai2();
            ratuList = ratuRepository.GetRatuList();

            for (int i = 0; i < ratuList.Count; i++)
            {
                ratuComboBox.Items.Add(ratuList[i].Ratu_Tipas);
            }
        }

        /* INTERJERAS */

        private void InterjerasBtn_Click(object sender, EventArgs e)
        {
            InterjeruLoadDataGrid();
            AllFalse();
            interjeroFlow.Visible = true;
        }

        private void AddInterjeraBtn_Click(object sender, EventArgs e)
        {
            if (interjeroComboBox.SelectedIndex != -1)
            {
                interjerasLbl.Text = interjeruList[interjeroComboBox.SelectedIndex].Interjero_Pavadinimas;
                interjeroSuma = interjeruList[interjeroComboBox.SelectedIndex].Interjero_Kaina;
                GalutineSuma();
            }
            else
                MessageBox.Show("Nieko nepasirinkote !");
        }

        private void InterjeruLoadDataGrid()
        {
            interjeruList.Clear();
            interjeroComboBox.Items.Clear();
            interjeruList = interjeroRepository.GetInterjeruList();

            interjeroDataGridView.DataSource = interjeroRepository.ShowInterjerai2();

            for (int i = 0; i < interjeruList.Count; i++)
            {
                interjeroComboBox.Items.Add(interjeruList[i].Interjero_Pavadinimas);
            }
        }

        /* PRIEDAI */

        private void PriedaiBtn_Click(object sender, EventArgs e)
        {
            AllFalse();

            PrieduLoadDataGrid();
            prieduFlow.Visible = true;
        }

        private void PrieduLoadDataGrid()
        {
            prieduList.Clear();
            priedoComboBox.Items.Clear();
            prieduDataGridView.DataSource = priedoRepository.ShowPriedai2();

            prieduList = priedoRepository.GetPrieduList();

            for (int i = 0; i < prieduList.Count; i++)
            {
                priedoComboBox.Items.Add(prieduList[i].Priedo_Pavadinimas);
            }
        }

        private void AddPriedaBtn_Click(object sender, EventArgs e)
        {
            if (priedoComboBox.SelectedIndex != -1)
            {
                if (prieduListBox.Items.Contains(prieduList[priedoComboBox.SelectedIndex].Priedo_Pavadinimas))
                {
                    MessageBox.Show("Toks priedas jau yra pridėtas !");
                }
                else
                {
                    prieduListBox.Items.Add(prieduList[priedoComboBox.SelectedIndex].Priedo_Pavadinimas);
                    prieduKaina += prieduList[priedoComboBox.SelectedIndex].Priedo_Kaina;
                    GalutineSuma();
                }
            }
            else
                MessageBox.Show("Nieko nepasirinkote !");
        }

        /* PAGALBINĖS */

        private void AllFalse()
        {
            markeFlow.Visible = false;
            varikliuFlow.Visible = false;
            spalvosFlow.Visible = false;
            interjeroFlow.Visible = false;
            rataiFlow.Visible = false;
            prieduFlow.Visible = false;
        }

        private void IstrintiPriedaBtn_Click(object sender, EventArgs e)// 2 TESTAI IR PYZDA? Ten pvm nuskaiciuoja EIK
        {
            try
            {
                if (prieduListBox.SelectedItems.Count > 0)
                {
                    var removeItems = new List<string>();

                    foreach (var listItem in prieduList)
                    {
                        foreach (var item in prieduListBox.SelectedItems)
                        {
                            Console.WriteLine(item.ToString());
                            if (item.ToString() == listItem.Priedo_Pavadinimas)
                            {
                                Console.WriteLine(listItem.Priedo_Kaina);
                                Console.WriteLine(item.ToString());
                                prieduKaina -= listItem.Priedo_Kaina;
                                removeItems.Add(item.ToString());
                            }
                            GalutineSuma();
                        }
                        foreach (var item in removeItems)
                        {
                            prieduListBox.Items.Remove(item.ToString());
                        }
                    }
                }
                else
                    MessageBox.Show("Nepasirinkote nė vieno priedo ištrynimui !");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AtsauktiBtn_Click(object sender, EventArgs e)
        {
            DialogResult ds = MessageBox.Show("Ar tikrai norite ištrinti dabartinius pasirinkimus?", " Dėmesio !", MessageBoxButtons.YesNo);

            if (ds == DialogResult.Yes)
            {
                markesLbl.Text = "------";
                modelisLbl.Text = "------";
                variklioLbl.Text = "------";
                spalvosLbl.Text = "------";
                rataiLbl.Text = "------";
                interjerasLbl.Text = "------";
                galutineKainaTxt.Text = "-------";

                for (int i = prieduListBox.Items.Count - 1; i >= 0; i--)
                    prieduListBox.Items.Remove(prieduListBox.Items[i]);
            }
        }

        private void PatvirtintiBtn_Click(object sender, EventArgs e)
        {
            if (markesLbl.Text != "------" && modelisLbl.Text != "------")
            {
                if (variklioLbl.Text != "------")
                {
                    if (spalvosLbl.Text != "------")
                    {
                        if (rataiLbl.Text != "------")
                        {
                            if (interjerasLbl.Text != "------")
                            {
                                double suma = Convert.ToDouble(galutineKainaTxt.Text);
                                Console.WriteLine(interjerasLbl.Text);
                                Konfiguracija konfiguracija;
                                konfiguracija = konfiguracijosRepository.InsertKonfiguracija(modelisLbl.Text, variklioLbl.Text, spalvosLbl.Text, rataiLbl.Text, interjerasLbl.Text, suma);

                                int modelioID = konfiguracija.Modelio_ID;
                                int variklioID = konfiguracija.Variklio_ID;
                                int spalvosID = konfiguracija.Spalvos_ID;
                                int ratuID = konfiguracija.Ratu_ID;
                                int interjeroID = konfiguracija.Interjero_ID;

                                Konfiguracija konf;
                                konf = konfiguracijosRepository.GetKonfiguracija(modelioID, variklioID, spalvosID, ratuID, interjeroID, suma);

                                foreach (string priedas in prieduListBox.Items)
                                {
                                    priedoRepository.InsertKonfiguracijosPrieda(priedas, konf.Konfiguracijos_ID);
                                }

                                MessageBox.Show("Konfigūracija sėkmingai pridėta !");
                            }
                            else
                                MessageBox.Show("Privalote pasirinkti interjero tipą !");
                        }
                        else
                            MessageBox.Show("Privalote pasirinkti ratų tipą !");
                    }
                    else
                        MessageBox.Show("Privalote pasirinkti spalvą !");
                }
                else
                    MessageBox.Show("Privalote pasirinkti variklį !");
            }
            else
                MessageBox.Show("Privalote pasirinkti marke ir modelį !");
        }
    }
}