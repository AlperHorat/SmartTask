using MediatR;
using SmartTask.Application.Features.Users.Commands;
using SmartTask.Application.Interfaces;
using SmartTask.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SmartTask.Application.Features.Users.Handlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            };

            await _userRepository.AddAsync(user);

            return user.Id;
        }
    }
}