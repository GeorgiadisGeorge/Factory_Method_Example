using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example
{
    // Certificate document class
    public class Certificate : Document
    {
        // Certificate-specific properties
        public override string Title { get; set; }
        public string Issuer {  get; set; }
        public string Subject { get; set; }
    }
}
