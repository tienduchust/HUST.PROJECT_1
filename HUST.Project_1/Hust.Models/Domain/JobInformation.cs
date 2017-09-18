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
        public string JobInformationID { get; set; }
        public string JobDoneBy { get; set; }
        public DateTime? DateOfInvoice { get; set; }
        public string JobStatus { get; set; }
    }
}
