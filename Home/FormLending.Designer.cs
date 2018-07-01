namespace Home
{
    partial class FormLending
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLending));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtLendDate = new System.Windows.Forms.TextBox();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblFineAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.LendId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomFine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomIdBuku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomLend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolomDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PrintThis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PrintAll = new System.Windows.Forms.ToolStripMenuItem();
            this.DroplocPrint = new System.Windows.Forms.Label();
            this.DroplocView = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.ViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ViewThis = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ViewAll = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.printMenu.SuspendLayout();
            this.ViewMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 99);
            this.panel1.TabIndex = 16;
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
            this.lblWelcome.Size = new System.Drawing.Size(253, 27);
            this.lblWelcome.TabIndex = 11;
            this.lblWelcome.Text = "Lending In Progress";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReturnBook);
            this.groupBox1.Controls.Add(this.txtGenre);
            this.groupBox1.Controls.Add(this.txtDeadline);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtLendDate);
            this.groupBox1.Controls.Add(this.txtBookTitle);
            this.groupBox1.Controls.Add(this.lblFineAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(19, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 217);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturnBook.Enabled = false;
            this.btnReturnBook.Location = new System.Drawing.Point(767, 163);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(203, 42);
            this.btnReturnBook.TabIndex = 6;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Enabled = false;
            this.txtGenre.Location = new System.Drawing.Point(173, 114);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(273, 35);
            this.txtGenre.TabIndex = 3;
            // 
            // txtDeadline
            // 
            this.txtDeadline.Enabled = false;
            this.txtDeadline.Location = new System.Drawing.Point(747, 75);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(223, 35);
            this.txtDeadline.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(173, 75);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(273, 35);
            this.txtAuthor.TabIndex = 2;
            // 
            // txtLendDate
            // 
            this.txtLendDate.Enabled = false;
            this.txtLendDate.Location = new System.Drawing.Point(747, 36);
            this.txtLendDate.Name = "txtLendDate";
            this.txtLendDate.Size = new System.Drawing.Size(223, 35);
            this.txtLendDate.TabIndex = 4;
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Enabled = false;
            this.txtBookTitle.Location = new System.Drawing.Point(173, 36);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(273, 35);
            this.txtBookTitle.TabIndex = 1;
            // 
            // lblFineAmount
            // 
            this.lblFineAmount.AutoSize = true;
            this.lblFineAmount.Location = new System.Drawing.Point(742, 117);
            this.lblFineAmount.Name = "lblFineAmount";
            this.lblFineAmount.Size = new System.Drawing.Size(74, 27);
            this.lblFineAmount.TabIndex = 2;
            this.lblFineAmount.Text = "Rp. 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 27);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fine";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(601, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 27);
            this.label8.TabIndex = 0;
            this.label8.Text = "Deadline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Genre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(601, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 27);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lend Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "Book Title";
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LendId,
            this.kolomUsername,
            this.kolomFine,
            this.kolomIdBuku,
            this.kolomLend,
            this.kolomDue});
            this.dgvBooks.Location = new System.Drawing.Point(17, 341);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(995, 367);
            this.dgvBooks.TabIndex = 24;
            this.dgvBooks.TabStop = false;
            this.dgvBooks.SelectionChanged += new System.EventHandler(this.dgvBooks_SelectionChanged);
            // 
            // LendId
            // 
            this.LendId.HeaderText = "LendId";
            this.LendId.Name = "LendId";
            this.LendId.ReadOnly = true;
            this.LendId.Visible = false;
            // 
            // kolomUsername
            // 
            this.kolomUsername.HeaderText = "username";
            this.kolomUsername.Name = "kolomUsername";
            this.kolomUsername.ReadOnly = true;
            this.kolomUsername.Visible = false;
            this.kolomUsername.Width = 300;
            // 
            // kolomFine
            // 
            this.kolomFine.HeaderText = "Fine";
            this.kolomFine.Name = "kolomFine";
            this.kolomFine.ReadOnly = true;
            this.kolomFine.Visible = false;
            // 
            // kolomIdBuku
            // 
            this.kolomIdBuku.HeaderText = "Book Id";
            this.kolomIdBuku.Name = "kolomIdBuku";
            this.kolomIdBuku.ReadOnly = true;
            this.kolomIdBuku.Width = 300;
            // 
            // kolomLend
            // 
            this.kolomLend.HeaderText = "Lend Date";
            this.kolomLend.Name = "kolomLend";
            this.kolomLend.ReadOnly = true;
            this.kolomLend.Width = 300;
            // 
            // kolomDue
            // 
            this.kolomDue.HeaderText = "Due Date";
            this.kolomDue.Name = "kolomDue";
            this.kolomDue.ReadOnly = true;
            this.kolomDue.Width = 300;
            // 
            // printMenu
            // 
            this.printMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.printMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintThis,
            this.toolStripSeparator2,
            this.PrintAll});
            this.printMenu.Name = "menuManage";
            this.printMenu.Size = new System.Drawing.Size(241, 58);
            // 
            // PrintThis
            // 
            this.PrintThis.Name = "PrintThis";
            this.PrintThis.Size = new System.Drawing.Size(240, 24);
            this.PrintThis.Text = "Print this user\'s lend only";
            this.PrintThis.Click += new System.EventHandler(this.PrintThis_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(237, 6);
            // 
            // PrintAll
            // 
            this.PrintAll.Name = "PrintAll";
            this.PrintAll.Size = new System.Drawing.Size(240, 24);
            this.PrintAll.Text = "Print all lends";
            this.PrintAll.Click += new System.EventHandler(this.PrintAll_Click);
            // 
            // DroplocPrint
            // 
            this.DroplocPrint.AutoSize = true;
            this.DroplocPrint.Location = new System.Drawing.Point(591, 107);
            this.DroplocPrint.Name = "DroplocPrint";
            this.DroplocPrint.Size = new System.Drawing.Size(162, 27);
            this.DroplocPrint.TabIndex = 26;
            this.DroplocPrint.Text = "LokasiDrop1";
            this.DroplocPrint.Visible = false;
            // 
            // DroplocView
            // 
            this.DroplocView.AutoSize = true;
            this.DroplocView.Location = new System.Drawing.Point(423, 107);
            this.DroplocView.Name = "DroplocView";
            this.DroplocView.Size = new System.Drawing.Size(162, 27);
            this.DroplocView.TabIndex = 26;
            this.DroplocView.Text = "LokasiDrop2";
            this.DroplocView.Visible = false;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Home.Properties.Resources.btnView;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(418, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 60);
            this.button2.TabIndex = 6;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Home.Properties.Resources.Print_Btn;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(586, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 60);
            this.button1.TabIndex = 6;
            this.button1.TabStop = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackgroundImage = global::Home.Properties.Resources.iconReturn;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Location = new System.Drawing.Point(862, 48);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 60);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.TabStop = false;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
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
            this.minimizeBtn.Location = new System.Drawing.Point(914, 12);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(46, 30);
            this.minimizeBtn.TabIndex = 12;
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
            this.closeBtn.Location = new System.Drawing.Point(966, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(46, 30);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.TabStop = false;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // ViewMenu
            // 
            this.ViewMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ViewThis,
            this.toolStripSeparator1,
            this.ViewAll});
            this.ViewMenu.Name = "menuManage";
            this.ViewMenu.Size = new System.Drawing.Size(203, 58);
            this.ViewMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ViewMenu_Opening);
            // 
            // ViewThis
            // 
            this.ViewThis.Name = "ViewThis";
            this.ViewThis.Size = new System.Drawing.Size(202, 24);
            this.ViewThis.Text = "View this user Only";
            this.ViewThis.Click += new System.EventHandler(this.ViewThis_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // ViewAll
            // 
            this.ViewAll.Name = "ViewAll";
            this.ViewAll.Size = new System.Drawing.Size(202, 24);
            this.ViewAll.Text = "View all Lends";
            this.ViewAll.Click += new System.EventHandler(this.ViewAll_Click);
            // 
            // FormLending
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.DroplocView);
            this.Controls.Add(this.DroplocPrint);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormLending";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLending";
            this.Load += new System.EventHandler(this.FormLending_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.printMenu.ResumeLayout(false);
            this.ViewMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtDeadline;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtLendDate;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblFineAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn LendId;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomFine;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomIdBuku;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomLend;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolomDue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip printMenu;
        private System.Windows.Forms.ToolStripMenuItem PrintThis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem PrintAll;
        private System.Windows.Forms.Label DroplocPrint;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label DroplocView;
        private System.Windows.Forms.ContextMenuStrip ViewMenu;
        private System.Windows.Forms.ToolStripMenuItem ViewThis;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ViewAll;
    }
}