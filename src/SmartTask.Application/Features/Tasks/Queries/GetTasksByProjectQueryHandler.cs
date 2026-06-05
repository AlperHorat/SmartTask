using MediatR;
using SmartTask.Application.Features.Tasks.DTOs;
using SmartTask.Application.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SmartTask.Application.Features.Tasks.Queries
{
    public class GetTasksByProjectQueryHandler
        : IRequestHandler<GetTasksByProjectQuery, List<TaskDto>>
    {
        private readonly ITaskRepository _taskRepository;

        public GetTasksByProjectQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<TaskDto>> Handle(
            GetTasksByProjectQuery request,
            CancellationToken cancellationToken)
        {
            var tasks = await _taskRepository.GetByProjectIdAsync(request.ProjectId);

            return tasks.Select(x => new TaskDto
            {
                Id = x.Id,
                Title = x.Title,
                Description = x.Description,
                Status = (int)x.Status,
                Priority = x.Priority,
                DueDate = x.DueDate,
                ProjectId = x.ProjectId,
                AssignedUserId = x.AssignedUserId
            }).ToList();
        }
    }
}