using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pw_app
{
    public partial class Form1 : Form
    {

        System.Uri pwwiki = new System.Uri("https://politicsandwar.fandom.com");
        System.Uri p_w = new System.Uri("https://politicsandwar.com");
        System.Uri testpw = new System.Uri("https://test.politicsandwar.com");
        public static class NationStuff
        {
            public static string mainNationID = null;
            public static string quickNationID = null;
            public static bool quickGoNow = false;
        }
        public Form1()
        {
            InitializeComponent();
            while (true)
            {
                if (NationStuff.quickGoNow = true)
                {
                    System.Uri quickGo = new System.Uri("https://politicsandwar.com/nation/id=" + NationStuff.quickNationID);
                    NationStuff.quickGoNow = false;
                }
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void politicsAndWarWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://politicsandwar.fandom.com");
        }
        
        private void politicsAndWarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browser.Url = p_w;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();
            aboutBox.Show();
        }

        private void licenceAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Licence licence = new Licence();
            licence.Show();
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browser.Refresh();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browser.GoBack();
        }

        private void politicsAndWarTestServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Browser.Url = testpw;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings sets = new Settings();
            sets.Show();
        }

        private void quickGoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuickNation qn = new QuickNation();
            qn.Show();
        }
    }
}
