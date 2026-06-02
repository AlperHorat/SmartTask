using System;

namespace SmartTask.Application.Features.Projects.DTOs
{
    public class ProjectDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Guid OwnerId { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}