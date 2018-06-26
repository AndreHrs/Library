namespace Home
{
    partial class formMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.panelSupport = new System.Windows.Forms.Panel();
            this.panelHotlist = new System.Windows.Forms.Panel();
            this.manageDropdownLocation = new System.Windows.Forms.Panel();
            this.menuManage = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.manageBook = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.manageAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLend = new System.Windows.Forms.Button();
            this.btnBooks = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBoxProfile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 99);
            this.panel1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 46);
            this.label2.TabIndex = 12;
            this.label2.Text = "E-Library";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(110, 63);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(161, 29);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Welcome Guest";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblAccountName);
            this.panel2.Controls.Add(this.pBoxProfile);
            this.panel2.Location = new System.Drawing.Point(880, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(146, 182);
            this.panel2.TabIndex = 13;
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(3, 149);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(69, 29);
            this.lblAccountName.TabIndex = 11;
            this.lblAccountName.Text = "Guest";
            // 
            // panelSupport
            // 
            this.panelSupport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSupport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSupport.Location = new System.Drawing.Point(12, 131);
            this.panelSupport.Name = "panelSupport";
            this.panelSupport.Size = new System.Drawing.Size(840, 232);
            this.panelSupport.TabIndex = 14;
            // 
            // panelHotlist
            // 
            this.panelHotlist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHotlist.Location = new System.Drawing.Point(12, 385);
            this.panelHotlist.Name = "panelHotlist";
            this.panelHotlist.Size = new System.Drawing.Size(1014, 276);
            this.panelHotlist.TabIndex = 14;
            // 
            // manageDropdownLocation
            // 
            this.manageDropdownLocation.Location = new System.Drawing.Point(803, 62);
            this.manageDropdownLocation.Name = "manageDropdownLocation";
            this.manageDropdownLocation.Size = new System.Drawing.Size(119, 17);
            this.manageDropdownLocation.TabIndex = 16;
            // 
            // menuManage
            // 
            this.menuManage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuManage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageBook,
            this.toolStripSeparator2,
            this.manageAccount});
            this.menuManage.Name = "menuManage";
            this.menuManage.Size = new System.Drawing.Size(133, 58);
            // 
            // manageBook
            // 
            this.manageBook.Name = "manageBook";
            this.manageBook.Size = new System.Drawing.Size(132, 24);
            this.manageBook.Text = "Books";
            this.manageBook.Click += new System.EventHandler(this.manageBook_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(129, 6);
            // 
            // manageAccount
            // 
            this.manageAccount.Name = "manageAccount";
            this.manageAccount.Size = new System.Drawing.Size(132, 24);
            this.manageAccount.Text = "Account";
            this.manageAccount.Click += new System.EventHandler(this.manageAccount_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackgroundImage = global::Home.Properties.Resources.manage;
            this.btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnManage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Location = new System.Drawing.Point(803, 12);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(120, 50);
            this.btnManage.TabIndex = 5;
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Visible = false;
            this.btnManage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnManage_MouseClick);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::Home.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(677, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 50);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackgroundImage = global::Home.Properties.Resources.profileDisabled;
            this.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProfile.Enabled = false;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Location = new System.Drawing.Point(551, 12);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(120, 50);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.UseVisualStyleBackColor = true;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnLend
            // 
            this.btnLend.BackgroundImage = global::Home.Properties.Resources.lendDisabled;
            this.btnLend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLend.Enabled = false;
            this.btnLend.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLend.FlatAppearance.BorderSize = 0;
            this.btnLend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnLend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLend.Location = new System.Drawing.Point(425, 12);
            this.btnLend.Name = "btnLend";
            this.btnLend.Size = new System.Drawing.Size(120, 50);
            this.btnLend.TabIndex = 2;
            this.btnLend.UseVisualStyleBackColor = true;
            this.btnLend.Click += new System.EventHandler(this.btnLend_Click);
            // 
            // btnBooks
            // 
            this.btnBooks.BackgroundImage = global::Home.Properties.Resources.books;
            this.btnBooks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBooks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBooks.FlatAppearance.BorderSize = 0;
            this.btnBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBooks.Location = new System.Drawing.Point(299, 12);
            this.btnBooks.Name = "btnBooks";
            this.btnBooks.Size = new System.Drawing.Size(120, 50);
            this.btnBooks.TabIndex = 1;
            this.btnBooks.UseVisualStyleBackColor = true;
            this.btnBooks.Click += new System.EventHandler(this.btnBooks_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.minimizeBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Image = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.Image")));
            this.minimizeBtn.Location = new System.Drawing.Point(946, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(46, 30);
            this.minimizeBtn.TabIndex = 7;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimizeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(1004, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(46, 30);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.TabStop = false;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Home.Properties.Resources.Library;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pBoxProfile
            // 
            this.pBoxProfile.BackgroundImage = global::Home.Properties.Resources.Default_Pic_box_;
            this.pBoxProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pBoxProfile.Location = new System.Drawing.Point(0, 0);
            this.pBoxProfile.Name = "pBoxProfile";
            this.pBoxProfile.Size = new System.Drawing.Size(146, 146);
            this.pBoxProfile.TabIndex = 12;
            this.pBoxProfile.TabStop = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.btnManage);
            this.Controls.Add(this.manageDropdownLocation);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.btnLend);
            this.Controls.Add(this.btnBooks);
            this.Controls.Add(this.panelHotlist);
            this.Controls.Add(this.panelSupport);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pBoxProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.Panel panelSupport;
        private System.Windows.Forms.Button btnBooks;
        private System.Windows.Forms.Panel panelHotlist;
        private System.Windows.Forms.Button btnLend;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel manageDropdownLocation;
        private System.Windows.Forms.ContextMenuStrip menuManage;
        private System.Windows.Forms.ToolStripMenuItem manageBook;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem manageAccount;
        private System.Windows.Forms.Button btnManage;
    }
}

