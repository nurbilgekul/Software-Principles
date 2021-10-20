using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LSP.GoodExample
{
    class Whale : Mammalia
    {
        
        

        public override void Breathe()
        {
            throw new NotImplementedException();
        }

        public void Swim()
        { }
    }
}
