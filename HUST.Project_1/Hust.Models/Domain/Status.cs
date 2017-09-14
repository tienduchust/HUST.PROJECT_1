using System;
using System.Collections.Generic;

namespace Hust.Models.Models
{
    public class Status
    {
        public Guid StatusId { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    

        public List<JobPosition> Jobs { get; set; }
    }
}