using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.BadExample
{
    public interface IPerson
    {
       int PersonId { get; set; }
       string FirstName { get; set; }
       string LastName { get; set; }

        void Speak();

    
       

    }
}
