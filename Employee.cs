// create an employee class with the following properties: Name, Id, Salary, Department, Surname, birthdate, address, phone number, email
// make sure you use two constructors, one default and one overloaded   

using System;

namespace Company.Function
{
    public class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
        public string Surname { get; set; }
        public DateTime Birthdate { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int id, double salary, string department, string surname, DateTime birthdate, string address, string phoneNumber, string email)
        {
            Name = name;
            Id = id;
            Salary = salary;
            Department = department;
            Surname = surname;
            Birthdate = birthdate;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
