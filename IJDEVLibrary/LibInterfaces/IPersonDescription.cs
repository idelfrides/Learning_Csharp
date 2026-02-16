using System;
using System.Collections.Generic;
using System.Text;

namespace IJDEVLibrary.LibInterfaces
{
    public interface IPersonDescription
    {
        public string FullName { get; }
        public int Age { get; }
        public string Address { get; }
        public string Gender { get; }
        public string PhoneNumber { get; }
        public string Nationality { get; }
        public string CountryOfResidence { get; }
        public string Scholarship { get; }
        public string Occupation { get; }
        public string MaritalStatus { get; }
        public string Email { get; }
        public decimal Salary { get; }

    }
}
