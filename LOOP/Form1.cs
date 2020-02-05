using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOOP
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            foreach (var x in textBox1.Text)
            {
                if (char.IsLetterOrDigit(x))
                    label3.Text = $"the input contains letters or digits";
            }
           

        }

        private void label2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            int i = 1;
            while (i <= 5)
            {
                label3.Text += $"i={i}\n";
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(richTextBox1.Text ))
            {
                MessageBox.Show($"{textBox1.Text } Has been found");
            }
            else
            {
                MessageBox.Show($"{textBox1.Text } Has not been found");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text = "the advises given to young stars has an adverse effect\n on them causing a lot of\n havoc in our society "; 
               
        }
    }
}
