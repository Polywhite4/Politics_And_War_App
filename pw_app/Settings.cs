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
    public partial class Settings : Form
    {
        SettingsError error = new SettingsError();
        public Settings()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            applySettings();
            if (applySettings() > 0)
            {
                error.Show();
            }
            else
            {
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            applySettings();
            if (applySettings() > 0)
            {
                error.Show();
            }
        }

        public int applySettings()
        {
            try
            {
                Form1.NationStuff.mainNationID = textBox1.Text;
            }
            catch { return 1; }
            return 0;
        }
    }
}
