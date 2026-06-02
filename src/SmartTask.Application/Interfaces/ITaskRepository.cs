using SmartTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartTask.Application.Interfaces
{
    public interface ITaskRepository
    {
        Task<TaskItem> GetByIdAsync(Guid id);

        Task<List<TaskItem>> GetAllAsync();

        Task AddAsync(TaskItem task);
    }
}