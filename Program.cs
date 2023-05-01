using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Certificate document using the CertificateFactory
            var certFactory = new CertificateFactory();
            var certificate = certFactory.CreateDocument() as Certificate;

            // Access and print Certificate properties
            Console.WriteLine("Certificate Details:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Title: {certificate.Title}");
            Console.WriteLine($"Issuer: {certificate.Issuer}");
            Console.WriteLine($"Date: {certificate.Subject}");

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");

            // Create a Candidate document using the CandidateFactory
            var candidateFactory = new CandidateFactory();
            var candidate = candidateFactory.CreateDocument() as Candidate;

            // Access and print Candidate properties
            Console.WriteLine("Candidate Details:");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine($"Title: {candidate.Title}");
            Console.WriteLine($"Name: {candidate.Name}");
            Console.WriteLine($"Phone: {candidate.PhoneNumber}");

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--------------------------------------");

            Console.ReadLine();


        }
    }
}
