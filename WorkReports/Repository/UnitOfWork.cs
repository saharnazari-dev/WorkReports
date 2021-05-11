using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkReports.Data;
using WorkReports.IRepository;

namespace WorkReports.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DatabaseContext _context;
        private IGenericRepository<User> _user;
        private IGenericRepository<WorkReport> _workReport;
        private IGenericRepository<PersonWork> _personWork;
        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<User> users => _user ??= new GenericRepository<User>(_context);
        public IGenericRepository<WorkReport> workReports => _workReport ??= new GenericRepository<WorkReport>(_context);
        public IGenericRepository<PersonWork> personWork=> _personWork??= new GenericRepository<PersonWork>(_context);



        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
