using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Data.Entities
{
    public class User
    {
        public int Id { get; set; }
       // public string FirstName { get; set; }
       // public string MiddleName { get; set; }
       // public string LastName { get; set; }
       // public string EmailAddress { get; set; }
       // int YearsInSchool { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Years in School")]
        public int YearsInSchool { get; set; }

    }
}