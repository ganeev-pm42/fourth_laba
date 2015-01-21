using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class red_button : Button
    {
        bool c;
        public bool Crossed { get { return c; } set { if (c != value) { c = value; Invalidate(); } } }
        public red_button()
        {
            InitializeComponent();
        }
    }
}
