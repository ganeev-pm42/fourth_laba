using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            progressBar1.Value = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
                progressBar1.Value++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value > 0)
                progressBar1.Value--;
        }
    }
}
