using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskEntities = TaskManager.Domain.Entities.Tasks;

namespace TaskManager.Application.Tasks
{
    class AddOrUpdateTaskCommandHandler : IRequestHandler<AddOrUpdateTaskCommand>
    {
        private readonly TaskEntities.ITaskRepository _taskRepository;

        public AddOrUpdateTaskCommandHandler(TaskEntities.ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public Task<Unit> Handle(AddOrUpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = _taskRepository.GetById(request.TaskDto.Id);

            var newTask = new TaskEntities.Task()
            {
                Name = request.TaskDto.Name,
                Description = request.TaskDto.Description,
                StatusId = request.TaskDto.StatusId
            };

            if (task is null)
            {
                _taskRepository.Add(newTask);
            }
            else
            {
                newTask.Id = task.Id;
                _taskRepository.Update(newTask);
            }

            return Task.FromResult(Unit.Value);
        }
    }
}
