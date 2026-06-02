using MediatR;
using SmartTask.Application.Features.Tasks.DTOs;
using SmartTask.Application.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SmartTask.Application.Features.Tasks.Queries
{
    public class GetAllTasksQueryHandler : IRequestHandler<GetAllTasksQuery, List<TaskDto>>
    {
        private readonly ITaskRepository _taskRepository;

        public GetAllTasksQueryHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<List<TaskDto>> Handle(GetAllTasksQuery request, CancellationToken cancellationToken)
        {
            var tasks = await _taskRepository.GetAllAsync();

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