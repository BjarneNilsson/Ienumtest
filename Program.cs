using System;

namespace Ienumtest
{
    class Program
    {
        static void Main()
        {
            PersonList P = new()
            {
                "Bjarne",
                "Elly"
            };
            foreach (Person p in P)
            {
                Console.WriteLine(p.Name);
            }
            //aa
            
        }
    }
}
