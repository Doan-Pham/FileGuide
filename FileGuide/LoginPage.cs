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
                    {
                        FormLogin.UserPermission = 1;
                        labelPermis.Text = "admin";
                    }
                    else
                    {
                        FormLogin.UserPermission = 0;
                        labelPermis.Text = "guest";
                    }
                    labelUsername.Text = textBoxUser.Text.Trim();
                    panelAfterLogin.BringToFront();
                }
                else
                {
                    labelWarning.Visible = true;
                }
                connection.Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormLogin.isLogined = false;
        }
    }
}
