using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.models
{
    public class Mem
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public string Operator { get; set; }
        
        public Mem()
        {
            Clear();
        }
        
        public void Clear()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            Operator = String.Empty;
        }
    }
}
