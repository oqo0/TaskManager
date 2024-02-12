using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Common;
using TaskManager.Domain.Entities.Tasks;

namespace TaskManager.Domain.Entities.Statuses
{
    public class Status : IEntity<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IList<Task> Tasks { get; set; }
    }
}
