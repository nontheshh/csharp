using System;

namespace DbManagerEntityFramework.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }

        public string Address { get; set; }
        public DateTime BirthDate { get; set; }

        public string AboutYourself { get; set; }

        public virtual Department Department { get; set; }
    }
}
