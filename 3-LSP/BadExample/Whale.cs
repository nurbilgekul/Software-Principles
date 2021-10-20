using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_LSP.BadExample
{
    public class Whale : Mammalia
    {
        public override void Breath()
        {
            throw new NotImplementedException();
        }

        public override void Fly()
        {
            throw new NotImplementedException();
        }

        public override void Swim()
        {
            throw new NotImplementedException();
        }

        
    }
}
