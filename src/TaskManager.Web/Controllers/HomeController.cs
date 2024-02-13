using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Models;
using TaskManager.Application.Tasks;
using TaskManager.Web.Models;
using TaskManager.Application.Statuses;
using FluentValidation.Results;
using TaskManager.Models;

namespace TaskManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMediator _mediator;

        public HomeController(
            ILogger<HomeController> logger,
            IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var query = new GetAllTasksQuery();

            var tasksViewModel = new TasksViewModel()
            {
                Tasks = await _mediator.Send(query)
            };

            return View(tasksViewModel);
        }

        public async Task<IActionResult> Add()
        {
            var query = new GetAllStatusesQuery();
            ViewBag.Statuses = await _mediator.Send(query);

            return View();
        }

        public async Task<IActionResult> Message()
        {
            if (TempData["MessageViewModel"] is string messageViewModelJson)
            {
                var messageViewModel = System.Text.Json.JsonSerializer.Deserialize<MessageViewModel>(messageViewModelJson);

                return View(messageViewModel);
            }

            return View();
        }

        public async Task<IActionResult> Update(long id)
        {
            var getTaskByIdQuery = new GetTaskByIdQuery() { Id = id };
            var getAllStatusesQuery = new GetAllStatusesQuery();

            var task = await _mediator.Send(getTaskByIdQuery);

            ViewBag.Statuses = await _mediator.Send(getAllStatusesQuery);
            ViewBag.TaskDto = new TaskDto()
            {
                Id = task.Id,
                Name = task.Name,
                Description = task.Description,
                StatusId = task.StatusId
            };

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Remove(long id)
        {
            var command = new DeleteTaskCommand()
            {
                Id = id
            };

            await _mediator.Send(command);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdate(UpdateTaskViewModel model)
        {
            var command = new AddOrUpdateTaskCommand()
            {
                TaskDto = model.TaskDto
            };

            var result = await _mediator.Send(command);

            if (!result.IsValid)
            {
                var messageViewModel = new MessageViewModel()
                {
                    Problems = result.Errors.Select(e => e.ErrorMessage).ToList()
                };

                TempData["MessageViewModel"] = System.Text.Json.JsonSerializer.Serialize(messageViewModel);
                return RedirectToAction("Message", "Home");
            }

            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
