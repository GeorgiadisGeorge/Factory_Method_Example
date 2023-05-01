using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example
{
    // Base class for all documents
    public abstract class Document
    {
        // Common properties for all documents
        public virtual string Title { get; set; }
    }
}
