using MediatR;
using SmartTask.Application.Interfaces;
using SmartTask.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SmartTask.Application.Features.Tasks.Commands
{
    public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, Guid>
    {
        private readonly ITaskRepository _taskRepository;

        public CreateTaskCommandHandler(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<Guid> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var task = new TaskItem
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                Description = request.Description,
                Status = (Domain.Enums.TaskStatus)request.Status,
                Priority = request.Priority,
                DueDate = request.DueDate,
                ProjectId = request.ProjectId,
                AssignedUserId = request.AssignedUserId
            };

            await _taskRepository.AddAsync(task);

            return task.Id;
        }
    }
}