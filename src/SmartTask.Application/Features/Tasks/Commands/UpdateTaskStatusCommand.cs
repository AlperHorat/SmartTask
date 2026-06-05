using MediatR;
using System;

namespace SmartTask.Application.Features.Tasks.Commands
{
    public class UpdateTaskStatusCommand : IRequest<bool>
    {
        public Guid TaskId { get; set; }

        public int NewStatus { get; set; }
    }
}