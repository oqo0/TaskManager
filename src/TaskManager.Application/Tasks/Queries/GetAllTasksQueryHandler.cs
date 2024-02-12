using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskEntities = TaskManager.Domain.Entities.Tasks;

namespace TaskManager.Application.Tasks
{
    class GetAllTasksQueryHandler : IRequestHandler<GetAllTasksQuery, IList<TaskEntities.Task>>
    {
        private readonly TaskEntities.ITaskRepository _taskRepository;

        public GetAllTasksQueryHandler(TaskEntities.ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public Task<IList<TaskEntities.Task>> Handle(GetAllTasksQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_taskRepository.GetAll());
        }
    }
}
