using System;

namespace Ienumtest
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonList P = new PersonList();
            P.Add("Bjarne");
            P.Add("Elly");
            foreach (Person p in P)
            {
                Console.WriteLine(p.Name);
            }
            
            Console.WriteLine("Hello World!");
        }
    }
}
