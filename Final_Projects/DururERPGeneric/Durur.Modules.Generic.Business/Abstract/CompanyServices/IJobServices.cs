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

        Job GetJobByID(int id);

        void AddJob(Job job);

        void DeleteJob(int id);

        Job UpdateJob(Job job);
    }
}
