namespace pw_app
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.licenceAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sitesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.politicsAndWarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.politicsAndWarWikiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Browser = new System.Windows.Forms.WebBrowser();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.politicsAndWarTestServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickGoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.sitesToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.backToolStripMenuItem,
            this.quickGoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.licenceAppToolStripMenuItem,
            this.toolStripMenuItem4,
            this.settingsToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.helpToolStripMenuItem.Text = "Main";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // licenceAppToolStripMenuItem
            // 
            this.licenceAppToolStripMenuItem.Name = "licenceAppToolStripMenuItem";
            this.licenceAppToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.licenceAppToolStripMenuItem.Text = "Licence (App)";
            this.licenceAppToolStripMenuItem.Click += new System.EventHandler(this.licenceAppToolStripMenuItem_Click);
            // 
            // sitesToolStripMenuItem
            // 
            this.sitesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.politicsAndWarToolStripMenuItem,
            this.toolStripMenuItem2,
            this.politicsAndWarWikiToolStripMenuItem,
            this.toolStripMenuItem3,
            this.politicsAndWarTestServerToolStripMenuItem});
            this.sitesToolStripMenuItem.Name = "sitesToolStripMenuItem";
            this.sitesToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.sitesToolStripMenuItem.Text = "Sites";
            // 
            // politicsAndWarToolStripMenuItem
            // 
            this.politicsAndWarToolStripMenuItem.Name = "politicsAndWarToolStripMenuItem";
            this.politicsAndWarToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.politicsAndWarToolStripMenuItem.Text = "Politics and War";
            this.politicsAndWarToolStripMenuItem.Click += new System.EventHandler(this.politicsAndWarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(248, 6);
            // 
            // politicsAndWarWikiToolStripMenuItem
            // 
            this.politicsAndWarWikiToolStripMenuItem.Name = "politicsAndWarWikiToolStripMenuItem";
            this.politicsAndWarWikiToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.politicsAndWarWikiToolStripMenuItem.Text = "Politics and War Wiki (In Browser)";
            this.politicsAndWarWikiToolStripMenuItem.Click += new System.EventHandler(this.politicsAndWarWikiToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // Browser
            // 
            this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Browser.Location = new System.Drawing.Point(0, 24);
            this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.Browser.Name = "Browser";
            this.Browser.ScriptErrorsSuppressed = true;
            this.Browser.Size = new System.Drawing.Size(900, 609);
            this.Browser.TabIndex = 1;
            this.Browser.Url = new System.Uri("https://politicsandwar.com/", System.UriKind.Absolute);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(248, 6);
            // 
            // politicsAndWarTestServerToolStripMenuItem
            // 
            this.politicsAndWarTestServerToolStripMenuItem.Name = "politicsAndWarTestServerToolStripMenuItem";
            this.politicsAndWarTestServerToolStripMenuItem.Size = new System.Drawing.Size(251, 22);
            this.politicsAndWarTestServerToolStripMenuItem.Text = "Politics and War Test Server";
            this.politicsAndWarTestServerToolStripMenuItem.Click += new System.EventHandler(this.politicsAndWarTestServerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // quickGoToolStripMenuItem
            // 
            this.quickGoToolStripMenuItem.Name = "quickGoToolStripMenuItem";
            this.quickGoToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.quickGoToolStripMenuItem.Text = "Quick Go";
            this.quickGoToolStripMenuItem.Click += new System.EventHandler(this.quickGoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 633);
            this.Controls.Add(this.Browser);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Politics and War App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sitesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem politicsAndWarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem politicsAndWarWikiToolStripMenuItem;
        private System.Windows.Forms.WebBrowser Browser;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem licenceAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem politicsAndWarTestServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickGoToolStripMenuItem;
    }
}

