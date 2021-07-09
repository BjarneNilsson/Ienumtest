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
        public int Add(String Name, UInt16 YearOfBirth)
        {
            _PList.Add(new Person(Name,YearOfBirth));
            return _PList.Count - 1;
        }
        public void UpdatePerson(int Index, Person person)
        {
            if (Index >= 0 & Index < _PList.Count)
            {
                _PList[Index] = person;
            }
            else throw new ArgumentOutOfRangeException("Index");
        }
        public Person GetPerson(int Index)
        {
            if (Index >= 0 & Index < _PList.Count)
            
                {
                return _PList[Index];
            }
            else throw new ArgumentOutOfRangeException("Index");
        }
        public void SetName(int Index,string Name)
        {
            if (Index >= 0 & Index < _PList.Count)

            {
                _PList[Index].Name = Name;
            }
            else throw new ArgumentOutOfRangeException("Index");
        }
        public void SetYearOfBirth(int Index, UInt16 YeatOfBirth)
        {
            if (Index >= 0 & Index < _PList.Count)

            {
                _PList[Index].YearOfBirth = YeatOfBirth;
            }
            else throw new ArgumentOutOfRangeException("Index");
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


