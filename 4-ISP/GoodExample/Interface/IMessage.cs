using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ISP.GoodExample.Interface
{
    public interface IMessage
    {
        bool Send(IList<string> toAddress, string messageBody);
    }
}
