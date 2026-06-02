using MediatR;
using SmartTask.Application.Features.Projects.DTOs;
using System.Collections.Generic;

namespace SmartTask.Application.Features.Projects.Queries
{
    public class GetAllProjectsQuery : IRequest<List<ProjectDto>>
    {
    }
}