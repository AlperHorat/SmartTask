using SmartTask.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartTask.Application.Interfaces
{
    public interface IProjectRepository
    {
        Task<Project> GetByIdAsync(Guid id);

        Task<List<Project>> GetAllAsync();

        Task AddAsync(Project project);
    }
}