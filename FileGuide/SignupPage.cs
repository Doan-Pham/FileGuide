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
    public partial class SignupPage : UserControl
    {
        public SignupPage()
        {
            InitializeComponent();

        }

        private void SignupPage_Load(object sender, EventArgs e)
        {
            DataGridViewUserList.DataSource = GetAllUsers().Tables[0];

        }

        DataSet GetAllUsers()
        {
            DataSet data = new DataSet();
            string query = "SELECT * FROM USERS";
            using (SqlConnection connection = new SqlConnection(FormLogin.SQLConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}
