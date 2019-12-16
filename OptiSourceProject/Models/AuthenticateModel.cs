﻿using System;
using System.ComponentModel.DataAnnotations;

namespace OptiSourceProject.Models
{
    public class AuthenticateModel
    {
        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
