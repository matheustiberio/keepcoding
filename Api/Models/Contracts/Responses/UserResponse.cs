using Api.Models.Entities;

namespace Api.Models.Contracts.Responses
{
    public class UserResponse
    {
        public int Id { get; set; }

        public UserResponse(User user)
        {
            Id = user.Id;
        }
    }
}
