﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Entities.Statuses;

namespace TaskManager.Application.Statuses
{
    public class GetAllStatusesQuery : IRequest<IList<Status>>
    {
    }
}
