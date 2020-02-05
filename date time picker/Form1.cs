using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace date_time_picker
{
    public partial class Form1 : Form
    {
        DateTime dt = DateTime.Parse("01/31/1988"); 
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value.Date > dt || dateTimePicker1.Value.Date < dt)
            {
                label1.Text = "No Discount for you";
            }
            else 
            {
                label1.Text = "";
            }

        }
    }
}
