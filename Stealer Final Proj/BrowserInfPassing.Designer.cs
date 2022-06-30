namespace NHA_Browser_Info_Passing
{
    partial class BrowserInfPassing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserInfPassing));
            this.GetPasswordsFromChrome = new System.Windows.Forms.Button();
            this.InfoBox = new System.Windows.Forms.TextBox();
            this.KnownDomains = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GetUserXBL = new System.Windows.Forms.Button();
            this.GetUserEmailStoreFromRegistry = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GetPasswordsFromChrome
            // 
            this.GetPasswordsFromChrome.Dock = System.Windows.Forms.DockStyle.Top;
            this.GetPasswordsFromChrome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetPasswordsFromChrome.ForeColor = System.Drawing.Color.Chartreuse;
            this.GetPasswordsFromChrome.Location = new System.Drawing.Point(0, 0);
            this.GetPasswordsFromChrome.MinimumSize = new System.Drawing.Size(340, 30);
            this.GetPasswordsFromChrome.Name = "GetPasswordsFromChrome";
            this.GetPasswordsFromChrome.Size = new System.Drawing.Size(340, 30);
            this.GetPasswordsFromChrome.TabIndex = 0;
            this.GetPasswordsFromChrome.Text = "Get User Infomation From Web Browsers";
            this.GetPasswordsFromChrome.UseVisualStyleBackColor = true;
            this.GetPasswordsFromChrome.Click += new System.EventHandler(this.GetPasswordsFromChrome_Click);
            // 
            // InfoBox
            // 
            this.InfoBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.InfoBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBox.ForeColor = System.Drawing.Color.Honeydew;
            this.InfoBox.Location = new System.Drawing.Point(0, 149);
            this.InfoBox.MinimumSize = new System.Drawing.Size(340, 350);
            this.InfoBox.Multiline = true;
            this.InfoBox.Name = "InfoBox";
            this.InfoBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.InfoBox.Size = new System.Drawing.Size(340, 394);
            this.InfoBox.TabIndex = 1;
            this.InfoBox.WordWrap = false;
            // 
            // KnownDomains
            // 
            this.KnownDomains.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(20)))), ((int)(((byte)(10)))));
            this.KnownDomains.Dock = System.Windows.Forms.DockStyle.Right;
            this.KnownDomains.ForeColor = System.Drawing.Color.LightYellow;
            this.KnownDomains.Location = new System.Drawing.Point(343, 0);
            this.KnownDomains.MaximumSize = new System.Drawing.Size(240, 99999452);
            this.KnownDomains.MinimumSize = new System.Drawing.Size(182, 450);
            this.KnownDomains.Multiline = true;
            this.KnownDomains.Name = "KnownDomains";
            this.KnownDomains.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.KnownDomains.Size = new System.Drawing.Size(182, 543);
            this.KnownDomains.TabIndex = 2;
            this.KnownDomains.WordWrap = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Blue;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(340, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 543);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GetUserEmailStoreFromRegistry);
            this.panel1.Controls.Add(this.GetUserXBL);
            this.panel1.Controls.Add(this.GetPasswordsFromChrome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 149);
            this.panel1.TabIndex = 4;
            // 
            // GetUserXBL
            // 
            this.GetUserXBL.Dock = System.Windows.Forms.DockStyle.Top;
            this.GetUserXBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetUserXBL.ForeColor = System.Drawing.Color.Chartreuse;
            this.GetUserXBL.Location = new System.Drawing.Point(0, 30);
            this.GetUserXBL.MinimumSize = new System.Drawing.Size(340, 30);
            this.GetUserXBL.Name = "GetUserXBL";
            this.GetUserXBL.Size = new System.Drawing.Size(340, 30);
            this.GetUserXBL.TabIndex = 1;
            this.GetUserXBL.Text = "Get User Xbox Account From Registry";
            this.GetUserXBL.UseVisualStyleBackColor = true;
            this.GetUserXBL.Click += new System.EventHandler(this.GetUserXBL_Click);
            // 
            // GetUserEmailStoreFromRegistry
            // 
            this.GetUserEmailStoreFromRegistry.Dock = System.Windows.Forms.DockStyle.Top;
            this.GetUserEmailStoreFromRegistry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetUserEmailStoreFromRegistry.ForeColor = System.Drawing.Color.Chartreuse;
            this.GetUserEmailStoreFromRegistry.Location = new System.Drawing.Point(0, 60);
            this.GetUserEmailStoreFromRegistry.MinimumSize = new System.Drawing.Size(340, 30);
            this.GetUserEmailStoreFromRegistry.Name = "GetUserEmailStoreFromRegistry";
            this.GetUserEmailStoreFromRegistry.Size = new System.Drawing.Size(340, 30);
            this.GetUserEmailStoreFromRegistry.TabIndex = 2;
            this.GetUserEmailStoreFromRegistry.Text = "Get Current User Emails From Registry";
            this.GetUserEmailStoreFromRegistry.UseVisualStyleBackColor = true;
            this.GetUserEmailStoreFromRegistry.Click += new System.EventHandler(this.GetUserEmailStoreFromRegistry_Click);
            // 
            // BrowserInfPassing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(525, 543);
            this.Controls.Add(this.InfoBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.KnownDomains);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(541, 489);
            this.Name = "BrowserInfPassing";
            this.Text = "Web Browser Personal Infomation Passing";
            this.Load += new System.EventHandler(this.UserInfoPassing_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GetPasswordsFromChrome;
        private System.Windows.Forms.TextBox InfoBox;
        private System.Windows.Forms.TextBox KnownDomains;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GetUserEmailStoreFromRegistry;
        private System.Windows.Forms.Button GetUserXBL;
    }
}

