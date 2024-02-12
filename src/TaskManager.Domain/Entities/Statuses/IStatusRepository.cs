using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Common;

namespace TaskManager.Domain.Entities.Statuses
{
    public interface IStatusRepository : IRepository<Status, long>
    {
        public IList<Status> GetAll();
    }
}
