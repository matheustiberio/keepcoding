using Api.Models.Entities;

namespace Api.Models.Contracts.Responses
{
    public class CreateUserResponse : UserResponse
    {
        public CreateUserResponse(User user) : base(user) { }
    }
}
