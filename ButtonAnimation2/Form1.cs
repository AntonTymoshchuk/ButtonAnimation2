using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonAnimation2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.TabIndex = 0;
            button1.TabStop = true;
            button1.GotFocus += Button1_GotFocus;
        }

        private void Button1_GotFocus(object sender, EventArgs e)
        {

        }
    }
}
