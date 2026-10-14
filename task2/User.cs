using task2;

namespace GenericsHomework
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public User() { }

        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }
    }
}