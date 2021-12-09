using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class UserServices : IUserServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddUserAsync(User user)
        {
            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.CommitAsync();
        }

        public Task<User> GetUserByIDAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveUser(User user)
        {
            throw new NotImplementedException();
        }

        public User UpdateUser(User userToUpdate, User user)
        {
            throw new NotImplementedException();
        }
    }
}
