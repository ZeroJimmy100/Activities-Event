using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace ActivitiesEvent.Models{

    public class Users
    {

        [Key]
        public int UserId {get; set;}

        [Required]
        [Display(Name = "First Name")]
        public string FirstName {get; set;}

        [Required]
        [Display(Name = "Last Name")]
        public string LastName {get; set;}

        [Required]
        [Display(Name="Email Address")]
        [EmailAddress]
        public string Email {get; set;}

        [Required]
        [Display(Name="Password")]
        [DataType(DataType.Password)]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters or longer, along with 1 special character, 1 letter and 1 number!")]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 3 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
        public string PassWord {get; set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        [Display(Name="Confirm Password")]
        [Compare("PassWord")]
        [DataType(DataType.Password)]
        public string ConfirmPW {get; set;}

        public List<FormEvent> MyEvent {get; set;}
        
        public List<Associates> Attending {get; set;}
    }
    
}