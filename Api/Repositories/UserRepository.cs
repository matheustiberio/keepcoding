using Api.Models.Entities;

namespace Api.Repositories
{
    public class UserRepository
    {
        public Dictionary<int, User> Users { get; } = new()
        {
            {
                1,
                new()
                {
                    Username = "admin",
                    Email = "admin@admin.com",
                    Name = "Ademir",
                    Password = "awesomepass123"
                }
            },
            {
                2,
                new()
                {
                    Id = 2,
                    Username = "mod",
                    Email = "mod@mod.com",
                    Name = "Mod",
                    Password = "outstandingpass123",
                }
            }
        };

        public User Create(User user)
        {
            if (user.Name == "t")
                return null;

            user.Id = Users.Count + 1;

            Users.Add(user.Id, user);

            return user;
        }

        public User? GetById(int id)
        {
            return Users.FirstOrDefault(x => x.Key == id).Value;
        }

        public User Update(User user)
        {
            Users.Remove(user.Id);
            Users.Add(user.Id, user);

            return user;
        }

        public bool Exists(string email, string username)
        {
            return Users.FirstOrDefault(x => x.Value.Email == email || x.Value.Username == username).Value != null;
        }
    }
}
