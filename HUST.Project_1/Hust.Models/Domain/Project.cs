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
        [Column(Order = 0)]
        [StringLength(100)]
        public string ProjectID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string UserID { get; set; }

        [StringLength(250)]
        public string ProjectName { get; set; }

        [StringLength(100)]
        public string ProjectStatus { get; set; }

        public DateTime? ProcessCreatedDate { get; set; }

        public DateTime? ProcessDeadline { get; set; }

        [StringLength(100)]
        public string StatusID { get; set; }
    }
}
