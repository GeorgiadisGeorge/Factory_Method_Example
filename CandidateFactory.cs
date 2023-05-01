using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example
{
    // Subclass 2
    public class CandidateFactory : DocumentFactory
    {
        // Implementation of the factory method that returns a Candidate object
        public override Document CreateDocument()
        {
            return new Candidate()
            {
                Title = "Candidate Information",
                Name = "George G",
                PhoneNumber = "210 1122333",
                
            };
        }

    }
}
