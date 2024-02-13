using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.Tasks
{
    public class DeleteTaskCommand : IRequest
    {
        public long Id { get; set; }
    }
}
