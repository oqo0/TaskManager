using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.Tasks
{
    public class AddOrUpdateTaskCommand : IRequest
    {
        public TaskDto TaskDto { get; set; }
    }
}
