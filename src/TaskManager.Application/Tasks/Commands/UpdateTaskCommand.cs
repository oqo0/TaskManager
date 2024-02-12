using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.Tasks
{
    class UpdateTaskCommand : IRequest
    {
        public TaskDto TaskDto { get; set; }
    }
}