using System;

namespace Ienumtest
{
    class Program
    {
        static void Main()
        {
            PersonList P = new();
            
            P.Add("yo", 1980);
            P.Add("test",2005);
            //P.SetName(1,"Tester");
            foreach (Person p in P)
            {
                Console.WriteLine("{0} was born in {1}",p.Name,p.YearOfBirth);
            }
            
        }
    }
}
