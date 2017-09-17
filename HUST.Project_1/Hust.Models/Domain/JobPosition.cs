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
        [StringLength(100)]
        public string JobPositionID { get; set; }

        [StringLength(250)]
        public string JobName { get; set; }

        [StringLength(100)]
        public string StatusID { get; set; }
    }
}
