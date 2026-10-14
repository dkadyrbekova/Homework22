using GenericsHomework;
using System;
using System.Collections.Generic;
using System.Text;

namespace task2
{
    public class UserRepository : Repository<User>
    {
        public User GetByEmail(string email)
        {
            foreach (User user in _items)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }
            return null;
        }
    }
}