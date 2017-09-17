namespace Hust.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("JobInformation")]
    public partial class JobInformation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string JobInformationID { get; set; }

        [StringLength(100)]
        public string JobDoneBy { get; set; }

        public DateTime? DateOfInvoice { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string JobStatus { get; set; }
    }
}
