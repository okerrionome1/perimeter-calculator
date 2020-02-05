using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perimeter_calculator
{
    public partial class perimeterCalc : Form
    {
        public perimeterCalc()
        {
            InitializeComponent();
        }

        private void txtSidelenght_TextChanged(object sender, EventArgs e)
        {
            lblSidelenght.Text = txtSidelenght.Text;
        }

        private void btnFindPerimeter_Click(object sender, EventArgs e)
        {
            const ushort numberOfSides = 4;
            double sideLenght = double.Parse(txtSidelenght.Text);
            double perimeter = numberOfSides * sideLenght;

            lblPerimeter.Text = $" Perimeter is: {perimeter}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
