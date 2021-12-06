using Durur.Modules.Generic.Entities.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Durur.Modules.Business.Abstract
{
    public interface IJobServices
    {
        Task<IEnumerable<Job>> GetJobsAsync();

        Task<Job> GetJobByID(int id);

        Task AddJobAsync(Job job);

        Job UpdateJob(Job jobToUpdate,Job job);

        void RemoveJob(int id);

        void RemoveJob(Job job);
    }
}
