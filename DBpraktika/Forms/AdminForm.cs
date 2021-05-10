using DBpraktika.Forms.KonfiguracijosParinktys;
using DBpraktika.Models;
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

namespace DBpraktika.Forms
{
    public partial class AdminForm : Form
    {
        User user;
        UserRepository userRepository;
        public AdminForm(User user)
        {
            userRepository = new UserRepository();
            InitializeComponent();
            this.user = user;
            loggedUserTxt.Text = user.Name + " " + user.LastName;
            LoadData();
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

        private void varikliaiBtn_Click(object sender, EventArgs e)
        {
            VarikliuForm varikliuForm = new VarikliuForm();
            varikliuForm.ShowDialog();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text != string.Empty && passwordTxt.Text != string.Empty && password2Txt.Text != string.Empty && nameTxt.Text != string.Empty && lastnameTxt.Text != string.Empty)
            {
                if (passwordTxt.Text == password2Txt.Text)
                {
                    user = new User();

                    user.Username = usernameTxt.Text;
                    user.Password = passwordTxt.Text;
                    user.Name = nameTxt.Text;
                    user.LastName = lastnameTxt.Text;
                    user.UserType = "staff";

                    userRepository.InsertUser(user.Username, user.Password, user.Name, user.LastName, user.UserType);
                    LoadData();
                }
                else
                    MessageBox.Show("Įvesti slaptažodžiai nesutampa !");
            }
            else
                MessageBox.Show("Kuriant naują naudotoją visi laukai privalo būti užpildyti !");
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            if (userIdTxt.Text != string.Empty)
            {
                if (Int32.TryParse(userIdTxt.Text, out int value))
                {
                    user = new User();

                    user.ID = Convert.ToInt32(userIdTxt.Text);

                    userRepository.DeleteUser(user.ID);

                    LoadData();
                }
                else
                    MessageBox.Show("ID Privalo būti skaičius !");
            }
            else
                MessageBox.Show("Privalote įvesti ID naudotojo kurį norite ištrinti.");
        }

        private void LoadData()
        {
            userGridView.DataSource = userRepository.ShowUsers();
        }

        private void PrieduBtn_Click(object sender, EventArgs e)
        {
            PriedoForm priedoForm = new PriedoForm();
            priedoForm.ShowDialog();
        }

        private void MarkesModeliaiBtn_Click(object sender, EventArgs e)
        {
            MarkesModeliaiForm mmf = new MarkesModeliaiForm();
            mmf.ShowDialog();
        }

        private void KonfiguracijosBtn_Click(object sender, EventArgs e)
        {
            KonfiguracijosForm kf = new KonfiguracijosForm();
            kf.ShowDialog();
        }
    }
}
