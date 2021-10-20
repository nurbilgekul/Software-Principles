using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_DIP.BadExample
{
    class Calculator
    {
      
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }

        // The simple Calculator class above with two operations works but what if we want to add a new operation, say Multiply? Adding a new operation to our current Calculator class will modify the current class. This modification will break the “O” in S.O.L.I.D.which is the Open-Close Principle(OCP). OCP states that:Objects(or software entities) should be open for extension, but closed for modification.
        //The goal that we want right now is to add a new operation to our Calculator class. Looking at the previous methods Add and Subtract we can safely say that we can actually create an interface or a contract that our Calculator uses.
    }
}
