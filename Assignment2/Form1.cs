using Assignment2.models;
using System;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        private Calculator Calc = null;
        private Mem mem = null;
        private bool IsReset;

        public Form1()
        {
            InitializeComponent();
            Calc = new Calculator();
        }

        //NumberClicked are for 7,8,9,4,5,6,1,2,3,0,. for all these buttons if you go on events for this and 
        //scroll and see "click" i wrote number Clicked there 
        private void Number_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (IsReset) {
                CleanDisplay();
                IsReset = false;
            }

            if (outputDisplay.Text == "0" && b.Text != "0")
            {
                outputDisplay.Text = (b.Text != ".") ? b.Text : outputDisplay.Text + b.Text;
            }
            else if (outputDisplay.Text != "0" && b.Text != "." || (b.Text == "." && !outputDisplay.Text.Contains(".")))
            {
                outputDisplay.Text += b.Text;
            }
        }

        // This method is called to handle Memory Function
        private void MemBttn_Click(object sender, EventArgs e) {
            if (mem == null)
                mem = new Mem();

            double currentNumber = Convert.ToDouble(outputDisplay.Text);

            if (sender == btnMemoryAdd && currentNumber != 0) {
                mem.Number += currentNumber;
            } else if (sender == btnMemoryClear) {
                mem.Clear();
            } else if (sender == btnMemoryRecall) {
                outputDisplay.Text = mem.Number.ToString();
            }
        }

        // This method handles the Button Clear click event
        private void ClearBttn_Click(object sender, EventArgs e)
        {
            CleanDisplay();
            RestartCalculator();
        }

        // This method handles the Button Equal click event
        private void Equal_Click(object sender, EventArgs e)
        {
            if (Calc.OperatorSymbol != "+" || Calc.OperatorSymbol != "-" || Calc.OperatorSymbol != "*" || 
                Calc.OperatorSymbol != "/" || Calc.OperatorSymbol != "pow" || Calc.OperatorSymbol != "mod")
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

        // This method handles the Button Backspace click event
        private void Backspace_Click(object sender, EventArgs e)
        {
            outputDisplay.Text = outputDisplay.Text.Remove(outputDisplay.Text.Length - 1, 1);
            if (string.IsNullOrEmpty(outputDisplay.Text))
                CleanDisplay();

        }

        // Resets the Calculator Instance
        private void RestartCalculator()
        {
            Calc.FirstNumber = 0;
            Calc.SecondNumber = 0;
            Calc.OperatorSymbol = String.Empty;
        }

        // This Method will display 0 in the Calculator Display
        private void CleanDisplay()
        {
            outputDisplay.Text = "0";
        }

        // Calls the Calculator Class to perform the operation and display it in the Calculator Text Field
        private void PerformOperation()
        {
            if (!string.IsNullOrEmpty(Calc.OperatorSymbol))
            {
                outputDisplay.Text = Calc.Calculate();
                RestartCalculator();
                IsReset = true;
            }
        }
    }
}
