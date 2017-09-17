namespace Hust.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProcessManagerUser")]
    public partial class ProcessManagerUser
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string UserID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string ProjectID { get; set; }

        [StringLength(100)]
        public string JobPositionID { get; set; }
    }
}
