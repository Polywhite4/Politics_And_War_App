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
    public partial class Licence : Form
    {
        public Licence()
        {
            InitializeComponent();
        }

        private void Licence_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile("./Licence.rtf");
        }
    }
}
