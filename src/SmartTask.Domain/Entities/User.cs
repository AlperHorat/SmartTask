using SmartTask.Domain.Common;
using System.Collections.Generic;

namespace SmartTask.Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public ICollection<Project> Projects { get; set; }
    }
}