using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TaskManager.Domain.Entities.Statuses;

namespace TaskManager.Application.Statuses
{
    class GetAllStatusesQueryHandler : IRequestHandler<GetAllStatusesQuery, IList<Status>>
    {
        private readonly IStatusRepository _statusRepository;

        public GetAllStatusesQueryHandler(IStatusRepository statusRepository)
        {
            _statusRepository = statusRepository;
        }

        public Task<IList<Status>> Handle(GetAllStatusesQuery request, CancellationToken cancellationToken)
        {
            var statuses = _statusRepository.GetAll();

            return Task.FromResult(statuses);
        }
    }
}
