using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OCP.Good_Example.Concrete
{
    class Circle : IShape
    {
        public double Radius { get; set; }
      

        public double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
