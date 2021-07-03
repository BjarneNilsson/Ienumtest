using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ienumtest
{
    class PersonList : IEnumerable<Person>
    {
        List<Person> _PList;
        public PersonList() { 
            _PList = new List<Person>();
        }
        public void Add(String Name)
        {
            _PList.Add(new Person(Name));
        }
        #region IEnumrable Implememntation
        public IEnumerator<Person> GetEnumerator()
            {
            foreach (Person p in _PList) 
            {
            yield return p;
            }
            }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _PList.GetEnumerator();
        }
        #endregion

    }
}


