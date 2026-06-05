using MediatR;
using SmartTask.Application.Features.Tasks.DTOs;
using System;
using System.Collections.Generic;

namespace SmartTask.Application.Features.Tasks.Queries
{
    public class GetTasksByProjectQuery : IRequest<List<TaskDto>>
    {
        public Guid ProjectId { get; set; }
    }
}