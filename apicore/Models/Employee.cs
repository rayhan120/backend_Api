﻿using System.ComponentModel.DataAnnotations;

namespace apicore.Models
{
    public class Employee
    {

       public int Id { get; set; }
      // public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Salary { get; set; }
        public string Department { get; set; }

    }
}
