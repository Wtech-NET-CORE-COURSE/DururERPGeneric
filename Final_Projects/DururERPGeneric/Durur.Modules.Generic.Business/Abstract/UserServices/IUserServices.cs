using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface IUserServices
    {
        Task<IEnumerable<User>> GetUsersAsync();

        Task<User> GetUserByIDAsync(int id);

        Task AddUserAsync(User user);

        User UpdateUser(User userToUpdate, User user);

        void RemoveUser(int id);
        void RemoveUser(User user);
    }
}
