using SmartTask.Domain.Common;
using SmartTask.Domain.Enums;
using System;
using System.Collections.Generic;

namespace SmartTask.Domain.Entities
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public TaskStatus Status { get; set; }
        public int Priority { get; set; }

        public DateTime? DueDate { get; set; }

        public Guid ProjectId { get; set; }
        public Project Project { get; set; }

        public Guid? AssignedUserId { get; set; }
        public User AssignedUser { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}