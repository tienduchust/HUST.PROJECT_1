namespace Hust.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserCompany")]
    public partial class UserCompany
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string UserID { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string MiddleName { get; set; }

        [StringLength(20)]
        public string FirstName { get; set; }

        public DateTime? DateBorn { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [StringLength(20)]
        public string Username { get; set; }

        [StringLength(20)]
        public string Password { get; set; }

        [StringLength(100)]
        public string ProfilePhoto { get; set; }

        public DateTime? TimeToStartWorking { get; set; }

        [StringLength(250)]
        public string LogUser { get; set; }

        public DateTime? UserCreatedDate { get; set; }
        [StringLength(100)]
        public string StatusID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string JobPositionID { get; set; }
    }
}
