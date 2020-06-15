using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.models
{
    /// <summary>
    /// This class stores the M function from Calculator
    /// </summary>
    public class Mem
    {
        public double Number { get; set; }

        
        public Mem()
        {
            Clear();
        }
        
        public void Clear()
        {
            Number = 0;
        }
    }
}
