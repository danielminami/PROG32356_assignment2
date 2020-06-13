using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.models {
    public class Calculator {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public string OperatorSymbol { get; set; }
        public Calculator() { }

        public Calculator(double firstNumber, double secondNumber, string operatorSymbol)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            OperatorSymbol = operatorSymbol;
        }

        public string Calculate (double firstNumber, double secondNumber, string operatorSymbol) {
            double result = 0;
            switch (operatorSymbol.ToUpper()) {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    if (firstNumber == 0 || secondNumber == 0)
                        return "Error: Division by zero";
                    result = firstNumber / secondNumber;
                    break;
                case "%":
                    result = firstNumber % secondNumber;
                    break;
                case "N!":
                    result = Factorial(firstNumber);
                    break;
                case "ABS":
                    result = Math.Abs(firstNumber);
                    break;
                case "POW":
                    result = Math.Pow(firstNumber, secondNumber);
                    break;
                case "EXP":
                    result = Math.Exp(firstNumber);
                    break;
                case "1X":
                    if (firstNumber == 0)
                        return "Error: Division by zero";
                    result = 1/firstNumber;
                    break;
                case "LOG":
                    result = Math.Log10(firstNumber);
                    break;
                case "LN":
                    result = Math.Log(firstNumber);
                    break;
                case "SQRT":
                    result = Math.Sqrt(firstNumber);
                    break;
            }
            return result.ToString();
        }

        public string Calculate()
        {
            return Calculate(FirstNumber, SecondNumber, OperatorSymbol);
        }

        private double Factorial(double nValue) {
            return (nValue == 0) ? 1 : (nValue * Factorial(nValue - 1));
        }
    }
}
