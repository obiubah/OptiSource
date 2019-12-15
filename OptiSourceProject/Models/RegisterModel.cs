﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OptiSourceProject.Models
{
    public class RegisterModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string EmailAddress { get; set; }
    }
}
