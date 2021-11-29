
namespace FileGuide
{
    partial class SignupPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxUser = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataGridViewUserLit = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ColumnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewUserList = new System.Windows.Forms.DataGridView();
            this.btnSignup = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label7 = new System.Windows.Forms.Label();
            this.labelWarning2 = new System.Windows.Forms.Label();
            this.labelWarning1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserLit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(192)))), ((int)(((byte)(228)))));
            this.textBoxPass.BorderRadius = 10;
            this.textBoxPass.BorderThickness = 2;
            this.textBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPass.DefaultText = "";
            this.textBoxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPass.DisabledState.Parent = this.textBoxPass;
            this.textBoxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPass.FocusedState.Parent = this.textBoxPass;
            this.textBoxPass.Font = new System.Drawing.Font("Questrial", 11F);
            this.textBoxPass.ForeColor = System.Drawing.Color.Black;
            this.textBoxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxPass.HoverState.Parent = this.textBoxPass;
            this.textBoxPass.Location = new System.Drawing.Point(795, 323);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxPass.PlaceholderText = "Mật khẩu";
            this.textBoxPass.SelectedText = "";
            this.textBoxPass.ShadowDecoration.Parent = this.textBoxPass;
            this.textBoxPass.Size = new System.Drawing.Size(304, 57);
            this.textBoxPass.TabIndex = 26;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(192)))), ((int)(((byte)(228)))));
            this.textBoxUser.BorderRadius = 10;
            this.textBoxUser.BorderThickness = 2;
            this.textBoxUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUser.DefaultText = "";
            this.textBoxUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUser.DisabledState.Parent = this.textBoxUser;
            this.textBoxUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUser.FocusedState.Parent = this.textBoxUser;
            this.textBoxUser.Font = new System.Drawing.Font("Questrial", 11F);
            this.textBoxUser.ForeColor = System.Drawing.Color.Black;
            this.textBoxUser.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxUser.HoverState.Parent = this.textBoxUser;
            this.textBoxUser.Location = new System.Drawing.Point(795, 232);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.PasswordChar = '\0';
            this.textBoxUser.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.textBoxUser.PlaceholderText = "Tên tài khoản";
            this.textBoxUser.SelectedText = "";
            this.textBoxUser.ShadowDecoration.Parent = this.textBoxUser;
            this.textBoxUser.Size = new System.Drawing.Size(304, 57);
            this.textBoxUser.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Merriweather Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(619, 64);
            this.label2.TabIndex = 28;
            this.label2.Text = "DANH SÁCH TÀI KHOẢN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataGridViewUserLit
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridViewUserLit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewUserLit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewUserLit.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewUserLit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridViewUserLit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewUserLit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Questrial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewUserLit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewUserLit.ColumnHeadersHeight = 4;
            this.DataGridViewUserLit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewUserLit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUsername,
            this.ColumnPassword});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewUserLit.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewUserLit.EnableHeadersVisualStyles = false;
            this.DataGridViewUserLit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewUserLit.Location = new System.Drawing.Point(58, 169);
            this.DataGridViewUserLit.Name = "DataGridViewUserLit";
            this.DataGridViewUserLit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewUserLit.RowHeadersVisible = false;
            this.DataGridViewUserLit.RowHeadersWidth = 100;
            this.DataGridViewUserLit.RowTemplate.Height = 28;
            this.DataGridViewUserLit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewUserLit.Size = new System.Drawing.Size(623, 449);
            this.DataGridViewUserLit.TabIndex = 29;
            this.DataGridViewUserLit.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewUserLit.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridViewUserLit.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridViewUserLit.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridViewUserLit.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridViewUserLit.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewUserLit.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewUserLit.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridViewUserLit.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridViewUserLit.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewUserLit.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridViewUserLit.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewUserLit.ThemeStyle.HeaderStyle.Height = 4;
            this.DataGridViewUserLit.ThemeStyle.ReadOnly = false;
            this.DataGridViewUserLit.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridViewUserLit.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridViewUserLit.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataGridViewUserLit.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridViewUserLit.ThemeStyle.RowsStyle.Height = 28;
            this.DataGridViewUserLit.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridViewUserLit.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColumnUsername
            // 
            this.ColumnUsername.HeaderText = "Tên tài khoản";
            this.ColumnUsername.MinimumWidth = 8;
            this.ColumnUsername.Name = "ColumnUsername";
            // 
            // ColumnPassword
            // 
            this.ColumnPassword.HeaderText = "Mật khẩu";
            this.ColumnPassword.MinimumWidth = 8;
            this.ColumnPassword.Name = "ColumnPassword";
            // 
            // DataGridViewUserList
            // 
            this.DataGridViewUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewUserList.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewUserList.ColumnHeadersHeight = 34;
            this.DataGridViewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewUserList.Location = new System.Drawing.Point(58, 154);
            this.DataGridViewUserList.Name = "DataGridViewUserList";
            this.DataGridViewUserList.RowHeadersWidth = 62;
            this.DataGridViewUserList.RowTemplate.Height = 28;
            this.DataGridViewUserList.Size = new System.Drawing.Size(623, 449);
            this.DataGridViewUserList.TabIndex = 30;
            // 
            // btnSignup
            // 
            this.btnSignup.BorderColor = System.Drawing.Color.Transparent;
            this.btnSignup.BorderRadius = 30;
            this.btnSignup.CheckedState.Parent = this.btnSignup;
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.CustomImages.Parent = this.btnSignup;
            this.btnSignup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignup.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignup.DisabledState.Parent = this.btnSignup;
            this.btnSignup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.btnSignup.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.btnSignup.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.White;
            this.btnSignup.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(119)))), ((int)(((byte)(199)))));
            this.btnSignup.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(192)))), ((int)(((byte)(228)))));
            this.btnSignup.HoverState.Parent = this.btnSignup;
            this.btnSignup.Location = new System.Drawing.Point(810, 474);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.ShadowDecoration.BorderRadius = 10;
            this.btnSignup.ShadowDecoration.Parent = this.btnSignup;
            this.btnSignup.Size = new System.Drawing.Size(260, 70);
            this.btnSignup.TabIndex = 31;
            this.btnSignup.Text = "Đăng ký";
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lexend", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(819, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(242, 70);
            this.label7.TabIndex = 32;
            this.label7.Text = "ĐĂNG KÝ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWarning2
            // 
            this.labelWarning2.AutoSize = true;
            this.labelWarning2.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWarning2.Location = new System.Drawing.Point(790, 384);
            this.labelWarning2.Name = "labelWarning2";
            this.labelWarning2.Size = new System.Drawing.Size(88, 30);
            this.labelWarning2.TabIndex = 33;
            this.labelWarning2.Text = "Warning";
            this.labelWarning2.Visible = false;
            // 
            // labelWarning1
            // 
            this.labelWarning1.AutoSize = true;
            this.labelWarning1.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelWarning1.Location = new System.Drawing.Point(790, 293);
            this.labelWarning1.Name = "labelWarning1";
            this.labelWarning1.Size = new System.Drawing.Size(88, 30);
            this.labelWarning1.TabIndex = 34;
            this.labelWarning1.Text = "Warning";
            this.labelWarning1.Visible = false;
            // 
            // SignupPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.labelWarning1);
            this.Controls.Add(this.labelWarning2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.DataGridViewUserList);
            this.Controls.Add(this.DataGridViewUserLit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Name = "SignupPage";
            this.Size = new System.Drawing.Size(1201, 744);
            this.Load += new System.EventHandler(this.SignupPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserLit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox textBoxPass;
        private Guna.UI2.WinForms.Guna2TextBox textBoxUser;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridViewUserLit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPassword;
        private System.Windows.Forms.DataGridView DataGridViewUserList;
        private Guna.UI2.WinForms.Guna2GradientButton btnSignup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelWarning2;
        private System.Windows.Forms.Label labelWarning1;
    }
}
