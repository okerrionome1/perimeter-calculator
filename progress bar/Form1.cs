using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progress_bar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fill_Click(object sender, EventArgs e)
        {
            for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
            {
                progressBar1.PerformStep();
                richTextBox1.Text +=$"{i}\n";
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            progressBar1.Value = 0;
        }
    }
}
