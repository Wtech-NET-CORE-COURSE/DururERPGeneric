using Durur.Modules.Business.Abstract;
using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Generic.Business.Concrete
{
    public class JobServices : IJobServices
    {
        public Task AddJobAsync(Job job)
        {
            throw new NotImplementedException();
        }

        public Task<Job> GetJobByID(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Job>> GetJobsAsync()
        {
            throw new NotImplementedException();
        }

        public void RemoveJob(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveJob(Job job)
        {
            throw new NotImplementedException();
        }

        public Job UpdateJob(Job jobToUpdate, Job job)
        {
            throw new NotImplementedException();
        }
    }
}
