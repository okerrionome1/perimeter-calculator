using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace using_tenery_operator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            decimal firstAmount = decimal.Parse(textBox1.Text);
            lblFormattedAmount.Text = $"Amount is: {firstAmount:c}";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal firstAmount = decimal.Parse(textBox1.Text);
            //decimal amount = decimal.Parse(textBox1.Text);
            decimal finalAmount = (comboBox1.SelectedIndex == 0) ? firstAmount * 1.1M : firstAmount * 0.9M;
            lblFinalAmount.Text = $"The final amount is {finalAmount:c}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
