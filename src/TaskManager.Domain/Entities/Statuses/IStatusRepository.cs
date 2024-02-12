using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Common;

namespace TaskManager.Domain.Entities.Statuses
{
    interface IStatusRepository : IRepository<Status, long>
    {
        public IList<Status> GetAll();
    }
}
