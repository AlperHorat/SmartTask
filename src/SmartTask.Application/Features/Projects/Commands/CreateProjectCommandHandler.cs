using MediatR;
using SmartTask.Application.Interfaces;
using SmartTask.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SmartTask.Application.Features.Projects.Commands
{
    public class CreateProjectCommandHandler
        : IRequestHandler<CreateProjectCommand, Guid>
    {
        private readonly IProjectRepository _projectRepository;

        public CreateProjectCommandHandler(
            IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<Guid> Handle(
            CreateProjectCommand request,
            CancellationToken cancellationToken)
        {
            var project = new Project
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                OwnerId = request.OwnerId,
                CreatedAt = DateTime.UtcNow
            };

            await _projectRepository.AddAsync(project);

            return project.Id;
        }
    }
}