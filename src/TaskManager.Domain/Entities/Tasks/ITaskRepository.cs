using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Common;

namespace TaskManager.Domain.Entities.Tasks
{
    interface ITaskRepository : IRepository<Task, long>
    {
        public void Add(Task data);
        public IList<Task> GetAll();
        public void Update(Task data);
        public void Remove(long id);
    }
}
