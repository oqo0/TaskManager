using System;
using System.Collections.Generic;
using System.Text;
using TaskManager.Domain.Entities.Tasks;
using System.Linq;

namespace TaskManager.Infrastructure.Data.Repositories
{
    class TaskRepository : ITaskRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TaskRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Task data)
        {
            _dbContext.Tasks.Add(data);
        }

        public IList<Task> GetAll()
        {
            return _dbContext.Tasks.ToList();
        }

        public Task GetById(long id)
        {
            return _dbContext.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public void Remove(long id)
        {
            var task = GetById(id);

            if (task is null)
                return;

            _dbContext.Remove(task);
            _dbContext.SaveChanges();
        }

        public void Update(Task data)
        {
            var task = GetById(data.Id);

            if (task is null)
                return;

            task.Name = data.Name;
            task.Description = data.Description;
            task.StatusId = data.StatusId;

            _dbContext.Remove(task);
            _dbContext.SaveChanges();
        }
    }
}
