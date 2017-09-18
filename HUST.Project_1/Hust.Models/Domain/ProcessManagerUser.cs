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
        public string UserID { get; set; }
        public string ProjectID { get; set; }
        public string JobPositionID { get; set; }
    }
}
