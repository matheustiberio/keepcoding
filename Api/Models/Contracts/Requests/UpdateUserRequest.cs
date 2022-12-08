﻿namespace Api.Models.Contracts.Requests
{
    public record UpdateUserRequest
    {
        public string Name { get; init; } = string.Empty;

        public string Username { get; init; } = string.Empty;

        public string Email { get; init; } = string.Empty;
    }
}
