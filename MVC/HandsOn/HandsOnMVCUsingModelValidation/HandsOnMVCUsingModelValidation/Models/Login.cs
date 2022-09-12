using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMVCUsingModelValidation.Models
{
    public class Login
    {
        [Required(ErrorMessage ="Enter Username")]
        public string Username { get; set; }
        [Required(ErrorMessage ="Enter Password")]
        public string Password { get; set; }   
    }
}