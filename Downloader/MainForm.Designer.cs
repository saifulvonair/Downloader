namespace Downloader
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblval1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDownloadLoc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl2 = new System.Windows.Forms.TextBox();
            this.lblval2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrl3 = new System.Windows.Forms.TextBox();
            this.lblval3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblval1
            // 
            this.lblval1.AutoSize = true;
            this.lblval1.Location = new System.Drawing.Point(493, 65);
            this.lblval1.Name = "lblval1";
            this.lblval1.Size = new System.Drawing.Size(48, 13);
            this.lblval1.TabIndex = 2;
            this.lblval1.Text = "Progress";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(23, 60);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(465, 20);
            this.txtUrl.TabIndex = 3;
            this.txtUrl.Text = "https://tools.learningcontainer.com/sample-json.json";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "URL:";
            // 
            // lblDownloadLoc
            // 
            this.lblDownloadLoc.AutoSize = true;
            this.lblDownloadLoc.Location = new System.Drawing.Point(22, 9);
            this.lblDownloadLoc.Name = "lblDownloadLoc";
            this.lblDownloadLoc.Size = new System.Drawing.Size(96, 13);
            this.lblDownloadLoc.TabIndex = 5;
            this.lblDownloadLoc.Text = "DownloadLocation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "URL:";
            // 
            // txtUrl2
            // 
            this.txtUrl2.Location = new System.Drawing.Point(21, 131);
            this.txtUrl2.Name = "txtUrl2";
            this.txtUrl2.Size = new System.Drawing.Size(465, 20);
            this.txtUrl2.TabIndex = 8;
            this.txtUrl2.Text = "https://demo-res.cloudinary.com/image/upload/sample.png";
            // 
            // lblval2
            // 
            this.lblval2.AutoSize = true;
            this.lblval2.Location = new System.Drawing.Point(491, 136);
            this.lblval2.Name = "lblval2";
            this.lblval2.Size = new System.Drawing.Size(48, 13);
            this.lblval2.TabIndex = 7;
            this.lblval2.Text = "Progress";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Download";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "URL:";
            // 
            // txtUrl3
            // 
            this.txtUrl3.Location = new System.Drawing.Point(23, 193);
            this.txtUrl3.Name = "txtUrl3";
            this.txtUrl3.Size = new System.Drawing.Size(465, 20);
            this.txtUrl3.TabIndex = 12;
            this.txtUrl3.Text = "https://www.python.org/ftp/python/3.7.0/Python-3.7.0.tgz";
            // 
            // lblval3
            // 
            this.lblval3.AutoSize = true;
            this.lblval3.Location = new System.Drawing.Point(493, 198);
            this.lblval3.Name = "lblval3";
            this.lblval3.Size = new System.Drawing.Size(48, 13);
            this.lblval3.TabIndex = 11;
            this.lblval3.Text = "Progress";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(560, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Download";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(560, 12);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(87, 23);
            this.btnAll.TabIndex = 14;
            this.btnAll.Text = "All Download";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(393, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 24);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 265);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrl3);
            this.Controls.Add(this.lblval3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUrl2);
            this.Controls.Add(this.lblval2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblDownloadLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblval1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Downloader(saiful.alam@bjirgroup.com)";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblval1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDownloadLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl2;
        private System.Windows.Forms.Label lblval2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrl3;
        private System.Windows.Forms.Label lblval3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnReset;
    }
}

