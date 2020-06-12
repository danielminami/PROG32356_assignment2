using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2 {
    public partial class Form1 : Form {

        String math = "";
        Double input1, input2;
        public Form1() {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //NumberClicked are for 7,8,9,4,5,6,1,2,3,0,. for all these buttons if you go on events for this and 
        //scroll and see "click" i wrote number Clicked there 
        private void NumberClicked(object sender, EventArgs e)
        {
            Button b = (Button)sender; // creating an object


            if (outputDisplay.Text == "0")
                outputDisplay.Text = "";
            // to use decimal only once
            if (b.Text == ".")
            {
                if (!outputDisplay.Text.Contains("."))
                    outputDisplay.Text = outputDisplay.Text + b.Text;

            }

            else
            {
                outputDisplay.Text = outputDisplay.Text + b.Text;

            }
        }

        private void clearBttn_Click(object sender, EventArgs e)
        {
            // it will display a 0 when the clear button is clicked
            outputDisplay.Text = "0";
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            input2 = double.Parse(outputDisplay.Text);
            switch (math)
            {
                case "+":
                    outputDisplay.Text = Convert.ToString(input1 + input2);
                    break;

                case "-":
                    outputDisplay.Text = Convert.ToString(input1 - input2);
                    break;
                case "*":
                    outputDisplay.Text = Convert.ToString(input1 * input2);
                    break;

                case "/":
                    outputDisplay.Text = Convert.ToString(input1 / input2);
                    break;
                case "%":
                    outputDisplay.Text = Convert.ToString(input1 % input2);
                    break;
                default:
                    break;

            }
        }

        //Operators are +,-,*,/,% if you click on a button and go on events and see where it says click
        //you can see for the operators i wrote operators there
        private void Operator(object sender, EventArgs e)
        {
            Button b = (Button)sender; // object
            input1 = double.Parse(outputDisplay.Text);
            math = b.Text;
            outputDisplay.Text = "";
        }
    }
}
