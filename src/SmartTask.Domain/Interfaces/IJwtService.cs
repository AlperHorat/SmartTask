using SmartTask.Domain.Entities;

namespace SmartTask.Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateToken(User user);
    }
}