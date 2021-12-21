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
            //await _unitOfWork.CommitAsync();
        }

        public async Task<User> GetUserByIDAsync(int id)
        {
            return await _unitOfWork.Users.GetByIDAsync(id);
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            return await _unitOfWork.Users.GetAllAsync();
        }

        public async Task RemoveUser(int id)
        {
            _unitOfWork.Users.Remove(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveUser(User user)
        {
            _unitOfWork.Users.Remove(user);
            await _unitOfWork.CommitAsync();
        }

        public User UpdateUser(User userToUpdate, User user)
        {
            throw new NotImplementedException();
        }
    }
}
