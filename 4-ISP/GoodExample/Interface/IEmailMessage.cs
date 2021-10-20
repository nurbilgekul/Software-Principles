using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ISP.GoodExample.Interface
{
    interface IEmailMessage:IMessage
    {
        string Subject { get; set; }
        IList<string> BccAddresses { get; set; }
    }
}
