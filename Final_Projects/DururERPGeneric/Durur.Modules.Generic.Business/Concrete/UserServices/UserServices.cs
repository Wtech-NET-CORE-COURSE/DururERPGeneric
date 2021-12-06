using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class UserServices : IUserServices
    {
        public Task AddUserAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveUser(User user)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User userToUpdate, User user)
        {
            throw new NotImplementedException();
        }
    }
}
