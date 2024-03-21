using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class Form1 : Form
    {
        double firstNumber;
        double secondNumber;

        public Form1()
        {
            InitializeComponent();
        }
       

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            try
                {
                    firstNumber = Convert.ToInt32(txtFirstNumber.Text);
                }
            catch { }

                try
                {
                    secondNumber = Convert.ToInt32(txtSecondNumber.Text);
                }
                catch { }


                lblResultLabel.Text = (firstNumber + secondNumber).ToString();
            }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToInt32(txtFirstNumber.Text);
            }
            catch { }

            try
            {
                secondNumber = Convert.ToInt32(txtSecondNumber.Text);
            }
            catch { }


            lblResultLabel.Text = (firstNumber - secondNumber).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToInt32(txtFirstNumber.Text);
            }
            catch { }

            try
            {
                secondNumber = Convert.ToInt32(txtSecondNumber.Text);
            }
            catch { }


            lblResultLabel.Text = (firstNumber * secondNumber).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                firstNumber = Convert.ToInt32(txtFirstNumber.Text);
            }
            catch { }

            try
            {
                secondNumber = Convert.ToInt32(txtSecondNumber.Text);
            }
            catch { }

            if (firstNumber == 0 && secondNumber == 0)
            {
                MessageBox.Show("Result is undetermined");
                
            }

            if (secondNumber == 0)
            {
                MessageBox.Show("Result is undefined");
                return;

            }
            else
            {
                lblResultLabel.Text = (firstNumber / secondNumber).ToString();
            }
            
        }

    }
    
}
