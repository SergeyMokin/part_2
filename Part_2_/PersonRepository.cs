using System;
using System.Text.RegularExpressions;

namespace Part_2
{
    // Implement without LINQ
    public class PersonRepository 
    {
        private IPerson[] _persons;
        
        public PersonRepository(IPerson[] persons)
        {
            _persons = persons;
        }
        

        // TODO: return count of mans
        public int ManCount
        {
            get
            {
                int counter = 0;
                foreach (IPerson p in _persons)
                {
                    if (p.Gender == 0)
                        ++counter;
                }
                return counter;
            }
        }

        // TODO: return count of womans
        public int WomanCount
        {
            get {
                int counter = 0;
                foreach (IPerson p in _persons)
                {
                    if ((int)p.Gender == 1)
                        counter++;
                }
                return counter;
            }
        }

        public IPerson[] Get()
        {
            // TODO: return all persons
            return _persons;
        }

        public IPerson Get(long id)
        {
            // TODO: find person by Id
          foreach(IPerson person in _persons) 
            {
                if (person.Id == id)
                    return person;
            }
            return null;
        }

        public IPerson[] GetOrderedPersons()
        {
            return Sorting.Order(_persons);
        }

        public IPerson[] GetDescendingOrderedPersons()
        {
            // TODO: reuse Sorting class and return descending ordered Persons
            return Sorting.DescendingOrder(_persons);
        }

        public string[] GetUniquePersonEmails()
        {
            // TODO: get person emails and return list of Unique Emails
            string[] emails = new string[_persons.Length];
            for (int i = 0; i <_persons.Length; i++)
            {
                emails[i] = _persons[i].Email;
            }
            return Sorting.Unique(emails);

        }

        public IPerson Add(IPerson person)
        {
            // TODO: add new Person
            if (_persons[_persons.Length - 1] == null)
                 _persons[_persons.Length - 1] = person;
            return person;
        }

        public IPerson Edit(IPerson person)
        {
            // TODO: edit person
            _persons[Array.IndexOf(_persons, Get(person.Id))] = person;
            return person;
            
        }
        
        public IPerson Delete(long id)
        {
            // TODO: delete person
            for (long i = 0; i < _persons.Length; ++i)
            {
                if (_persons[i].Id == id)
                    
                return _persons[i];
            }
            return _persons[id-1] = null; 
        }
    }
}
