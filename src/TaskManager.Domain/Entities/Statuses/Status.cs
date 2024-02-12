using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Common;

namespace TaskManager.Domain.Entities.Statuses
{
    class Status : IEntity<long>
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
