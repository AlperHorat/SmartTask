using MediatR;
using SmartTask.Application.Features.Projects.DTOs;
using SmartTask.Application.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SmartTask.Application.Features.Projects.Queries
{
    public class GetAllProjectsQueryHandler
        : IRequestHandler<GetAllProjectsQuery, List<ProjectDto>>
    {
        private readonly IProjectRepository _projectRepository;

        public GetAllProjectsQueryHandler(
            IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        public async Task<List<ProjectDto>> Handle(
            GetAllProjectsQuery request,
            CancellationToken cancellationToken)
        {
            var projects = await _projectRepository.GetAllAsync();

            return projects.Select(x => new ProjectDto
            {
                Id = x.Id,
                Name = x.Name,
                Description = x.Description,
                OwnerId = x.OwnerId,
                CreatedDate = x.CreatedAt
            }).ToList();
        }
    }
}