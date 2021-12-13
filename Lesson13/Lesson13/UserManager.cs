using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
   public class UserManager
    {
        private User[] _users = new User[10];
        private int _currentPosition = 0;

        public void RegisterNewUser(User user)
        {
            _users[_currentPosition] = user;
            _currentPosition++;
        }

        public void EditUser(User user)
        {
            var oldUser = GetUserById(user.id);
            oldUser.Name = user.Name;
        }
        public User GetUserById(int id)
        {
            foreach (var user in _users)
            {
                if (user.id == id)
                    return user;
            }
            return null;
        }
    }
}
