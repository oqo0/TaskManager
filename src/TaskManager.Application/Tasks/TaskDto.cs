using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.Tasks
{
    class TaskDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long StatusId { get; set; }
    }
}
