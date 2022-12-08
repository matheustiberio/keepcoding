using Api.Models.Contracts.Requests;
using System;

namespace Api.Models.Entities
{
    public class User : Entity
    {
        public string Name { get; set; } = string.Empty;

        public string Username { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public User(CreateUserRequest request)
        {
            Name = request.Name;
            Username = request.Username;
            Email = request.Email;
            Password = request.Password;
        }

        public User(UpdateUserRequest request)
        {
            Name = request.Name;
            Username = request.Username;
            Email = request.Email;
        }

        public User() { }
    }
}
