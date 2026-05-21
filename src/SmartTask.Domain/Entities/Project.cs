using SmartTask.Domain.Common;
using System;
using System.Collections.Generic;

namespace SmartTask.Domain.Entities
{
    public class Project : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid OwnerId { get; set; }
        public User Owner { get; set; }

        public ICollection<TaskItem> Tasks { get; set; }
    }
}