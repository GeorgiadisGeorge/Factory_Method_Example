using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example
{
    // Candidate document class
    public class Candidate : Document
    {
        // Candidate-specific properties
        public override string Title { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}
