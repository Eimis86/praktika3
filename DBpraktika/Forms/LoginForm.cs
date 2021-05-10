using DBpraktika.Models;
using DBpraktika.Repositories;
using System;
using System.Windows.Forms;

namespace DBpraktika.Forms
{
    public partial class LoginForm : Form
    {
        private UserRepository userRepos;

        public LoginForm()
        {
            InitializeComponent();
            userRepos = new UserRepository();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                User user = userRepos.StaffLogin(usernameTxt.Text, passwordTxt.Text);

                if (user.Username != null)
                {
                    this.Hide();
                    MessageBox.Show("Successful Login !");
                    if (user.UserType == "admin")
                    {
                        AdminForm adminForm = new AdminForm(user);
                        adminForm.ShowDialog();
                        this.Close();
                    }
                    else if (user.UserType == "staff")
                    {
                        StaffForm staffForm = new StaffForm(user);
                        staffForm.ShowDialog();
                        this.Close();
                    }
                    else
                        MessageBox.Show("Wrong User Type Check Data Base !");
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}