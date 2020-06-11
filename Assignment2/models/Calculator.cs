using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.models {
    class Calculator {

        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public string Oper { get; set; }

        public string calculate (double n1, double n2, string op) {
            double result = 0;
            switch (op) {
                case "+":
                    result = n1 + n2;
                    break;
                case "-":
                    result = n1 - n2;
                    break;
                case "*":
                    result = n1 * n2;
                    break;
                case "/":
                    if (n1 == 0 || n2 == 0)
                        return "Error: Division by zero";
                    result = n1 / n2;
                    break;
                case "%":
                    result = n1 % n2;
                    break;
                case "n!":
                    result = factorial(n1);
                    break;
                case "abs":
                    result = Math.Abs(n1);
                    break;
                case "pow":
                    result = Math.Pow(n1, n2);
                    break;
                case "exp":
                    result = Math.Exp(n1);
                    break;
                case "1x":
                    if (n1 == 0)
                        return "Error: Division by zero";
                    result = 1/n1;
                    break;
                case "log":
                    result = Math.Log10(n1);
                    break;
                case "ln":
                    result = Math.Log(n1);
                    break;
                case "sqrt":
                    result = Math.Sqrt(n1);
                    break;
            }
            return result.ToString();
        }

        private double factorial(double n) {
            if (n == 0) {
                return 1;
            } else {
                return n * factorial(n - 1);
            }

        }
    }
}
