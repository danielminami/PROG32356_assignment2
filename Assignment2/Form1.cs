using Assignment2.models;
using System;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        private Calculator Calc = null;

        public Form1()
        {
            InitializeComponent();
            Calc = new Calculator();
        }

        //NumberClicked are for 7,8,9,4,5,6,1,2,3,0,. for all these buttons if you go on events for this and 
        //scroll and see "click" i wrote number Clicked there 
        private void Number_Click(object sender, EventArgs e)
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
            CleanDisplay();
            RestartCalculator();
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            if (Calc.OperatorSymbol != "+" || Calc.OperatorSymbol != "-" || Calc.OperatorSymbol != "*" || Calc.OperatorSymbol != "/" || 
                Calc.OperatorSymbol != "pow" || Calc.OperatorSymbol != "mod")
            {
                Calc.SecondNumber = Convert.ToDouble(outputDisplay.Text);
            }

            PerformOperation();
        }

        //Operators are +,-,*,/,% if you click on a button and go on events and see where it says click
        //you can see for the operators i wrote operators there
        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender; // object
            string btn = button.Tag.ToString();

            Calc.FirstNumber = Convert.ToDouble(outputDisplay.Text);
            Calc.OperatorSymbol = btn;

            CleanDisplay();

            if (!(btn == "+" || btn == "-" || btn == "*" ||
                btn == "/" || btn == "pow" || btn == "mod"
                ))
            {
                PerformOperation();
            }
        }

        private void Backspace_Click(object sender, EventArgs e)
        {
            outputDisplay.Text = outputDisplay.Text.Remove(outputDisplay.Text.Length - 1, 1);
            if (string.IsNullOrEmpty(outputDisplay.Text))
                CleanDisplay();

        }

        private void RestartCalculator()
        {
            Calc.FirstNumber = 0;
            Calc.SecondNumber = 0;
            Calc.OperatorSymbol = String.Empty;
        }
        private void CleanDisplay()
        {
            outputDisplay.Text = "0";
        }

        private void PerformOperation()
        {
            if (!string.IsNullOrEmpty(Calc.OperatorSymbol))
            {
                outputDisplay.Text = Calc.Calculate();

                RestartCalculator();
            }
        }
    }
}
