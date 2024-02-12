using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskManager.Domain.Entities.Statuses;

namespace TaskManager.Application.Statuses
{
    class GetStatusByIdQueryHandler : IRequestHandler<GetStatusByIdQuery, Status>
    {
        private readonly IStatusRepository _statusRepository;

        public GetStatusByIdQueryHandler(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        public Task<Status> Handle(GetStatusByIdQuery request, CancellationToken cancellationToken)
        {
            var status = _statusRepository.GetById(request.Id);
            return Task.FromResult(status);
        }
    }
}
