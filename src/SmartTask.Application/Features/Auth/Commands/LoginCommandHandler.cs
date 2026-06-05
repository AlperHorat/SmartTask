using MediatR;
using SmartTask.Application.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SmartTask.Application.Features.Auth.Commands
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
    {
        private readonly IUserRepository _userRepository;
        private readonly IJwtService _jwtService;

        public LoginCommandHandler(
            IUserRepository userRepository,
            IJwtService jwtService)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
        }

        public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByEmailAsync(request.Email);

            if (user == null)
                throw new Exception("Invalid credentials");

            if (user.PasswordHash != request.Password)
                throw new Exception("Invalid credentials");

            var token = _jwtService.GenerateToken(user);

            return token;
        }
    }
}