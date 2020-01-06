using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoDBPublish.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int AddressId { get; set; }

        [ForeignKey("AddressId")]
        public Address Address { get; set; }
    }

    public class Address
    {
        public int AddressId { get; set; }
        public string AddressLine { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
    }
}