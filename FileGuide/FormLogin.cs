using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FileGuide
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            sidePanel.Height = LoginButton.Height;
            sidePanel.Top = LoginButton.Top;
            loginPage1.BringToFront();
        }

        public static string SQLConnectionString = @"Data Source=LAPTOP-MFVT6MG4\MSSQLSERVER01;Initial Catalog = DoAnLTTQ; Integrated Security = True";

        private void LoginButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = LoginButton.Height;
            sidePanel.Top = LoginButton.Top;
            loginPage1.BringToFront();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = SignupButton.Height;
            sidePanel.Top = SignupButton.Top;
            signupPage1.BringToFront();
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = InfoButton.Height;
            sidePanel.Top = InfoButton.Top;
            infoPage1.BringToFront();
        }
    }
}
