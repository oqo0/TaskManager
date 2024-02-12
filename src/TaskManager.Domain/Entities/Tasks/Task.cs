using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Common;

namespace TaskManager.Domain.Entities.Tasks
{
    class Task : IEntity<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long StatusId { get; set; }
    }
}
