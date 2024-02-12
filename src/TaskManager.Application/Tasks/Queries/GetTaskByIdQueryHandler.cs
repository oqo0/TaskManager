using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskEntities = TaskManager.Domain.Entities.Tasks;

namespace TaskManager.Application.Tasks
{
    class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQuery, TaskEntities.Task>
    {
        private readonly TaskEntities.ITaskRepository _taskRepository;

        public GetTaskByIdQueryHandler(TaskEntities.ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;     
        }

        public Task<TaskEntities.Task> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
        {
            var task = _taskRepository.GetById(request.Id);
            return Task.FromResult(task);
        }
    }
}