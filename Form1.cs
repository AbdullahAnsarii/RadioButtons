using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dateTimeAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            string line = "";
            if (rbGot.Checked)
            {
                line = rbGot.Text;
                MessageBox.Show(line,"Your Choice");
            }
            if (rbBb.Checked)
            {
                line = rbBb.Text;
                MessageBox.Show(line, "Your choice");

            }
            if (rbTwd.Checked)
            {
                line = rbTwd.Text;
                MessageBox.Show(line, "Your choice");

            }
        }
    }
}
