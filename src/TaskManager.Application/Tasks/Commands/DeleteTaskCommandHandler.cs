using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskEntities = TaskManager.Domain.Entities.Tasks;

namespace TaskManager.Application.Tasks
{
    class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand>
    {
        private readonly TaskEntities.ITaskRepository _taskRepository;

        public DeleteTaskCommandHandler(TaskEntities.ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public Task<Unit> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
        {
            _taskRepository.Remove(request.Id);
            return Task.FromResult(Unit.Value);
        }
    }
}
