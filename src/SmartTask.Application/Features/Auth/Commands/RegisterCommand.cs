using MediatR;
using System;

namespace SmartTask.Application.Features.Auth.Commands
{
    public class RegisterCommand : IRequest<Guid>
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}