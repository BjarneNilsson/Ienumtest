using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumtest
{
    class Person
    {
        string _Name;
        public Person (String Name)
        {
            _Name = Name;
        }
        public string Name { get { return _Name; } set { _Name = value; } }
    }
}
