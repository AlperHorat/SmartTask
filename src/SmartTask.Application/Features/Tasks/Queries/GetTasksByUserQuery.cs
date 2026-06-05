using MediatR;
using SmartTask.Application.Features.Tasks.DTOs;
using System;
using System.Collections.Generic;

namespace SmartTask.Application.Features.Tasks.Queries
{
    public class GetTasksByUserQuery : IRequest<List<TaskDto>>
    {
        public Guid UserId { get; set; }
    }
}