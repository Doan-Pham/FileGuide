
namespace FileGuide
{
    partial class FormLogin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.InfoButton = new System.Windows.Forms.Button();
            this.SignupButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.signupPage1 = new FileGuide.SignupPage();
            this.loginPage1 = new FileGuide.LoginPage();
            this.infoPage1 = new FileGuide.InfoPage();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.sidePanel);
            this.panelMenu.Controls.Add(this.InfoButton);
            this.panelMenu.Controls.Add(this.SignupButton);
            this.panelMenu.Controls.Add(this.LoginButton);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMenu.Location = new System.Drawing.Point(1196, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(282, 760);
            this.panelMenu.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::FileGuide.Properties.Resources.Icon_Info;
            this.pictureBox3.Location = new System.Drawing.Point(0, 358);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(74, 78);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Image = global::FileGuide.Properties.Resources.Icon_UserGroup;
            this.pictureBox2.Location = new System.Drawing.Point(11, 256);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::FileGuide.Properties.Resources.Icon_User;
            this.pictureBox1.Location = new System.Drawing.Point(11, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(149)))), ((int)(((byte)(242)))));
            this.sidePanel.Location = new System.Drawing.Point(247, 134);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(21, 78);
            this.sidePanel.TabIndex = 1;
            // 
            // InfoButton
            // 
            this.InfoButton.FlatAppearance.BorderSize = 0;
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Font = new System.Drawing.Font("Questrial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.ForeColor = System.Drawing.Color.White;
            this.InfoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoButton.Location = new System.Drawing.Point(80, 358);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.InfoButton.Size = new System.Drawing.Size(188, 78);
            this.InfoButton.TabIndex = 3;
            this.InfoButton.Text = "  Giới thiệu";
            this.InfoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InfoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // SignupButton
            // 
            this.SignupButton.FlatAppearance.BorderSize = 0;
            this.SignupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignupButton.Font = new System.Drawing.Font("Questrial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupButton.ForeColor = System.Drawing.Color.White;
            this.SignupButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignupButton.Location = new System.Drawing.Point(80, 246);
            this.SignupButton.Name = "SignupButton";
            this.SignupButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SignupButton.Size = new System.Drawing.Size(188, 78);
            this.SignupButton.TabIndex = 2;
            this.SignupButton.Text = "Quản lý";
            this.SignupButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SignupButton.UseVisualStyleBackColor = true;
            this.SignupButton.Click += new System.EventHandler(this.SignupButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Questrial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(80, 137);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LoginButton.Size = new System.Drawing.Size(188, 78);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Đăng nhập";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.Controls.Add(this.infoPage1);
            this.PanelMain.Controls.Add(this.signupPage1);
            this.PanelMain.Controls.Add(this.loginPage1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1204, 760);
            this.PanelMain.TabIndex = 0;
            // 
            // signupPage1
            // 
            this.signupPage1.BackColor = System.Drawing.Color.White;
            this.signupPage1.Location = new System.Drawing.Point(0, 0);
            this.signupPage1.Name = "signupPage1";
            this.signupPage1.Size = new System.Drawing.Size(1190, 774);
            this.signupPage1.TabIndex = 4;
            // 
            // loginPage1
            // 
            this.loginPage1.AutoSize = true;
            this.loginPage1.BackColor = System.Drawing.Color.White;
            this.loginPage1.Location = new System.Drawing.Point(-3, 0);
            this.loginPage1.Name = "loginPage1";
            this.loginPage1.Size = new System.Drawing.Size(1218, 1068);
            this.loginPage1.TabIndex = 3;
            // 
            // infoPage1
            // 
            this.infoPage1.BackColor = System.Drawing.Color.White;
            this.infoPage1.Location = new System.Drawing.Point(-5, 0);
            this.infoPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.infoPage1.Name = "infoPage1";
            this.infoPage1.Size = new System.Drawing.Size(1220, 760);
            this.infoPage1.TabIndex = 0;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1478, 760);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.PanelMain);
            this.Font = new System.Drawing.Font("Questrial", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SignupButton;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel PanelMain;
        private InfoPage infoPage1;
        private LoginPage loginPage1;
        private SignupPage signupPage1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}