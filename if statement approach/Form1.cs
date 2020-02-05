using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_statement_approach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked && checkBox2.Checked)
            {
                label1.Text = "10% Discount";
            }
            else if (checkBox1.Checked)
            {
                label1.Text = "4% Discount";
            }
            else if (checkBox2.Checked)
            {
                label1.Text = "6% Discount";
            }
            else {
                label1.Text = "";
            };

        }
    }
}
