using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LSP.GoodExample
{
    public abstract class Mammalia
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Type { get; set; }

        public abstract void Breathe();
    }
}
