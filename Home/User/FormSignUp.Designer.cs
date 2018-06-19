namespace Home
{
    partial class FormSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSignUp));
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.cBoxGender = new System.Windows.Forms.ComboBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.chkBoxAgree = new System.Windows.Forms.CheckBox();
            this.pictBoxPhoto = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnPickPhoto = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.pBoxShow = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxPhoto)).BeginInit();
            this.pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxShow)).BeginInit();
            this.SuspendLayout();
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
            this.minimizeBtn.Location = new System.Drawing.Point(506, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(46, 30);
            this.minimizeBtn.TabIndex = 12;
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
            this.closeBtn.Location = new System.Drawing.Point(558, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(46, 30);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(3, 13);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(134, 27);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 67);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(125, 27);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(33, 354);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 27);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(33, 396);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(110, 27);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Address";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pBoxShow);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Location = new System.Drawing.Point(39, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 111);
            this.panel1.TabIndex = 15;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(158, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(322, 35);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(158, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(364, 35);
            this.txtUsername.TabIndex = 15;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(32, 494);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(135, 27);
            this.lblTelephone.TabIndex = 16;
            this.lblTelephone.Text = "Telephone";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(199, 346);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(363, 35);
            this.txtName.TabIndex = 17;
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Location = new System.Drawing.Point(198, 491);
            this.mtbTelephone.Mask = "+6200000000000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(364, 35);
            this.mtbTelephone.TabIndex = 18;
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(199, 396);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(363, 89);
            this.rtbAddress.TabIndex = 19;
            this.rtbAddress.Text = "";
            // 
            // cBoxGender
            // 
            this.cBoxGender.FormattingEnabled = true;
            this.cBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Neither"});
            this.cBoxGender.Location = new System.Drawing.Point(198, 547);
            this.cBoxGender.Name = "cBoxGender";
            this.cBoxGender.Size = new System.Drawing.Size(120, 34);
            this.cBoxGender.TabIndex = 20;
            this.cBoxGender.Text = "Male";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(33, 550);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(97, 27);
            this.lblGender.TabIndex = 21;
            this.lblGender.Text = "Gender";
            // 
            // chkBoxAgree
            // 
            this.chkBoxAgree.AutoSize = true;
            this.chkBoxAgree.Location = new System.Drawing.Point(57, 620);
            this.chkBoxAgree.Name = "chkBoxAgree";
            this.chkBoxAgree.Size = new System.Drawing.Size(484, 31);
            this.chkBoxAgree.TabIndex = 22;
            this.chkBoxAgree.Text = "I agree with the terms and conditions";
            this.chkBoxAgree.UseVisualStyleBackColor = true;
            // 
            // pictBoxPhoto
            // 
            this.pictBoxPhoto.BackgroundImage = global::Home.Properties.Resources.Default_Pic_box_;
            this.pictBoxPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictBoxPhoto.Location = new System.Drawing.Point(39, 169);
            this.pictBoxPhoto.Name = "pictBoxPhoto";
            this.pictBoxPhoto.Size = new System.Drawing.Size(160, 160);
            this.pictBoxPhoto.TabIndex = 23;
            this.pictBoxPhoto.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 27);
            this.label7.TabIndex = 24;
            this.label7.Text = "Profile Picture";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label8.Location = new System.Drawing.Point(3, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 51);
            this.label8.TabIndex = 25;
            this.label8.Text = "If you don\'t pick a profile picture.\r\nThen we will assign our default profile\r\npi" +
    "cture.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lucida Sans", 10F);
            this.label9.Location = new System.Drawing.Point(385, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "?";
            this.label9.MouseEnter += new System.EventHandler(this.label9_MouseEnter);
            this.label9.MouseLeave += new System.EventHandler(this.label9_MouseLeave);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.Color.LightGray;
            this.pnlInfo.Controls.Add(this.label8);
            this.pnlInfo.Location = new System.Drawing.Point(344, 197);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(260, 64);
            this.pnlInfo.TabIndex = 27;
            this.pnlInfo.Visible = false;
            // 
            // btnPickPhoto
            // 
            this.btnPickPhoto.Location = new System.Drawing.Point(220, 209);
            this.btnPickPhoto.Name = "btnPickPhoto";
            this.btnPickPhoto.Size = new System.Drawing.Size(169, 36);
            this.btnPickPhoto.TabIndex = 28;
            this.btnPickPhoto.Text = "Pick Photo";
            this.btnPickPhoto.UseVisualStyleBackColor = true;
            this.btnPickPhoto.Click += new System.EventHandler(this.btnPickPhoto_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(85, 657);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(167, 50);
            this.btnSubmit.TabIndex = 29;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(365, 657);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(167, 50);
            this.btnReturn.TabIndex = 29;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // pBoxShow
            // 
            this.pBoxShow.BackColor = System.Drawing.Color.Silver;
            this.pBoxShow.BackgroundImage = global::Home.Properties.Resources.eye_icon;
            this.pBoxShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxShow.Location = new System.Drawing.Point(486, 64);
            this.pBoxShow.Name = "pBoxShow";
            this.pBoxShow.Size = new System.Drawing.Size(36, 35);
            this.pBoxShow.TabIndex = 17;
            this.pBoxShow.TabStop = false;
            this.pBoxShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBoxShow_MouseDown);
            this.pBoxShow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pBoxShow_MouseUp);
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(616, 720);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictBoxPhoto);
            this.Controls.Add(this.chkBoxAgree);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.cBoxGender);
            this.Controls.Add(this.rtbAddress);
            this.Controls.Add(this.mtbTelephone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.btnPickPhoto);
            this.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSignUp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxPhoto)).EndInit();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.ComboBox cBoxGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.CheckBox chkBoxAgree;
        private System.Windows.Forms.PictureBox pictBoxPhoto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Button btnPickPhoto;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.PictureBox pBoxShow;
    }
}