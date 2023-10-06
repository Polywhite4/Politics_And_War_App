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
    public partial class QuickNation : Form
    {
        public QuickNation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.NationStuff.quickNationID = textBox1.Text;
            Form1.NationStuff.quickGoNow = true;
        }
    }
}
