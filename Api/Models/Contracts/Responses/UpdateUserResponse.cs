using Api.Models.Entities;

namespace Api.Models.Contracts.Responses
{
    public class UpdateUserResponse : UserResponse
    {
        public UpdateUserResponse(User user) : base(user) { }
    }
}
