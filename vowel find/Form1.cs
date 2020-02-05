using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vowel_find
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVowelFind_Click(object sender, EventArgs e)
        {
            rchVowelsOutput.Text = "";
            string text = rchVowelnput.Text.ToLower();
            //rchVowelsOutput.Text = text;
            foreach (char c in text)
            {
                if ( text == "a" || text == "e" || text == "i" || text == "o"  || text == "u")
                    rchVowelsOutput.Text = $"{text}";
            }
        }
    }
}
