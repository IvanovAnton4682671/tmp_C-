using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Classes
{
    class UsersList
    {
        List<User> users;

        public UsersList()
        {
            this.users = new List<User>();
        }

        public void addToList(User user)
        {
            users.Add(user);
        }

        public int returnCount()
        {
            return users.Count;
        }

        public User returnUser(int userId)
        {
            return users[userId];
        }

        public string printInformationFromList()
        {
            string tmp = "";
            foreach (User user in users)
            {
                tmp += user.printUserInformation();
            }
            return tmp;
        }
    }
}
