using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example
{
    // Subclass 1
    public class CertificateFactory : DocumentFactory
    {
        // Implementation of the factory method that returns a Certificate object
        public override Document CreateDocument()
        {
            return new Certificate()
            {
                Title = "English B1",
                Issuer = "George G",
                Subject = "Speaking Exam"
            };
        }
    }
}
