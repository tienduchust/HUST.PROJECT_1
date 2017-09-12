namespace Hust.Bussiness.EntityFrameWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StaffMember")]
    public partial class StaffMember
    {
        public long ID { get; set; }

        [StringLength(20)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string MiddleName { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        public DateTime? DateBorn { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(50)]
        public string ProfilePhoto { get; set; }

        public DateTime? TimeToStartWorking { get; set; }

        public int? ProjectCodeDoing { get; set; }

        public int? ProjectCodeCompleted { get; set; }

        public int? GroupID { get; set; }

        public bool? Status { get; set; }
    }
}
