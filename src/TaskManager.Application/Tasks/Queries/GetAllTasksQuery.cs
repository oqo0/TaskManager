using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Entities.Tasks;

namespace TaskManager.Application.Tasks
{
    class GetAllTasksQuery : IRequest<IList<Task>>
    {
    }
}
