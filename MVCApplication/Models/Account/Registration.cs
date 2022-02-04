using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApplication.Models.Account
{
    public class Registration
    {
        [Required(ErrorMessage ="First Name is required")]
        public string first_name { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string last_name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$",
            ErrorMessage = "Please enter valid Email")]
        public string email { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [DataType(DataType.PhoneNumber)]
        public Int32 mobile_number { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string password { get; set; }

        [Required(ErrorMessage = "Retype Password is required")]
        [Compare("password", ErrorMessage = "Retype password and Password should be same")]
        public string retype_password { get; set; }

        [Required(ErrorMessage = "User Name is required")]
        public string user_name { get; set; }
    }
}