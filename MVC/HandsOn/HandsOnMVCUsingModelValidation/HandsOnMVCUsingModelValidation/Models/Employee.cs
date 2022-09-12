using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCUsingModelValidation.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Enter Id")]
        public string Id { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        [Range(10000,50000,ErrorMessage ="Salary between 10k to 50k")]
        public int Salary { get; set; }
        [EmailAddress(ErrorMessage ="Invalid EmailId")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}",ErrorMessage ="Invalid Mobile No")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Enter Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Enter Password")]
        [RegularExpression("[0-9a-z]{6,8}",ErrorMessage ="Invalid Password format")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password Mismatch")]
        public string ConfirmPassword { get; set; }
    }
}