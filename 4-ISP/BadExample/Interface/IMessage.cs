using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ISP.BadExample.Interface
{
    interface IMessage
    {
        IList<string> ToAddress { get; set; }
        IList<string> BccAddresses { get; set; }
        string MessageBody { get; set; }
        string Subject { get; set; }
        bool Send();
    }
}
