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
    public partial class LoginPage : UserControl
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string query = "SELECT PERMISSION FROM USERS WHERE USERNAME = '" + textBoxUser.Text.Trim() + "' AND PASSWORD = '" + textBoxPass.Text.Trim() + "'";
            using (SqlConnection connection = new SqlConnection(FormLogin.SQLConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    FormLogin.isLogined = true;
                    if (dataTable.Rows[0][0].ToString() == "1")
                        FormLogin.UserPermission = 1;
                    else
                        FormLogin.UserPermission = 0;
                    labelUsername.Text = textBoxUser.Text.Trim();
                    panelAfterLogin.BringToFront();
                }
                else
                {
                    labelWarning.Visible = true;
                }
                connection.Close();
            }
            this.Parent.Focus();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Parent.Focus();
            FormLogin.isLogined = false;
            labelWarning.Visible = false;
            panelBeforeLogin.BringToFront();   
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Parent.Focus();
            FrmMain newForm = new FrmMain();
            newForm.Show();
        }

        /// <summary>
        /// Prevent user from clicking "Enter" key which breaks line in textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
