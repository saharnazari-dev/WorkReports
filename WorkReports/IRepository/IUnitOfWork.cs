using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkReports.Data;

namespace WorkReports.IRepository
{
   public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<User> users { get; }
        IGenericRepository<WorkReport> workReports { get; }
        IGenericRepository<PersonWork> personWork { get; }

        Task Save();
    }
}
