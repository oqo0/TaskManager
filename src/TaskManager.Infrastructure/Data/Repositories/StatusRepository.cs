using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TaskManager.Domain.Entities.Statuses;

namespace TaskManager.Infrastructure.Data.Repositories
{
    class StatusRepository : IStatusRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StatusRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<Status> GetAll()
        {
            return _dbContext.Statuses.ToList();
        }

        public Status GetById(long id)
        {
            return _dbContext.Statuses.FirstOrDefault(s => s.Id == id);
        }
    }
}