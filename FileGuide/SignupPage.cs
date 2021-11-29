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
            if (FormLogin.isLogined)
            {
                panelBeforeLogined.Visible = false;
                panelAfterLogin.Visible = true;
                
                if (FormLogin.UserPermission.ToString() == "1")
                {
                    labelPermis.Text = "admin";
                    labelAdmin.BringToFront();
                }    
                else
                {
                    labelPermis.Text = "guest";
                    labelGuest.BringToFront();
                }
            }
            else
            {
                panelBeforeLogined.Visible = true;
                panelAfterLogin.Visible = false;
            }
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            labelWarning1.Visible = false;
            labelWarning2.Visible = false;
            labelWarning2.ForeColor = Color.FromArgb(200, 0, 0);
            if (textBoxUser.Text.ToString().Trim() == "")
            {
                labelWarning1.Visible = true;
                labelWarning1.Text = "Vui lòng nhập tài khoản";
            }
            if (textBoxPass.Text.ToString().Trim() == "")
            {
                labelWarning2.Visible = true;
                labelWarning2.Text = "Vui lòng nhập mật khẩu";
                return;
            }
            string SelectQuery = "SELECT * FROM USERS WHERE USERNAME = " + textBoxUser.Text + "'";
            using (SqlConnection connection = new SqlConnection(FormLogin.SQLConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SelectQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    labelWarning2.Visible = true;
                    labelWarning2.Text = "Tài khoản đã tồn tại!";
                }
                else
                {
                    string InsertQuery = "INSERT INTO USERS (USERNAME, PASSWORD, PERMISSION)";
                    InsertQuery += " VALUES (@USERNAME, @PASSWORD, @PERMISSION)";
                    using (SqlCommand InsertCommand = new SqlCommand(InsertQuery,connection))
                    {
                        InsertCommand.Parameters.AddWithValue("@USERNAME", textBoxUser.Text);
                        InsertCommand.Parameters.AddWithValue("@PASSWORD", textBoxPass.Text);
                        InsertCommand.Parameters.AddWithValue("@PERMISSION", 0);
                        InsertCommand.ExecuteNonQuery();
                    }
                    labelWarning2.Visible = true;
                    labelWarning2.Text = "Đăng ký thành công";
                    labelWarning2.ForeColor = Color.FromArgb(0,200,0);
                    SignupPage_Load(sender,e);
                }
                connection.Close();
            }
        }

        private void SignupPage_VisibleChanged(object sender, EventArgs e)
        {
            SignupPage_Load(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            labelWarning2.ForeColor = Color.FromArgb(200, 0, 0);
            labelNotice.Visible = false;
            if (textBoxUserAfter.Text.ToString().Trim() == "" || textBoxPassAfter.Text.ToString().Trim() == "" || textBoxPerAfter.Text.ToString().Trim() == "")
            {
                labelNotice.Visible = true;
                labelNotice.Text = "Vui lòng nhập đầy đủ thông tin";
                return;
            }
            else if (!(textBoxPerAfter.Text.ToString().Trim() == "0" || textBoxPerAfter.Text.ToString().Trim() == "1"))
            {
                labelNotice.Visible = true;
                labelNotice.Text = "Vui lòng nhập chỉ nhập 0 hoặc 1 vào ô Quyền";
                return;
            }

            string SelectQuery = "SELECT * FROM USERS WHERE USERNAME = '" + textBoxUserAfter.Text + "'";
            using (SqlConnection connection = new SqlConnection(FormLogin.SQLConnectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(SelectQuery, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    labelNotice.Visible = true;
                    labelNotice.Text = "Tài khoản đã tồn tại!";
                }
                else
                {
                    string InsertQuery = "INSERT INTO USERS (USERNAME, PASSWORD, PERMISSION)";
                    InsertQuery += " VALUES (@USERNAME, @PASSWORD, @PERMISSION)";
                    using (SqlCommand InsertCommand = new SqlCommand(InsertQuery, connection))
                    {
                        InsertCommand.Parameters.AddWithValue("@USERNAME", textBoxUserAfter.Text);
                        InsertCommand.Parameters.AddWithValue("@PASSWORD", textBoxPassAfter.Text);
                        InsertCommand.Parameters.AddWithValue("@PERMISSION", int.Parse(textBoxPerAfter.Text));
                        InsertCommand.ExecuteNonQuery();
                    }
                    labelNotice.Visible = true;
                    labelNotice.Text = "Thêm mới thành công";
                    labelNotice.ForeColor = Color.FromArgb(0, 200, 0);
                    SignupPage_Load(sender, e);
                }
                connection.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            labelNotice.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            labelNotice.Visible = false;
        }
    }
}
