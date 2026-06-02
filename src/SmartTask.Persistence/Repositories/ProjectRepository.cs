using Microsoft.EntityFrameworkCore;
using SmartTask.Application.Interfaces;
using SmartTask.Domain.Entities;
using SmartTask.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartTask.Persistence.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly ApplicationDbContext _context;

        public ProjectRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Project> GetByIdAsync(Guid id)
        {
            return await _context.Projects
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Project>> GetAllAsync()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task AddAsync(Project project)
        {
            await _context.Projects.AddAsync(project);
            await _context.SaveChangesAsync();
        }
    }
}