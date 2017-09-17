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
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(250)]
        public string ProcessName { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(100)]
        public string CreatedBy { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string JobPositionID { get; set; }

        [StringLength(100)]
        public string StatusID { get; set; }
    }
}
