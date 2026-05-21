using MediatR;
using System;

namespace SmartTask.Application.Features.Users.Commands
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}