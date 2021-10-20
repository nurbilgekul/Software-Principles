using _4_ISP.GoodExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ISP.GoodExample.Concrete
{
    class SmtpMessage : IEmailMessage
    {
        public string Subject { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IList<string> BccAddresses { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Send(IList<string> toAddress, string messageBody)
        {
            throw new NotImplementedException();
        }
    }
}
