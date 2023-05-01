using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example
{
    // Superclas
    public abstract class DocumentFactory
    {
        // Factory method that returns a Document objust
        public abstract Document CreateDocument();
    }
}
