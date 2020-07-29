using System;
using System.Collections.Generic;

namespace Part_2
{
    // TODO: inherit IPerson interface
    // TODO: create Person class with public parameters Id (long), FirstName (string), LastName (string), Email (string), Gender (Enum).
    // TODO: add method to get full name()
    // TODO: validate an email, email validation: check for NULL or Empty and contains string = "@". OnFail - thrown an ArgumentException.
    // TODO: override Equals and  GetHashCode
    public class Person : IPerson
    {
        private string email;
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email

        {
            get { return email; }
            set
            {
                if (string.IsNullOrEmpty(value) || !value.Contains("@"))
                    throw new ArgumentException();
                email = value;
            }
        }
        public Gender Gender { get; set; }


        public Person()
        {
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;
        }

        public int CompareTo(IPerson other)
        {
            return this.FirstName.CompareTo(other.FirstName);
        }

        public int CompareTo(object obj)
        {
            if (obj is Person p)
                return this.FirstName.CompareTo(p.FirstName);
            else
                throw new Exception("compare is Failed");
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Id == person.Id &&
                   FirstName == person.FirstName &&
                   LastName == person.LastName &&
                   Email == person.Email &&
                   Gender == person.Gender;
        }

        public override int GetHashCode()
        {
            int hashCode = -858214181;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + Gender.GetHashCode();
            return hashCode;
        }
    }

}

