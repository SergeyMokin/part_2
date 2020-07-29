using System;

namespace Part_2
{
    public interface IPerson : IComparable<IPerson>, IComparable
    {
        long Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        Gender Gender { get; set; }
        string GetFullName();
    }
}
