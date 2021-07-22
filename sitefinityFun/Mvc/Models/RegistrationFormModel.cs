using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sitefinityFun.Mvc.Models
{
    public class RegistrationFormModel
    {
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "UserName is Required.")]
        [DisplayName("Username")]
        public string username { get; set; }
        [Required]
        [DisplayName("Password")]
        public string user_password { get; set; }
        [Required]
        [DisplayName("Password Again")]
        public string user_password2 { get; set; }
        [Required]
        [DisplayName("Full Name")]
        public string full_name { get; set; }
        [Required]
        [DisplayName("Age")]
        public int age { get; set; }
    }
}