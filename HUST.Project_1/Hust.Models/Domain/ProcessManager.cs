namespace Hust.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessManager")]
    public partial class ProcessManager
    {
        [Key]
        public int ID { get; set; }
        public string ProcessName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string Description { get; set; }
        public string JobPositionID { get; set; }
        public string StatusID { get; set; }
    }
}
