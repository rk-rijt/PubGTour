﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Asp.MVCCoreWeb.Models
{
    public class Employee 
    {

        [Key]
        public int EmployeeID { get; set; }

        public string userid { get; set; }

        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "This field are required")]
        [MaxLength(10)]
        [RegularExpression(@"^\(?([0-9]{10})$", ErrorMessage = "Not a valid phone number")]
        public string Phone { get; set; }


        [DisplayName("Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field are required")]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password and confirm-Password should be same")]
        public string ConfirmPassword { get; set; }

        [DisplayName("PubG UserName")]
        public string PubG_UserName { get; set; }


        [DisplayName("Email")]
        [EmailAddress]
        public string Email { get; set; }

    }
}
