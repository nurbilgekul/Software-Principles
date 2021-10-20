using _4_ISP.BadExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ISP.BadExample.Concrete
{
    class SmsMessage : IMessage
    {
        public IList<string> ToAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<string> BccAddresses { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string MessageBody { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Send()
        {
            throw new NotImplementedException();
        }
    }
}
