﻿using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;

namespace dotNetToPastGres.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string MiddleName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FullName => $"{FirstName} {MiddleName} {LastName}";
        public string EmailAdress { get; set; } = null!;
        public int PhoneNumber { get; set; }
        public int Gender { get; set; } 

    }
}
