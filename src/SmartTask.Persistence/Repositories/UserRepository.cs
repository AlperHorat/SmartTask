using Microsoft.EntityFrameworkCore;
using SmartTask.Application.Interfaces;
using SmartTask.Domain.Entities;
using SmartTask.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SmartTask.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(Guid id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task AddAsync(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}