using SmartTask.Domain.Common;
using System;

namespace SmartTask.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Content { get; set; }

        public Guid TaskItemId { get; set; }
        public TaskItem TaskItem { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}