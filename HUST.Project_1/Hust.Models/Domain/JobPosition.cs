namespace Hust.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobPosition")]
    public partial class JobPosition
    {
        [Key]
        public string JobPositionID { get; set; }
        public string JobName { get; set; }

        [StringLength(100)]
        public string StatusID { get; set; }
    }
}
