namespace Clinic2018
{
    partial class clinic_main_v2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clinic_main_v2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barcordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.amphuresTableAdapter1 = new Clinic2018.DataSet1TableAdapters.amphuresTableAdapter();
            this.L_name = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.B_login = new Bunifu.Framework.UI.BunifuThinButton2();
            this.T_Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.T_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.P_password = new System.Windows.Forms.PictureBox();
            this.P_username = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.medical_historyTableAdapter1 = new Clinic2018.DataSet1TableAdapters.medical_historyTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_username)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.barcordToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.fileToolStripMenuItem.Text = "ตรวจสอบสิทธิ์";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // barcordToolStripMenuItem
            // 
            this.barcordToolStripMenuItem.Name = "barcordToolStripMenuItem";
            this.barcordToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.barcordToolStripMenuItem.Text = "เกี่ยวกับ";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 546);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1078, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(32, 546);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Visible = false;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Clinic2018.Properties.Resources.ic_user1;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton1.Text = "ส่งเข้าตรวจ";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(21, 20);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // amphuresTableAdapter1
            // 
            this.amphuresTableAdapter1.ClearBeforeFill = true;
            // 
            // L_name
            // 
            this.L_name.AutoSize = true;
            this.L_name.Location = new System.Drawing.Point(969, 9);
            this.L_name.Name = "L_name";
            this.L_name.Size = new System.Drawing.Size(97, 13);
            this.L_name.TabIndex = 8;
            this.L_name.Text = "แสดงชื่อเมื่อล็อคอิน";
            this.L_name.Visible = false;
            this.L_name.Click += new System.EventHandler(this.L_name_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.B_login);
            this.groupBox1.Controls.Add(this.T_Username);
            this.groupBox1.Controls.Add(this.T_Password);
            this.groupBox1.Controls.Add(this.P_password);
            this.groupBox1.Controls.Add(this.P_username);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(21, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เข้าสู้ระบบ";
            // 
            // B_login
            // 
            this.B_login.ActiveBorderThickness = 1;
            this.B_login.ActiveCornerRadius = 20;
            this.B_login.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.B_login.ActiveForecolor = System.Drawing.Color.White;
            this.B_login.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.B_login.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.B_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_login.BackgroundImage")));
            this.B_login.ButtonText = "login";
            this.B_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.B_login.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_login.ForeColor = System.Drawing.Color.SeaGreen;
            this.B_login.IdleBorderThickness = 1;
            this.B_login.IdleCornerRadius = 20;
            this.B_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(210)))), ((int)(((byte)(66)))));
            this.B_login.IdleForecolor = System.Drawing.Color.White;
            this.B_login.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(210)))), ((int)(((byte)(66)))));
            this.B_login.Location = new System.Drawing.Point(188, 164);
            this.B_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.B_login.Name = "B_login";
            this.B_login.Size = new System.Drawing.Size(87, 41);
            this.B_login.TabIndex = 11;
            this.B_login.Tag = "111";
            this.B_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.B_login.Click += new System.EventHandler(this.B_login_Click);
            // 
            // T_Username
            // 
            this.T_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.T_Username.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.T_Username.ForeColor = System.Drawing.Color.White;
            this.T_Username.HintForeColor = System.Drawing.Color.Empty;
            this.T_Username.HintText = "";
            this.T_Username.isPassword = false;
            this.T_Username.LineFocusedColor = System.Drawing.Color.White;
            this.T_Username.LineIdleColor = System.Drawing.Color.White;
            this.T_Username.LineMouseHoverColor = System.Drawing.Color.White;
            this.T_Username.LineThickness = 3;
            this.T_Username.Location = new System.Drawing.Point(110, 46);
            this.T_Username.Margin = new System.Windows.Forms.Padding(4);
            this.T_Username.Name = "T_Username";
            this.T_Username.Size = new System.Drawing.Size(229, 33);
            this.T_Username.TabIndex = 9;
            this.T_Username.Text = "Username";
            this.T_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // T_Password
            // 
            this.T_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.T_Password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.T_Password.ForeColor = System.Drawing.Color.White;
            this.T_Password.HintForeColor = System.Drawing.Color.Empty;
            this.T_Password.HintText = "";
            this.T_Password.isPassword = true;
            this.T_Password.LineFocusedColor = System.Drawing.Color.White;
            this.T_Password.LineIdleColor = System.Drawing.Color.White;
            this.T_Password.LineMouseHoverColor = System.Drawing.Color.White;
            this.T_Password.LineThickness = 3;
            this.T_Password.Location = new System.Drawing.Point(110, 109);
            this.T_Password.Margin = new System.Windows.Forms.Padding(4);
            this.T_Password.Name = "T_Password";
            this.T_Password.Size = new System.Drawing.Size(229, 33);
            this.T_Password.TabIndex = 10;
            this.T_Password.Text = "Password";
            this.T_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // P_password
            // 
            this.P_password.Image = ((System.Drawing.Image)(resources.GetObject("P_password.Image")));
            this.P_password.Location = new System.Drawing.Point(74, 112);
            this.P_password.Name = "P_password";
            this.P_password.Size = new System.Drawing.Size(29, 30);
            this.P_password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_password.TabIndex = 7;
            this.P_password.TabStop = false;
            // 
            // P_username
            // 
            this.P_username.Image = global::Clinic2018.Properties.Resources.ic_user;
            this.P_username.Location = new System.Drawing.Point(74, 49);
            this.P_username.Name = "P_username";
            this.P_username.Size = new System.Drawing.Size(29, 30);
            this.P_username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_username.TabIndex = 8;
            this.P_username.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(489, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 330);
            this.panel1.TabIndex = 6;
            // 
            // medical_historyTableAdapter1
            // 
            this.medical_historyTableAdapter1.ClearBeforeFill = true;
            // 
            // clinic_main_v2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 568);
            this.Controls.Add(this.L_name);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "clinic_main_v2";
            this.Text = "Medical and Health Care Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.clinic_main_v2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.P_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P_username)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barcordToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private DataSet1TableAdapters.amphuresTableAdapter amphuresTableAdapter1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label L_name;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 B_login;
        private Bunifu.Framework.UI.BunifuMaterialTextbox T_Username;
        private Bunifu.Framework.UI.BunifuMaterialTextbox T_Password;
        private System.Windows.Forms.PictureBox P_password;
        private System.Windows.Forms.PictureBox P_username;
        private System.Windows.Forms.Panel panel1;
        private DataSet1TableAdapters.medical_historyTableAdapter medical_historyTableAdapter1;
    }
}