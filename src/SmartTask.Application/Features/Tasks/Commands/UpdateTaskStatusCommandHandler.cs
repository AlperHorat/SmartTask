using MediatR;
using SmartTask.Application.Interfaces;
using SmartTask.Domain.Enums;
using System;
using System.Threading;
using System.Threading.Tasks;
using TaskStatus = SmartTask.Domain.Enums.TaskStatus;

namespace SmartTask.Application.Features.Tasks.Commands
{
    public class UpdateTaskStatusCommandHandler
        : IRequestHandler<UpdateTaskStatusCommand, bool>
    {
        private readonly ITaskRepository _taskRepository;

        public UpdateTaskStatusCommandHandler(
            ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        public async Task<bool> Handle(
            UpdateTaskStatusCommand request,
            CancellationToken cancellationToken)
        {
            var task = await _taskRepository.GetByIdAsync(request.TaskId);

            if (task == null)
            {
                throw new Exception("Task not found.");
            }

            var newStatus = (TaskStatus)request.NewStatus;

            if (!IsValidTransition(task.Status, newStatus))
            {
                throw new Exception(
                    $"Invalid status transition: {task.Status} -> {newStatus}");
            }

            task.Status = newStatus;

            await _taskRepository.UpdateAsync(task);

            return true;
        }

        private bool IsValidTransition(
            TaskStatus currentStatus,
            TaskStatus newStatus)
        {
            return currentStatus switch
            {
                TaskStatus.Todo =>
                    newStatus == TaskStatus.InProgress,

                TaskStatus.InProgress =>
                    newStatus == TaskStatus.Done,

                TaskStatus.Done =>
                    false,

                _ => false
            };
        }
    }
}