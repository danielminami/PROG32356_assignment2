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
            }
            return result.ToString();
        }

    }
}
