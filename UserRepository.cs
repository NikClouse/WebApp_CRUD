using System.Collections.Generic;
using WebApp_Test_CRUD.Models;

namespace WebApp_Test_CRUD
{
    public class UserRepository
    {
        private List<User> _users = new List<User>();

        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User GetById(int id)
        {
            return _users.Find(user => user.Id == id);
        }

        public void Add(User user)
        {
            user.Id = _users.Count + 1;
            _users.Add(user);
        }

        public void Update(User user)
        {
            var userInList = _users.Find(u => u.Id == user.Id);
            userInList.FirstName = user.FirstName;
            userInList.LastName = user.LastName;
            userInList.Email = user.Email;
        }

        public void Delete(int id)
        {
            var user = GetById(id);
            _users.Remove(user);
        }
    }
}
