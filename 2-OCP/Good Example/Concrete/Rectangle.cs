using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_OCP.Good_Example.Concrete
{
    class Rectangle:IShape
    {
        public double Height { get; set; }
        public double Width { get; set; }
       

        double IShape.Area()
        {
            return Height * Width;
        }
    }
}
