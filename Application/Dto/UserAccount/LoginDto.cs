﻿using System.ComponentModel.DataAnnotations;

namespace Application.Dto
{
    public class LoginDto
    {
        [EmailAddress]
        public string Email { get; set; }

        public string Password { get; set; }
    }
}