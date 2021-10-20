using _4_ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ISP.GoodExample.Concrete
{
    class SmsMessage : IMessage
    {
        public bool Send(IList<string> toAddress, string messageBody)
        {
            throw new NotImplementedException();
        }
    }
}
