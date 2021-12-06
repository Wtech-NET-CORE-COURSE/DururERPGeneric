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

        User GetUserByID(int id);

        void AddUser(User user);

        User UpdateUser(User user);

        void DeleteUser(int id);
    }
}
