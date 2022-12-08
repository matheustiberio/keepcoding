using Api.Services;
using FastEndpoints;
using Microsoft.AspNetCore.Authorization;

namespace Api.Endpoints.UsersEndpoint
{
    [HttpGet("users/{id}"), AllowAnonymous]
    public class GetById : EndpointWithoutRequest
    {
        private readonly UserService _userService;

        public GetById(UserService userService)
        {
            _userService = userService;
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            int userId = Route<int>("id")!;

            var user = _userService.GetUserById(userId);

            if (user == null)
            {
                await SendNotFoundAsync();
                return;
            }

            await SendOkAsync(user);
        }
    }
}
