namespace SecurityDescriptorConverter
{
    partial class frmMain
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
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.lblDest = new System.Windows.Forms.Label();
            this.btnBinSd2StrSd = new System.Windows.Forms.Button();
            this.btnStrSd2BinSd = new System.Windows.Forms.Button();
            this.btnStrSid2BinSid = new System.Windows.Forms.Button();
            this.btnBinSid2StrSid = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 9);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(62, 13);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "To convert:";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(15, 25);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(574, 138);
            this.txtSource.TabIndex = 1;
            // 
            // txtDest
            // 
            this.txtDest.BackColor = System.Drawing.SystemColors.Window;
            this.txtDest.Location = new System.Drawing.Point(15, 194);
            this.txtDest.Multiline = true;
            this.txtDest.Name = "txtDest";
            this.txtDest.ReadOnly = true;
            this.txtDest.Size = new System.Drawing.Size(574, 138);
            this.txtDest.TabIndex = 3;
            // 
            // lblDest
            // 
            this.lblDest.AutoSize = true;
            this.lblDest.Location = new System.Drawing.Point(12, 178);
            this.lblDest.Name = "lblDest";
            this.lblDest.Size = new System.Drawing.Size(59, 13);
            this.lblDest.TabIndex = 2;
            this.lblDest.Text = "Converted:";
            // 
            // btnBinSd2StrSd
            // 
            this.btnBinSd2StrSd.Location = new System.Drawing.Point(15, 353);
            this.btnBinSd2StrSd.Name = "btnBinSd2StrSd";
            this.btnBinSd2StrSd.Size = new System.Drawing.Size(139, 35);
            this.btnBinSd2StrSd.TabIndex = 4;
            this.btnBinSd2StrSd.Text = "Binary SD to String SD";
            this.btnBinSd2StrSd.UseVisualStyleBackColor = true;
            this.btnBinSd2StrSd.Click += new System.EventHandler(this.btnBinSd2StrSd_Click);
            // 
            // btnStrSd2BinSd
            // 
            this.btnStrSd2BinSd.Location = new System.Drawing.Point(160, 353);
            this.btnStrSd2BinSd.Name = "btnStrSd2BinSd";
            this.btnStrSd2BinSd.Size = new System.Drawing.Size(139, 35);
            this.btnStrSd2BinSd.TabIndex = 5;
            this.btnStrSd2BinSd.Text = "String SD to Binary SD";
            this.btnStrSd2BinSd.UseVisualStyleBackColor = true;
            this.btnStrSd2BinSd.Click += new System.EventHandler(this.btnStrSd2BinSd_Click);
            // 
            // btnStrSid2BinSid
            // 
            this.btnStrSid2BinSid.Location = new System.Drawing.Point(450, 353);
            this.btnStrSid2BinSid.Name = "btnStrSid2BinSid";
            this.btnStrSid2BinSid.Size = new System.Drawing.Size(139, 35);
            this.btnStrSid2BinSid.TabIndex = 7;
            this.btnStrSid2BinSid.Text = "String Sid to Binary Sid";
            this.btnStrSid2BinSid.UseVisualStyleBackColor = true;
            this.btnStrSid2BinSid.Click += new System.EventHandler(this.btnStrSid2BinSid_Click);
            // 
            // btnBinSid2StrSid
            // 
            this.btnBinSid2StrSid.Location = new System.Drawing.Point(305, 353);
            this.btnBinSid2StrSid.Name = "btnBinSid2StrSid";
            this.btnBinSid2StrSid.Size = new System.Drawing.Size(139, 35);
            this.btnBinSid2StrSid.TabIndex = 6;
            this.btnBinSid2StrSid.Text = "Binary Sid to String Sid";
            this.btnBinSid2StrSid.UseVisualStyleBackColor = true;
            this.btnBinSid2StrSid.Click += new System.EventHandler(this.btnBinSid2StrSid_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(495, 404);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(94, 23);
            this.btnQuit.TabIndex = 8;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 442);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnStrSid2BinSid);
            this.Controls.Add(this.btnBinSid2StrSid);
            this.Controls.Add(this.btnStrSd2BinSd);
            this.Controls.Add(this.btnBinSd2StrSd);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.lblDest);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Security Descriptor Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Label lblDest;
        private System.Windows.Forms.Button btnBinSd2StrSd;
        private System.Windows.Forms.Button btnStrSd2BinSd;
        private System.Windows.Forms.Button btnStrSid2BinSid;
        private System.Windows.Forms.Button btnBinSid2StrSid;
        private System.Windows.Forms.Button btnQuit;
    }
}

