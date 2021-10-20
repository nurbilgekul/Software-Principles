using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LSP.BadExample
{
    public abstract class Mammalia
    {
        public string Name  { get; set; }
        public int Age { get; set; }
        public string  Type { get; set; }

        public abstract void Fly();

        public abstract void Breath();

        public abstract void Swim();
       

    }
}
