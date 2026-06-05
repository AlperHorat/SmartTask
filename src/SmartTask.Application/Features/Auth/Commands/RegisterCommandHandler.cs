using MediatR;
using SmartTask.Application.Interfaces;
using SmartTask.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SmartTask.Application.Features.Auth.Commands
{
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand, Guid>
    {
        private readonly IUserRepository _userRepository;

        public RegisterCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            var existingUser = await _userRepository.GetByEmailAsync(request.Email);

            if (existingUser != null)
                throw new Exception("User already exists with this email");

            var user = new User
            {
                Id = Guid.NewGuid(),
                FirstName = request.UserName,
                Email = request.Email,
                PasswordHash = request.Password // şimdilik plain, sonra hash ekleyeceğiz
            };

            await _userRepository.AddAsync(user);

            return user.Id;
        }
    }
}