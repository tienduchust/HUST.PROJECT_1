namespace Hust.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status
    {
        public string StatusID { get; set; }
        public string Description { get; set; }
        public string Notification { get; set; }
        public bool? IsActive { get; set; }
    }
}
