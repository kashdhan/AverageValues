using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AverageValues
{
    public partial class Form1 : Form
    {
        int sum;
        int totalNumbers;
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int number = Convert.ToInt32(numberInput.Text);
            double average;

            if(number == 0)
            {
                average = sum / totalNumbers;
                outputLabel.Text = $"The average of these numbers is {average}.";
            }
            else
            {
                totalNumbers ++;
                sum += number;
                outputLabel.Text = $"{number} was added to the sum.";
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "";
            numberInput.Text = "0";
            sum = 0;
            totalNumbers = 0;
        }
    }
}
