namespace Home
{
    partial class DialogNormal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogNormal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNotice = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblNotice);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 39);
            this.panel1.TabIndex = 14;
            // 
            // lblNotice
            // 
            this.lblNotice.AutoSize = true;
            this.lblNotice.Location = new System.Drawing.Point(181, 6);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(84, 27);
            this.lblNotice.TabIndex = 14;
            this.lblNotice.Text = "label1";
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Image = ((System.Drawing.Image)(resources.GetObject("closeBtn.Image")));
            this.closeBtn.Location = new System.Drawing.Point(394, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(46, 30);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(71, 33);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(312, 54);
            this.lblText.TabIndex = 15;
            this.lblText.Text = "You have unpaid Fine\r\nPlease pay your fine first!";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(173, 112);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 37);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.lblText);
            this.panel2.Location = new System.Drawing.Point(1, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 161);
            this.panel2.TabIndex = 17;
            // 
            // DialogNormal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(450, 200);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Lucida Sans", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DialogNormal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DialogNormal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panel2;
    }
}