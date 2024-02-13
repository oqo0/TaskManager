using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Entities.Statuses;

namespace TaskManager.Application.Statuses
{
    public class GetStatusByIdQuery : IRequest<Status>
    {
        public long Id { get; set; }

        public GetStatusByIdQuery(long id)
        {
            Id = id;
        }
    }
}
