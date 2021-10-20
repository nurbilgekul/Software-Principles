using _5_DIP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DIP.GoodExample.Concrete
{
    class AddCalculatorOperation : ICalculatorOperation
    {
        public double Calculate(double x, double y)
        {
            return x + y;
        }
    }
}
