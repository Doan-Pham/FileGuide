
namespace FileGuide
{
    partial class ManagementPage
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
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.DataGridViewUserList = new System.Windows.Forms.DataGridView();
            this.btnSignup = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.labelWarning2 = new System.Windows.Forms.Label();
            this.labelWarning1 = new System.Windows.Forms.Label();
            this.SignupPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.gradientPanel2 = new FileGuide.CustomControls.CustomPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customPanel1 = new FileGuide.CustomControls.CustomPanel();
            this.gradientPanelBtnLogin = new FileGuide.CustomControls.CustomPanel();
            this.labelNotice = new System.Windows.Forms.Label();
            this.panelAfterLogin = new System.Windows.Forms.Panel();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.customPanel7 = new FileGuide.CustomControls.CustomPanel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.customPanel6 = new FileGuide.CustomControls.CustomPanel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.customPanel5 = new FileGuide.CustomControls.CustomPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.customPanel4 = new FileGuide.CustomControls.CustomPanel();
            this.textBoxPermissionAfter = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.customPanel3 = new FileGuide.CustomControls.CustomPanel();
            this.textBoxPasswordAfter = new System.Windows.Forms.TextBox();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.UsernameAfterUnderline = new FileGuide.CustomControls.CustomPanel();
            this.textBoxUsernameAfter = new System.Windows.Forms.TextBox();
            this.pictureBoxUsernameAfter = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGuest = new System.Windows.Forms.Label();
            this.labelPermis = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gradientPanelBackgroundGuest = new FileGuide.CustomControls.CustomPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gradientPanelBackgroundAdmin = new FileGuide.CustomControls.CustomPanel();
            this.labelDSTK = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserList)).BeginInit();
            this.SignupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gradientPanelBtnLogin.SuspendLayout();
            this.panelAfterLogin.SuspendLayout();
            this.panelAdmin.SuspendLayout();
            this.customPanel7.SuspendLayout();
            this.customPanel6.SuspendLayout();
            this.customPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsernameAfter)).BeginInit();
            this.gradientPanelBackgroundGuest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gradientPanelBackgroundAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPass
            // 
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPass.Font = new System.Drawing.Font("Questrial", 11F);
            this.textBoxPass.ForeColor = System.Drawing.Color.Black;
            this.textBoxPass.Location = new System.Drawing.Point(204, 414);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(249, 47);
            this.textBoxPass.TabIndex = 26;
            // 
            // textBoxUser
            // 
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUser.Font = new System.Drawing.Font("Questrial", 11F);
            this.textBoxUser.ForeColor = System.Drawing.Color.Black;
            this.textBoxUser.Location = new System.Drawing.Point(204, 267);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUser.Multiline = true;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(249, 47);
            this.textBoxUser.TabIndex = 25;
            this.textBoxUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // DataGridViewUserList
            // 
            this.DataGridViewUserList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewUserList.BackgroundColor = System.Drawing.Color.White;
            this.DataGridViewUserList.ColumnHeadersHeight = 34;
            this.DataGridViewUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewUserList.Location = new System.Drawing.Point(29, 106);
            this.DataGridViewUserList.Name = "DataGridViewUserList";
            this.DataGridViewUserList.ReadOnly = true;
            this.DataGridViewUserList.RowHeadersWidth = 62;
            this.DataGridViewUserList.RowTemplate.Height = 28;
            this.DataGridViewUserList.Size = new System.Drawing.Size(576, 593);
            this.DataGridViewUserList.TabIndex = 30;
            // 
            // btnSignup
            // 
            this.btnSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSignup.FlatAppearance.BorderSize = 0;
            this.btnSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignup.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.ForeColor = System.Drawing.Color.Transparent;
            this.btnSignup.Location = new System.Drawing.Point(0, 0);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(260, 71);
            this.btnSignup.TabIndex = 31;
            this.btnSignup.Text = "Đăng ký";
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            this.btnSignup.MouseEnter += new System.EventHandler(this.btnSignup_MouseEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lexend", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.label7.Location = new System.Drawing.Point(180, 66);
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
            this.labelWarning2.Location = new System.Drawing.Point(153, 462);
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
            this.labelWarning1.Location = new System.Drawing.Point(153, 317);
            this.labelWarning1.Name = "labelWarning1";
            this.labelWarning1.Size = new System.Drawing.Size(88, 30);
            this.labelWarning1.TabIndex = 34;
            this.labelWarning1.Text = "Warning";
            this.labelWarning1.Visible = false;
            // 
            // SignupPanel
            // 
            this.SignupPanel.Controls.Add(this.label9);
            this.SignupPanel.Controls.Add(this.pictureBox3);
            this.SignupPanel.Controls.Add(this.gradientPanel2);
            this.SignupPanel.Controls.Add(this.label8);
            this.SignupPanel.Controls.Add(this.pictureBox1);
            this.SignupPanel.Controls.Add(this.customPanel1);
            this.SignupPanel.Controls.Add(this.gradientPanelBtnLogin);
            this.SignupPanel.Controls.Add(this.textBoxPass);
            this.SignupPanel.Controls.Add(this.textBoxUser);
            this.SignupPanel.Controls.Add(this.labelWarning2);
            this.SignupPanel.Controls.Add(this.label7);
            this.SignupPanel.Controls.Add(this.labelWarning1);
            this.SignupPanel.Location = new System.Drawing.Point(633, 0);
            this.SignupPanel.Name = "SignupPanel";
            this.SignupPanel.Size = new System.Drawing.Size(583, 816);
            this.SignupPanel.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lexend SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label9.Location = new System.Drawing.Point(153, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 29);
            this.label9.TabIndex = 45;
            this.label9.Text = "MẬT KHẨU";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FileGuide.Properties.Resources.Icon_Password;
            this.pictureBox3.Location = new System.Drawing.Point(152, 411);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 44;
            this.pictureBox3.TabStop = false;
            // 
            // gradientPanel2
            // 
            this.gradientPanel2.Angle = 0F;
            this.gradientPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanel2.BorderRadius = 0;
            this.gradientPanel2.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.gradientPanel2.ForeColor = System.Drawing.Color.White;
            this.gradientPanel2.HoverColor = System.Drawing.Color.Empty;
            this.gradientPanel2.Location = new System.Drawing.Point(153, 454);
            this.gradientPanel2.Name = "gradientPanel2";
            this.gradientPanel2.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.gradientPanel2.Size = new System.Drawing.Size(303, 4);
            this.gradientPanel2.TabIndex = 43;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lexend SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label8.Location = new System.Drawing.Point(148, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 29);
            this.label8.TabIndex = 42;
            this.label8.Text = "TÀI KHOẢN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FileGuide.Properties.Resources.Icon_Username;
            this.pictureBox1.Location = new System.Drawing.Point(151, 265);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // customPanel1
            // 
            this.customPanel1.Angle = 0F;
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.BorderRadius = 0;
            this.customPanel1.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.customPanel1.ForeColor = System.Drawing.Color.White;
            this.customPanel1.HoverColor = System.Drawing.Color.Empty;
            this.customPanel1.Location = new System.Drawing.Point(150, 307);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.customPanel1.Size = new System.Drawing.Size(303, 4);
            this.customPanel1.TabIndex = 40;
            // 
            // gradientPanelBtnLogin
            // 
            this.gradientPanelBtnLogin.Angle = 0F;
            this.gradientPanelBtnLogin.BackColor = System.Drawing.Color.Transparent;
            this.gradientPanelBtnLogin.BorderRadius = 30;
            this.gradientPanelBtnLogin.Controls.Add(this.btnSignup);
            this.gradientPanelBtnLogin.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.gradientPanelBtnLogin.ForeColor = System.Drawing.Color.White;
            this.gradientPanelBtnLogin.HoverColor = System.Drawing.Color.Empty;
            this.gradientPanelBtnLogin.Location = new System.Drawing.Point(180, 555);
            this.gradientPanelBtnLogin.Name = "gradientPanelBtnLogin";
            this.gradientPanelBtnLogin.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.gradientPanelBtnLogin.Size = new System.Drawing.Size(260, 71);
            this.gradientPanelBtnLogin.TabIndex = 35;
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Font = new System.Drawing.Font("Questrial", 9.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelNotice.Location = new System.Drawing.Point(128, 481);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(341, 30);
            this.labelNotice.TabIndex = 31;
            this.labelNotice.Text = "Tài khoản hoặc mật khẩu chưa đúng !";
            this.labelNotice.Visible = false;
            // 
            // panelAfterLogin
            // 
            this.panelAfterLogin.Controls.Add(this.panelAdmin);
            this.panelAfterLogin.Controls.Add(this.labelGuest);
            this.panelAfterLogin.Controls.Add(this.labelPermis);
            this.panelAfterLogin.Controls.Add(this.label5);
            this.panelAfterLogin.Location = new System.Drawing.Point(632, 0);
            this.panelAfterLogin.Name = "panelAfterLogin";
            this.panelAfterLogin.Size = new System.Drawing.Size(586, 819);
            this.panelAfterLogin.TabIndex = 35;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.customPanel7);
            this.panelAdmin.Controls.Add(this.customPanel6);
            this.panelAdmin.Controls.Add(this.customPanel5);
            this.panelAdmin.Controls.Add(this.label11);
            this.panelAdmin.Controls.Add(this.pictureBox6);
            this.panelAdmin.Controls.Add(this.customPanel4);
            this.panelAdmin.Controls.Add(this.textBoxPermissionAfter);
            this.panelAdmin.Controls.Add(this.label10);
            this.panelAdmin.Controls.Add(this.pictureBox5);
            this.panelAdmin.Controls.Add(this.customPanel3);
            this.panelAdmin.Controls.Add(this.textBoxPasswordAfter);
            this.panelAdmin.Controls.Add(this.labelAdmin);
            this.panelAdmin.Controls.Add(this.UsernameAfterUnderline);
            this.panelAdmin.Controls.Add(this.textBoxUsernameAfter);
            this.panelAdmin.Controls.Add(this.pictureBoxUsernameAfter);
            this.panelAdmin.Controls.Add(this.labelNotice);
            this.panelAdmin.Controls.Add(this.label6);
            this.panelAdmin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAdmin.Location = new System.Drawing.Point(0, 106);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(586, 713);
            this.panelAdmin.TabIndex = 44;
            // 
            // customPanel7
            // 
            this.customPanel7.Angle = 0F;
            this.customPanel7.BackColor = System.Drawing.Color.Transparent;
            this.customPanel7.BorderRadius = 30;
            this.customPanel7.Controls.Add(this.btnAdd);
            this.customPanel7.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.customPanel7.ForeColor = System.Drawing.Color.White;
            this.customPanel7.HoverColor = System.Drawing.Color.Empty;
            this.customPanel7.Location = new System.Drawing.Point(28, 537);
            this.customPanel7.Name = "customPanel7";
            this.customPanel7.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.customPanel7.Size = new System.Drawing.Size(139, 71);
            this.customPanel7.TabIndex = 53;
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(139, 71);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // customPanel6
            // 
            this.customPanel6.Angle = 0F;
            this.customPanel6.BackColor = System.Drawing.Color.Transparent;
            this.customPanel6.BorderRadius = 30;
            this.customPanel6.Controls.Add(this.btnUpdate);
            this.customPanel6.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.customPanel6.ForeColor = System.Drawing.Color.White;
            this.customPanel6.HoverColor = System.Drawing.Color.Empty;
            this.customPanel6.Location = new System.Drawing.Point(385, 537);
            this.customPanel6.Name = "customPanel6";
            this.customPanel6.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.customPanel6.Size = new System.Drawing.Size(139, 71);
            this.customPanel6.TabIndex = 53;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 71);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // customPanel5
            // 
            this.customPanel5.Angle = 0F;
            this.customPanel5.BackColor = System.Drawing.Color.Transparent;
            this.customPanel5.BorderRadius = 30;
            this.customPanel5.Controls.Add(this.btnDelete);
            this.customPanel5.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.customPanel5.ForeColor = System.Drawing.Color.White;
            this.customPanel5.HoverColor = System.Drawing.Color.Empty;
            this.customPanel5.Location = new System.Drawing.Point(204, 537);
            this.customPanel5.Name = "customPanel5";
            this.customPanel5.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.customPanel5.Size = new System.Drawing.Size(139, 71);
            this.customPanel5.TabIndex = 52;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Lexend", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 71);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lexend SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label11.Location = new System.Drawing.Point(129, 378);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 29);
            this.label11.TabIndex = 51;
            this.label11.Text = "QUYỀN";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::FileGuide.Properties.Resources.Icon_Permission;
            this.pictureBox6.Location = new System.Drawing.Point(133, 419);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 50;
            this.pictureBox6.TabStop = false;
            // 
            // customPanel4
            // 
            this.customPanel4.Angle = 0F;
            this.customPanel4.BackColor = System.Drawing.Color.Transparent;
            this.customPanel4.BorderRadius = 0;
            this.customPanel4.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.customPanel4.ForeColor = System.Drawing.Color.White;
            this.customPanel4.HoverColor = System.Drawing.Color.Empty;
            this.customPanel4.Location = new System.Drawing.Point(134, 460);
            this.customPanel4.Name = "customPanel4";
            this.customPanel4.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.customPanel4.Size = new System.Drawing.Size(303, 4);
            this.customPanel4.TabIndex = 49;
            // 
            // textBoxPermissionAfter
            // 
            this.textBoxPermissionAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPermissionAfter.Font = new System.Drawing.Font("Questrial", 11F);
            this.textBoxPermissionAfter.ForeColor = System.Drawing.Color.Black;
            this.textBoxPermissionAfter.Location = new System.Drawing.Point(185, 420);
            this.textBoxPermissionAfter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPermissionAfter.Multiline = true;
            this.textBoxPermissionAfter.Name = "textBoxPermissionAfter";
            this.textBoxPermissionAfter.Size = new System.Drawing.Size(249, 47);
            this.textBoxPermissionAfter.TabIndex = 48;
            this.textBoxPermissionAfter.UseSystemPasswordChar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lexend SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label10.Location = new System.Drawing.Point(128, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 29);
            this.label10.TabIndex = 47;
            this.label10.Text = "MẬT KHẨU";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::FileGuide.Properties.Resources.Icon_Password;
            this.pictureBox5.Location = new System.Drawing.Point(133, 298);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 46;
            this.pictureBox5.TabStop = false;
            // 
            // customPanel3
            // 
            this.customPanel3.Angle = 0F;
            this.customPanel3.BackColor = System.Drawing.Color.Transparent;
            this.customPanel3.BorderRadius = 0;
            this.customPanel3.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.customPanel3.ForeColor = System.Drawing.Color.White;
            this.customPanel3.HoverColor = System.Drawing.Color.Empty;
            this.customPanel3.Location = new System.Drawing.Point(134, 341);
            this.customPanel3.Name = "customPanel3";
            this.customPanel3.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.customPanel3.Size = new System.Drawing.Size(303, 4);
            this.customPanel3.TabIndex = 45;
            // 
            // textBoxPasswordAfter
            // 
            this.textBoxPasswordAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPasswordAfter.Font = new System.Drawing.Font("Questrial", 11F);
            this.textBoxPasswordAfter.ForeColor = System.Drawing.Color.Black;
            this.textBoxPasswordAfter.Location = new System.Drawing.Point(185, 301);
            this.textBoxPasswordAfter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPasswordAfter.Multiline = true;
            this.textBoxPasswordAfter.Name = "textBoxPasswordAfter";
            this.textBoxPasswordAfter.PasswordChar = '*';
            this.textBoxPasswordAfter.Size = new System.Drawing.Size(249, 47);
            this.textBoxPasswordAfter.TabIndex = 44;
            // 
            // labelAdmin
            // 
            this.labelAdmin.Font = new System.Drawing.Font("Questrial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdmin.Location = new System.Drawing.Point(125, 17);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(320, 126);
            this.labelAdmin.TabIndex = 12;
            this.labelAdmin.Text = "Admin có thể \r\nthêm, xóa, sửa TK";
            this.labelAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UsernameAfterUnderline
            // 
            this.UsernameAfterUnderline.Angle = 0F;
            this.UsernameAfterUnderline.BackColor = System.Drawing.Color.Transparent;
            this.UsernameAfterUnderline.BorderRadius = 0;
            this.UsernameAfterUnderline.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.UsernameAfterUnderline.ForeColor = System.Drawing.Color.White;
            this.UsernameAfterUnderline.HoverColor = System.Drawing.Color.Empty;
            this.UsernameAfterUnderline.Location = new System.Drawing.Point(134, 226);
            this.UsernameAfterUnderline.Name = "UsernameAfterUnderline";
            this.UsernameAfterUnderline.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.UsernameAfterUnderline.Size = new System.Drawing.Size(303, 4);
            this.UsernameAfterUnderline.TabIndex = 41;
            // 
            // textBoxUsernameAfter
            // 
            this.textBoxUsernameAfter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsernameAfter.Font = new System.Drawing.Font("Questrial", 11F);
            this.textBoxUsernameAfter.ForeColor = System.Drawing.Color.Black;
            this.textBoxUsernameAfter.Location = new System.Drawing.Point(190, 186);
            this.textBoxUsernameAfter.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsernameAfter.Multiline = true;
            this.textBoxUsernameAfter.Name = "textBoxUsernameAfter";
            this.textBoxUsernameAfter.Size = new System.Drawing.Size(249, 47);
            this.textBoxUsernameAfter.TabIndex = 40;
            // 
            // pictureBoxUsernameAfter
            // 
            this.pictureBoxUsernameAfter.Image = global::FileGuide.Properties.Resources.Icon_Username;
            this.pictureBoxUsernameAfter.Location = new System.Drawing.Point(133, 184);
            this.pictureBoxUsernameAfter.Name = "pictureBoxUsernameAfter";
            this.pictureBoxUsernameAfter.Size = new System.Drawing.Size(35, 35);
            this.pictureBoxUsernameAfter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxUsernameAfter.TabIndex = 42;
            this.pictureBoxUsernameAfter.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lexend SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label6.Location = new System.Drawing.Point(129, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 29);
            this.label6.TabIndex = 43;
            this.label6.Text = "TÀI KHOẢN";
            // 
            // labelGuest
            // 
            this.labelGuest.Font = new System.Drawing.Font("Questrial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuest.Location = new System.Drawing.Point(115, 174);
            this.labelGuest.Name = "labelGuest";
            this.labelGuest.Size = new System.Drawing.Size(371, 233);
            this.labelGuest.TabIndex = 13;
            this.labelGuest.Text = "Guest chỉ được sử dụng ứng dụng, không được quản lý TK";
            this.labelGuest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPermis
            // 
            this.labelPermis.Font = new System.Drawing.Font("Questrial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPermis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.labelPermis.Location = new System.Drawing.Point(309, 56);
            this.labelPermis.Name = "labelPermis";
            this.labelPermis.Size = new System.Drawing.Size(143, 47);
            this.labelPermis.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Questrial", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(153, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 57);
            this.label5.TabIndex = 9;
            this.label5.Text = "Xin chào";
            // 
            // gradientPanelBackgroundGuest
            // 
            this.gradientPanelBackgroundGuest.Angle = 0F;
            this.gradientPanelBackgroundGuest.BorderRadius = 0;
            this.gradientPanelBackgroundGuest.Controls.Add(this.label4);
            this.gradientPanelBackgroundGuest.Controls.Add(this.label3);
            this.gradientPanelBackgroundGuest.Controls.Add(this.label2);
            this.gradientPanelBackgroundGuest.Controls.Add(this.label1);
            this.gradientPanelBackgroundGuest.Controls.Add(this.pictureBox2);
            this.gradientPanelBackgroundGuest.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(156)))), ((int)(((byte)(242)))));
            this.gradientPanelBackgroundGuest.HoverColor = System.Drawing.Color.Empty;
            this.gradientPanelBackgroundGuest.Location = new System.Drawing.Point(-1, 0);
            this.gradientPanelBackgroundGuest.Name = "gradientPanelBackgroundGuest";
            this.gradientPanelBackgroundGuest.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.gradientPanelBackgroundGuest.Size = new System.Drawing.Size(628, 1065);
            this.gradientPanelBackgroundGuest.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Questrial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 484);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Lớp: IT008.M11.PMCL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Questrial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = "Phạm Trương Hải Đoàn - 20520046";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Merriweather", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 138);
            this.label2.TabIndex = 2;
            this.label2.Text = "ỨNG DỤNG\r\nQUẢN LÝ TẬP TIN\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Questrial", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(85, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Đồ án môn Lập trình trực quan";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::FileGuide.Properties.Resources.Logo_FileGuide;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(230, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(137, 136);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // gradientPanelBackgroundAdmin
            // 
            this.gradientPanelBackgroundAdmin.Angle = 0F;
            this.gradientPanelBackgroundAdmin.BorderRadius = 0;
            this.gradientPanelBackgroundAdmin.Controls.Add(this.labelDSTK);
            this.gradientPanelBackgroundAdmin.Controls.Add(this.DataGridViewUserList);
            this.gradientPanelBackgroundAdmin.FirstColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(156)))), ((int)(((byte)(242)))));
            this.gradientPanelBackgroundAdmin.HoverColor = System.Drawing.Color.Empty;
            this.gradientPanelBackgroundAdmin.Location = new System.Drawing.Point(0, 0);
            this.gradientPanelBackgroundAdmin.Name = "gradientPanelBackgroundAdmin";
            this.gradientPanelBackgroundAdmin.SecondColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(204)))), ((int)(((byte)(233)))));
            this.gradientPanelBackgroundAdmin.Size = new System.Drawing.Size(628, 1065);
            this.gradientPanelBackgroundAdmin.TabIndex = 38;
            // 
            // labelDSTK
            // 
            this.labelDSTK.AutoSize = true;
            this.labelDSTK.BackColor = System.Drawing.Color.Transparent;
            this.labelDSTK.Font = new System.Drawing.Font("Questrial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDSTK.ForeColor = System.Drawing.Color.White;
            this.labelDSTK.Location = new System.Drawing.Point(161, 33);
            this.labelDSTK.Name = "labelDSTK";
            this.labelDSTK.Size = new System.Drawing.Size(278, 59);
            this.labelDSTK.TabIndex = 35;
            this.labelDSTK.Text = "Danh sách TK";
            // 
            // ManagementPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gradientPanelBackgroundGuest);
            this.Controls.Add(this.SignupPanel);
            this.Controls.Add(this.panelAfterLogin);
            this.Controls.Add(this.gradientPanelBackgroundAdmin);
            this.Name = "ManagementPage";
            this.Size = new System.Drawing.Size(1218, 816);
            this.Load += new System.EventHandler(this.SignupPage_Load);
            this.VisibleChanged += new System.EventHandler(this.SignupPage_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewUserList)).EndInit();
            this.SignupPanel.ResumeLayout(false);
            this.SignupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gradientPanelBtnLogin.ResumeLayout(false);
            this.panelAfterLogin.ResumeLayout(false);
            this.panelAdmin.ResumeLayout(false);
            this.panelAdmin.PerformLayout();
            this.customPanel7.ResumeLayout(false);
            this.customPanel6.ResumeLayout(false);
            this.customPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUsernameAfter)).EndInit();
            this.gradientPanelBackgroundGuest.ResumeLayout(false);
            this.gradientPanelBackgroundGuest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gradientPanelBackgroundAdmin.ResumeLayout(false);
            this.gradientPanelBackgroundAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.DataGridView DataGridViewUserList;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelWarning2;
        private System.Windows.Forms.Label labelWarning1;
        private System.Windows.Forms.Panel SignupPanel;
        private System.Windows.Forms.Panel panelAfterLogin;
        private System.Windows.Forms.Label labelGuest;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Label labelPermis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelNotice;
        private CustomControls.CustomPanel gradientPanelBackgroundGuest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private CustomControls.CustomPanel gradientPanelBackgroundAdmin;
        private System.Windows.Forms.Label labelDSTK;
        private CustomControls.CustomPanel gradientPanelBtnLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomControls.CustomPanel customPanel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox3;
        private CustomControls.CustomPanel gradientPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBoxUsernameAfter;
        private CustomControls.CustomPanel UsernameAfterUnderline;
        private System.Windows.Forms.TextBox textBoxUsernameAfter;
        private System.Windows.Forms.Panel panelAdmin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox5;
        private CustomControls.CustomPanel customPanel3;
        private System.Windows.Forms.TextBox textBoxPasswordAfter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox6;
        private CustomControls.CustomPanel customPanel4;
        private System.Windows.Forms.TextBox textBoxPermissionAfter;
        private CustomControls.CustomPanel customPanel7;
        private CustomControls.CustomPanel customPanel6;
        private CustomControls.CustomPanel customPanel5;
    }
}
