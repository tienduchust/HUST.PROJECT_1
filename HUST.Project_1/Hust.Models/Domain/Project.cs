namespace Hust.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Project")]
    public partial class Project
    {
        [Key]
        public string ProjectID { get; set; }
        public string UserID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectStatus { get; set; }
        public DateTime? ProcessCreatedDate { get; set; }
        public DateTime? ProcessDeadline { get; set; }
        public string StatusID { get; set; }
    }
}
