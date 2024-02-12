using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.Tasks
{
    class CreateTaskCommand : IRequest
    {
        public TaskDto TaskDto { get; set; }
    }
}
