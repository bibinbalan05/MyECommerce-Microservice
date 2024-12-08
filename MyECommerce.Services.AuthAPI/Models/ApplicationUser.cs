﻿using Microsoft.AspNetCore.Identity;

namespace MyECommerce.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
