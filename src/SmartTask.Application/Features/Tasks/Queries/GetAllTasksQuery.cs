using MediatR;
using SmartTask.Application.Features.Tasks.DTOs;
using System.Collections.Generic;

namespace SmartTask.Application.Features.Tasks.Queries
{
    public class GetAllTasksQuery : IRequest<List<TaskDto>>
    {
    }
}