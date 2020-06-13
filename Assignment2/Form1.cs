using Assignment2.models;
using System;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        private Calculator Calc;

        public Form1()
        {
            InitializeComponent();
            Calc = new Calculator();
        }

        //NumberClicked are for 7,8,9,4,5,6,1,2,3,0,. for all these buttons if you go on events for this and 
        //scroll and see "click" i wrote number Clicked there 
        private void NumberClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender; // creating an object

            if (outputDisplay.Text == "0" && b.Text != "0")
            {
                outputDisplay.Text = (b.Text != ".") ? b.Text : outputDisplay.Text + b.Text;
            }
            else if (outputDisplay.Text != "0" && b.Text != ".")
            {
                outputDisplay.Text += b.Text;
            }
            else if (b.Text == "." && !outputDisplay.Text.Contains("."))
            {
                outputDisplay.Text += b.Text;
            }
        }

        private void ClearBttn_Click(object sender, EventArgs e)
        {
            // it will display a 0 when the clear button is clicked
            outputDisplay.Text = "0";

            Clear();
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Calc.OperatorSymbol))
            {
                Calc.SecondNumber = Convert.ToDouble(outputDisplay.Text);
                outputDisplay.Text = Calc.Calculate();

                Clear();
            }
        }

        //Operators are +,-,*,/,% if you click on a button and go on events and see where it says click
        //you can see for the operators i wrote operators there
        private void Operator(object sender, EventArgs e)
        {
            Button b = (Button)sender; // object

            Calc.FirstNumber = Convert.ToDouble(outputDisplay.Text);

            Calc.OperatorSymbol = b.Text;
            outputDisplay.Text = "0";
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            if (outputDisplay.Text != "0")
                outputDisplay.Text = outputDisplay.Text.Remove(outputDisplay.Text.Length - 1, 1);
        }

        private void Clear()
        {
            Calc.FirstNumber = 0;
            Calc.SecondNumber = 0;
            Calc.OperatorSymbol = String.Empty;
        }
    }
}
