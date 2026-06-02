using MediatR;
using System;

namespace SmartTask.Application.Features.Tasks.Commands
{
    public class CreateTaskCommand : IRequest<Guid>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Status { get; set; }

        public int Priority { get; set; }

        public DateTime? DueDate { get; set; }

        public Guid ProjectId { get; set; }

        public Guid? AssignedUserId { get; set; }
    }
}