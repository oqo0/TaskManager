using System;
using System.Collections.Generic;
using System.Linq;
using TaskManager.Domain.Entities.Tasks;

namespace TaskManager.Web.Models
{
    public class TasksViewModel
    {
        public IList<Task> Tasks { get; set; }
    }
}
