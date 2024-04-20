using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calugjha
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBox1.Text); // Value of users first input
                int b = int.Parse(textBox2.Text); // Value of users second input
                int c; // Value of the results of a and b

                if (radioButton1.Checked)
                {
                    c = a + b;
                    label4.Text = "Sum = " + c.ToString();// Adds first number and second number
                }
                else if (radioButton2.Checked)
                {
                    c = a - b;
                    label4.Text = "Diff = " + c.ToString();// Subtracts second number from first number
                }
                else if (radioButton3.Checked)
                {
                    c = a * b;
                    label4.Text = "Product = " + c.ToString();// Multiplies first number and second number
                }
                else if (radioButton4.Checked)
                {
                    if (b != 0)// Checks division by 0 error   
                    {
                        c = a / b;
                        label4.Text = "Quotient = " + c.ToString();// Divides first number by second number
                    }
                    else
                    { label4.Text = "No good get mogged"; }//
                }
                else if (radioButton5.Checked)
                {
                    if (b != 0)// Checks division by 0 error
                    {
                        c = a % b;
                        label4.Text = "Mod = " + c.ToString();// Mod first and second num
                    }
                    else
                    { label4.Text = "No good get mogged"; }// Mod by 0 error
                }
            }
            catch (FormatException)
            { label4.Text = "Opinion rejected, be valid"; }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {//Clears inputs and outputs
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Text = "";
        }
    }
}
