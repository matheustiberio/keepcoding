using Api.Models.Contracts.Requests;
using Api.Services;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace Api.Endpoints.UsersEndpoint
{
    [HttpPut("users/{id}"), AllowAnonymous]
    public class Update : Endpoint<UpdateUserRequest>
    {
        private readonly UserService _userService;

        public Update(UserService userService)
        {
            _userService = userService;
        }

        public override async Task HandleAsync(UpdateUserRequest request, CancellationToken ct)
        {
            var userId = Route<int>("id");

            var user = _userService.UpdateUser(userId, request);

            if (user == null)
            {
                await SendErrorsAsync();
                return;
            }

            await SendOkAsync(user);
        }
    }
}
