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
        UInt16 _YOB;
        public Person (String Name, UInt16 YOB)
        {
            _Name = Name;
            _YOB = YOB;
        }
        public string Name { get { return _Name; } set { _Name = value; } }
        public UInt16 YearOfBirth { get { return _YOB; } set { _YOB = value; } }

    }
}
