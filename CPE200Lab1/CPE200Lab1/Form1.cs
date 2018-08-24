using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        double first_num ;
        double second_num;
        double Result;
        string resulted;
        string Operation; 
        public Form1() //constructor
        {
            InitializeComponent();
        }
            
        private void btnDivide_Click(object sender, EventArgs e)
        {
            first_num = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = "0";
            Operation =  "/";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = lblDisplay.Text + ".";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            string resulted;

            second_num = Convert.ToDouble(lblDisplay.Text);
            if (Operation == "+")
                {
                Result = (first_num + second_num);
                lblDisplay.Text = Convert.ToString(Result);
                first_num = Result;
            }
            if (Operation == "-")
            {
                Result = (first_num - second_num);
                lblDisplay.Text = Convert.ToString(Result);
                first_num = Result;
            }
            if (Operation == "X")
            {
                Result = (first_num * second_num);
                lblDisplay.Text = Convert.ToString(Result);
                    first_num = Result;
            }
            if (Operation == "÷")
            {
                if (second_num == 0)
                {
                    lblDisplay.Text = "Cannot divide by zero";
                }
                else
                {
                    Result = (first_num / second_num);
                    lblDisplay.Text = Convert.ToString(Result);
                    first_num = Result;
                }
            }
            resulted = Convert.ToString(Result);

            if (resulted.Length > 8)
            {
                lblDisplay.Text = "ERROR";
            }
        }


      
        private void number(object sender, EventArgs e)
        {
            if (lblDisplay.Text.Length < 8)
            {
                if (lblDisplay.Text == "0" && lblDisplay.Text != null)
                {
                    lblDisplay.Text = ((Button)sender).Text;
                }
                else
                {
                    lblDisplay.Text = lblDisplay.Text + ((Button)sender).Text;
                }
            }

        }

        private void btnOperator(object sender, EventArgs e)
        {
            first_num = Convert.ToDouble(lblDisplay.Text);
            lblDisplay.Text = " ";
            Operation = ((Button)sender).Text;
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {

            if (lblDisplay.Text==" ")
            {
               Result = first_num * first_num / 100;
               lblDisplay.Text= Convert.ToString(Result);
            } 
            else                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    
            {
                double secondNum = Convert.ToDouble(lblDisplay.Text);

                Result = first_num * secondNum / 100;
                lblDisplay.Text = Convert.ToString(Result);
            }
        }
        
    }
}

        


    

