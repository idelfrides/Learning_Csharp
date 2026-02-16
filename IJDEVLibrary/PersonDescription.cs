using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using IJDEVLibrary.LibInterfaces;

namespace IJDEVLibrary
{
    public class PersonDescription : IPersonDescription
    {
        public string FullName { get; private set; } = "Barack Obama";
        public int Age { get; set; } = 63;
        public string Address { get; set; } = "123 Main St";
        public string Gender { get; private set; } = "Male";
        public string PhoneNumber { get; protected set; } = "123-456-7890";
        public string Nationality { get; private set; } = "American";
        public string CountryOfResidence { get; protected set; } = "USA";
        public string Scholarship { get; set; } = "Degree";
        public string Occupation { get;  set; } = "Professor";
        public string MaritalStatus { get; protected set; } = "Married";
        public string Email { get; protected set; } = "barackobama@gmail.com";
        public decimal Salary { get; private set; } = 100000.0m;
        //public string FullName() => $"{Name} {Surname}";


        public PersonDescription(string fullName, int age, string address, string gender, string phoneNumber, string nationality,  string countryOfResidence, string scholarship, string occupation, string maritalStatus, string email, decimal salary)
        {
            FullName = fullName;
            Age = age;
            Address = address;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Nationality = nationality;
            CountryOfResidence = countryOfResidence;
            Scholarship = scholarship;
            Occupation = occupation;
            MaritalStatus = maritalStatus;
            Email = email;
            Salary = salary;
        }
    }
}

