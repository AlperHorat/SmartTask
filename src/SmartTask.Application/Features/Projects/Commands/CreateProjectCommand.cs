using MediatR;
using System;

namespace SmartTask.Application.Features.Projects.Commands
{
    public class CreateProjectCommand : IRequest<Guid>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Guid OwnerId { get; set; }
    }
}