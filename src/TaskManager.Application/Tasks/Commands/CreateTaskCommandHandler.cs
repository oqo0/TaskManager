using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskEntities = TaskManager.Domain.Entities.Tasks;

namespace TaskManager.Application.Tasks
{
    class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand>
    {
        private readonly TaskEntities.ITaskRepository _taskRepository;

        public CreateTaskCommandHandler(TaskEntities.ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public Task<Unit> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = new TaskEntities.Task()
            {
                Name = request.TaskDto.Name,
                Description = request.TaskDto.Description,
                StatusId = request.TaskDto.StatusId
            };

            _taskRepository.Add(task);

            return Task.FromResult(Unit.Value);
        }
    }
}
