using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TraniningProject.Models
{
    public class Registration
    {
        public int Registration_ID { get; set; }

        [Required(ErrorMessage = "Enter First_Name ")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Enter Last_Name ")]
        public string Last_Name { get; set; }

        public string Middle_Name { get; set; }

        public string Nick_Name { get; set; }

        [Required(ErrorMessage = "Enter Mobile_Number ")]
        [DataType(DataType.PhoneNumber)]
        public int Mobile_Number { get; set; }

        [Required(ErrorMessage = "Enter Birth_Date ")]
        public DateTime Birth_Date { get; set; }

        [Required(ErrorMessage = "Enter Gender ")]
        public string Gender { get; set; }

        public string Image_Path { get; set; }

        [Required(ErrorMessage = "Enter Address ")]
        public string Address { get; set; }

        public string Address1 { get; set; }

        [Required(ErrorMessage = "Enter city ")]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter country ")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Enter State ")]
        public string State { get; set; }

        [Required(ErrorMessage = "Enter Zipcode ")]
        public string Zipcode { get; set; }

        [Required(ErrorMessage = "Enter Email ")]
        [StringLength(16, ErrorMessage = "Must be between 5 and 50 characters", MinimumLength = 5)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression("^[a-zA-Z0-9_.-]+@[a-zA-Z0-9-]+.[a-zA-Z0-9-.]+$", ErrorMessage = "Must be a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter Password ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter Confirm_Password ")]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm_Password { get; set; }
    }
}