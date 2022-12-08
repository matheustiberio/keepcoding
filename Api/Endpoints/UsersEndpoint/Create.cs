using Api.Models.Contracts.Requests;
using Api.Models.Contracts.Responses;
using Api.Services;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using System.Net;

namespace Api.Endpoints.UsersEndpoint
{
    [HttpPost("users"), AllowAnonymous]
    public class Create : Endpoint<CreateUserRequest>
    {
        private readonly UserService _userService;

        public Create(UserService userService)
        {
            _userService = userService;
        }

        public override async Task HandleAsync(CreateUserRequest request, CancellationToken ct)
        {
            var createdUser = _userService.CreateUser(request);

            if (createdUser == null)
            {
                await SendErrorsAsync();
                return;
            }

            var response = new CreateUserResponse(createdUser);

            await SendAsync(response, (int)HttpStatusCode.Created);
        }
    }
}
