using System;
using System.Collections.Generic;
using SH.Core;

namespace Hust.Models.Models
{
    public class Project : BaseEntity
    {
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public Guid UserId { get; set; }
        public List<User> Users { get; set; }
      
    }
}
