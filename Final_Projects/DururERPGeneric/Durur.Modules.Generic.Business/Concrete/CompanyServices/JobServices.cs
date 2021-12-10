using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using Durur.Modules.Generic.Entities.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class JobServices : IJobServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public JobServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddJobAsync(Job job)
        {
            await _unitOfWork.Jobs.AddAsync(job);
            await _unitOfWork.CommitAsync();
        }

        public async Task<Job> GetJobByID(int id)
        {
            var job = await _unitOfWork.Jobs.GetByIDAsync(id);
            return job;
        }

        public async Task<IEnumerable<Job>> GetJobsAsync()
        {
            var jobs = await _unitOfWork.Jobs.GetAllAsync();
            return jobs;
        }

        public async Task RemoveJob(int id)
        {
            _unitOfWork.Jobs.Remove(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveJob(Job job)
        {
            _unitOfWork.Jobs.Remove(job);
            await _unitOfWork.CommitAsync();
        }

        public Job UpdateJob(Job jobToUpdate, Job job)
        {
            throw new NotImplementedException();
        }
    }
}
