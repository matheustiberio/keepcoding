using Api.Models.Contracts.Requests;
using Api.Models.Entities;
using Api.Repositories;

namespace Api.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User CreateUser(CreateUserRequest request)
        {
            if (UserAlreadyExists(request))
            {
                return null;
            }

            var newUser = new User(request);

            return _userRepository.Create(newUser);
        }

        public User? GetUserById(int id)
        {
            return _userRepository.GetById(id);
        }

        public User UpdateUser(int userId, UpdateUserRequest request)
        {
            var user = GetUserById(userId);

            if (user == null)
            {
                return null;
            }

            var editedUser = new User(request)
            {
                Id = userId
            };

            return _userRepository.Update(editedUser);
        }

        private bool UserAlreadyExists(CreateUserRequest request) => _userRepository.Exists(request.Email, request.Username);
    }
}
