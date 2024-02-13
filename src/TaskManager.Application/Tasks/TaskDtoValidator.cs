using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskManager.Application.Tasks
{
    public class TaskDtoValidator : AbstractValidator<TaskDto>
    {
        public TaskDtoValidator()
        {
            RuleFor(c => c.Name)
                .NotNull()
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(50);
            RuleFor(c => c.Description)
                .NotNull()
                .MaximumLength(255);
        }
    }
}
