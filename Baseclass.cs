using System;

namespace LibraryProject 
{
    public class BaseClass 
    {
        protected internal string message = "Hello from BaseClass (protected internal member)\n\n";

        protected internal void show() 
        {
            Console.WriteLine("Protected Internal Method: Accessible in same assembly and derived classes of other assemblies.");
        }
    }
}