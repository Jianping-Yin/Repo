using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCaculator
{
    public partial class Form1 : Form
    {
        private bool isOperationPressed = false;
        private double result = 0;
        private string operation = " ";

        public Form1()
        {
            InitializeComponent();
            display.Text = "0";
        }

        //0-9,point
        private void btn9_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            if (operation == "=")
            //btnChange_Click(b, e)();
            {
                result = 0;
                operation = " ";
                isOperationPressed = false;
                display.Text = "0";

            }
            if (isOperationPressed == true)
            {
                display.Text = "0";
                isOperationPressed = false;
            }
            if ((display.Text == "0") && (b.Text != "."))
                display.Text = b.Text;
            else
                display.Text = display.Text + b.Text;
        }

        //+-*/=
        private void btnDivide_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (operation)
            {
                case (" "):
                    {
                        result = double.Parse(display.Text);
                        break;
                    }

                case ("+"):
                    {
                        result = result + double.Parse(display.Text);
                        break;
                    }
                case ("-"):
                    {
                        result = result - double.Parse(display.Text);
                        break;
                    }
                case ("*"):
                    {
                        result = result * double.Parse(display.Text);
                        break;
                    }
                case ("/"):
                    {
                        result = result / double.Parse(display.Text);
                        break;
                    }
                default:
                    break;

            }
            display.Text = result.ToString();
            if (b.Text == "=")
            {
                operation = "=";
                isOperationPressed = false;
            }
            else
            {
                operation = b.Text;
                isOperationPressed = true;
            }



        }
        //display
        private void display_Click(object sender, EventArgs e)
        {

        }
        //CE
        private void btnClear_Click(object sender, EventArgs e)
        {
            display.Text = "0";

        }
        //C
        private void btnChange_Click(object sender, EventArgs e)
        {
            result = 0;
            operation = " ";
            isOperationPressed = false;
            display.Text = "0";
        }
    }
}
