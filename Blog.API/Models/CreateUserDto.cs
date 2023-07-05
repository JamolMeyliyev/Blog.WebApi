﻿using Blog.API.Entities;

namespace Blog.API.Models
{
    public class CreateUserDto
    {
        
        public required string Username { get; set; }
        
        public required string Name { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        
    }
}
