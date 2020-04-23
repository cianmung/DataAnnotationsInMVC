using DataAnnotationsInMVC.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationInMVC.Models
{
    public class Employee
    {
        
        public Guid EmployeeId
        {
            get;
            set;
        }
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(30, MinimumLength = 2,
                  ErrorMessage = "Last name should be between 2 and 30 characters")]
        public string LastName
        {
            get;
            set;
        }
        [Range(25, 60, ErrorMessage = "Age must be between 25 and 60")]
        public int Age
        {
            get;
            set;
        }
        [DateRange("01/01/2000", ErrorMessage = "Date of Birth Must be between 01-01-1970 and Current Date")]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth
        {
            get;
            set;
        }
        [MinLength(5, ErrorMessage = "The Address must be at least 5 characters")]
        [MaxLength(25, ErrorMessage = "The Address cannot be more than 25 characters")]
        public string Address
        {
            get;
            set;
        }
        [DataType(DataType.PhoneNumber, ErrorMessage = "Please Enter a valid Phone Number")]
        public string Mobile
        {
            get;
            set;
        }
        [DataType(DataType.PostalCode, ErrorMessage = "Please Enter a valid PIN/ZIP Code")]
        public string PostalCode
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Email id is required")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
                            ErrorMessage = "Please enter a valid email address")]
        public string EmailId
        {
            get;
            set;
        }
        [RegularExpression(@"^(([A-za-z]+[\s]{1}[A-za-z]+)|([A-Za-z]+))$")]
        public string UserName
        {
            get;
            set;
        }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is Required")]
        [Compare("ConfirmPassword", ErrorMessage = "Password and Confirm Password do not match")]
        public string Password
        {
            get;
            set;
        }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Confirm Password is Required")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match")]
        public string ConfirmPassword
        {
            get;
            set;
        }
        [DataType(DataType.Url, ErrorMessage = "Please Enter a valid URL")]
        public string URL
        {
            get;
            set;
        }
    }
}