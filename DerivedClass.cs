using System;
using LibraryProject;

class DerivedClass : BaseClass
{
    public void AccBaseClass() 
    {
        Console.WriteLine(message);
        show();
    }
}

class Program 
{
    public static void Main() 
    {
        DerivedClass derived = new DerivedClass();

        derived.AccBaseClass();
    }
}

/*Hello from BaseClass (protected internal member)


Protected Internal Method: Accessible in same assembly and derived classes of other assemblies.*/