using FluentValidation.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.Tasks
{
    public class AddOrUpdateTaskCommand : IRequest<ValidationResult>
    {
        public TaskDto TaskDto { get; set; }
    }
}
