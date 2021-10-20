using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DIP.GoodExample.Concrete
{
    class CalculatorProgram
    {
        public void AddSample()
        {
            Calculator calculator = new Calculator(new AddCalculatorOperation());
            double result = calculator.Solve(1, 1);
            // Result is 2.
        }

        public void SubtractSample()
        {
            Calculator calculator = new Calculator(new SubtractCalculatorOperation());
            double result = calculator.Solve(1, 1);
            // Result is 0.
        }

        public void MultiplySample()
        {
            Calculator calculator = new Calculator(new MultiplyCalculatorOperation());
            double result = calculator.Solve(1, 2);
            // Result is 2.
        }

        public void DivideSample()
        {
            Calculator calculator = new Calculator(new DivideCalculatorOperation());
            double result = calculator.Solve(10, 5);
            // Result is 2.
        }
    }
}
