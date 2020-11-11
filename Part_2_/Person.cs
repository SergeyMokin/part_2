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
        private string _email;
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email

        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value) || !value.Contains("@"))
                    throw new ArgumentException();
                _email = value;
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
            if (other == null)
                return 1;
            else
            {
                int compResult = 0;
                compResult = Id.CompareTo(other.Id);
                if (compResult != 0) 
                    return compResult;
                compResult = string.Compare(this.FirstName, other.FirstName);
                if (compResult != 0) 
                    return compResult;
                compResult = string.Compare(this.LastName, other.LastName);
                if (compResult != 0) 
                    return compResult;
                compResult = string.Compare(this.Email, other.Email);
                if (compResult != 0) 
                    return compResult;
                compResult = Gender.CompareTo(other.Gender);
                return compResult;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            else 
                return CompareTo(obj as IPerson);
                
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

