using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageMarks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtDisplay1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplay2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDisplay4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDisplay5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDisplay1_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplay2_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplay3_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplay4_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplay5_Click(object sender, EventArgs e)
        {

        }

        private void lblDisplay6_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay1_Click(object sender, EventArgs e)
        {

            double FirstMark = Convert.ToDouble(txtDisplay1.Text);

            double SecondMark= Convert.ToDouble(txtDisplay2.Text);

            double ThirdMark= Convert.ToDouble(txtDisplay3.Text);

            double FourthMark= Convert.ToDouble(txtDisplay4.Text);

            double FifthMark= Convert.ToDouble(txtDisplay5.Text);

            double average = (FirstMark + SecondMark + ThirdMark + FourthMark + FifthMark)/5;

            lblDisplay6.Text = String.Format("{0, 10} {1, 10} \n{2, 10} {3, 10} \n{4, 10} {5, 10} \n{6, 10} {7, 10} \n{8, 10} {9, 10} \n{10, 10} {11, 10}","Mark 1:", FirstMark, "Mark 2:", SecondMark, "Mark 3:", ThirdMark, "Mark 4:", FourthMark, "Mark 5:", FifthMark, "Average:", average);

        }
    }
}
