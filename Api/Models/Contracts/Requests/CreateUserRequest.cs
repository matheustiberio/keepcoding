﻿namespace Api.Models.Contracts.Requests
{
    public record CreateUserRequest
    {

        public string Name { get; init; } = string.Empty;

        public string Username { get; init; } = string.Empty;

        public string Email { get; init; } = string.Empty;

        public string Password { get; init; } = string.Empty;
    }
}
