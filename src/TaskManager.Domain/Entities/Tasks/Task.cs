using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Common;
using TaskManager.Domain.Entities.Statuses;

namespace TaskManager.Domain.Entities.Tasks
{
    public class Task : IEntity<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public long StatusId { get; set; }
    }
}
