using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskEntities = TaskManager.Domain.Entities.Tasks;

namespace TaskManager.Application.Tasks
{
    class UpdateTaskCommandHandler : IRequestHandler<UpdateTaskCommand>
    {
        private readonly TaskEntities.ITaskRepository _taskRepository;

        public UpdateTaskCommandHandler(TaskEntities.ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public Task<Unit> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var taskEntity = new TaskEntities.Task()
            {
                Id = request.TaskDto.Id,
                Name = request.TaskDto.Name,
                Description = request.TaskDto.Description,
                StatusId = request.TaskDto.StatusId
            };

            _taskRepository.Update(taskEntity);
            return Task.FromResult(Unit.Value);
        }
    }
}
