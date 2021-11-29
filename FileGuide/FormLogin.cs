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
        public static int UserPermission;
        public static bool isLogined = false;
        public static string SQLConnectionString = @"Data Source=LAPTOP-MFVT6MG4\MSSQLSERVER01;Initial Catalog = DoAnLTTQ; Integrated Security = True";

        public FormLogin()
        {
            InitializeComponent();
            sidePanel.Height = LoginButton.Height;
            sidePanel.Top = LoginButton.Top;
            loginPage1.Visible = true;
            signupPage1.Visible = false;
            infoPage1.Visible = false;
        }



        private void LoginButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = LoginButton.Height;
            sidePanel.Top = LoginButton.Top;
            loginPage1.Visible = true;
            signupPage1.Visible = false;
            infoPage1.Visible = false;
            //loginPage1.BringToFront();
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = SignupButton.Height;
            sidePanel.Top = SignupButton.Top;
            loginPage1.Visible = false;
            signupPage1.Visible = true;
            infoPage1.Visible = false;
        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = InfoButton.Height;
            sidePanel.Top = InfoButton.Top;
            loginPage1.Visible = false;
            signupPage1.Visible = false;
            infoPage1.Visible = true;
            //infoPage1.BringToFront();
        }
    }
}
