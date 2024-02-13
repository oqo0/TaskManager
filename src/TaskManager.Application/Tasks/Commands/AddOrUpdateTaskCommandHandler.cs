using FluentValidation;
using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskEntities = TaskManager.Domain.Entities.Tasks;

namespace TaskManager.Application.Tasks
{
    class AddOrUpdateTaskCommandHandler : IRequestHandler<AddOrUpdateTaskCommand, ValidationResult>
    {
        private readonly TaskEntities.ITaskRepository _taskRepository;
        private readonly IValidator<TaskDto> _taskValidator;

        public AddOrUpdateTaskCommandHandler(
            TaskEntities.ITaskRepository taskRepository,
            IValidator<TaskDto> taskValidator)
        {
            _taskRepository = taskRepository;
            _taskValidator = taskValidator;
        }

        public Task<ValidationResult> Handle(AddOrUpdateTaskCommand request, CancellationToken cancellationToken)
        {
            var validationResult = _taskValidator.Validate(request.TaskDto);
            if (!validationResult.IsValid)
            {
                return Task.FromResult(validationResult);
            }

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

            return Task.FromResult(validationResult);
        }
    }
}
