using System;
using System.ComponentModel.DataAnnotations;

namespace demo1.Models {

    public class Person {

        [Display(Name = "First Name"), Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name"), Required]
        public string LastName { get; set; }

        [Display(Name = "Date of Birth"), Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public State State { get; set; }
    }
}