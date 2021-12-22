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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //This fixes the issue: clicking on button creates weird border around it
            this.Select();
        }
        // Set static variables for use among child user controls
        public static int UserPermission;
        public static bool isLogined = false;
        public static string SQLConnectionString = @"Data Source=LAPTOP-MFVT6MG4\MSSQLSERVER01;Initial Catalog = DoAnLTTQ; Integrated Security = True";

        public FormLogin()
        {
            InitializeComponent();
            LoginButton.PerformClick();
        }

        // Switch to LoginPage
        private void LoginButton_Click(object sender, EventArgs e)
        {
            // Set the small blue panel
            sidePanel.Height = LoginButton.Height;
            sidePanel.Top = LoginButton.Top;

            loginPage1.Visible = true;
            signupPage1.Visible = false;
            infoPage1.Visible = false;

            loginPage1.Dock = DockStyle.Fill;
            signupPage1.Dock = DockStyle.None;
            infoPage1.Dock = DockStyle.None;
        }

        // Switch to ManagementPage
        private void ManagementButton_Click(object sender, EventArgs e)
        {
            //
            sidePanel.Height = ManagementButton.Height;
            sidePanel.Top = ManagementButton.Top;

            loginPage1.Visible = false;
            signupPage1.Visible = true;
            infoPage1.Visible = false;

            loginPage1.Dock = DockStyle.None;
            signupPage1.Dock = DockStyle.Fill;
            infoPage1.Dock = DockStyle.None;
        }

        // Same as InfoButton_Click
        private void InfoButton_Click(object sender, EventArgs e)
        {
            sidePanel.Height = InfoButton.Height;
            sidePanel.Top = InfoButton.Top;
            infoPage1.BringToFront();
            loginPage1.Visible = false;
            signupPage1.Visible = false;
            infoPage1.Visible = true;

            loginPage1.Dock = DockStyle.None;
            signupPage1.Dock = DockStyle.None;
            infoPage1.Dock = DockStyle.Fill;
        }
    }
}
