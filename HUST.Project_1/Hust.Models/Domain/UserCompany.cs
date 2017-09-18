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
        public string UserID { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FirstName { get; set; }
        public DateTime? DateBorn { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ProfilePhoto { get; set; }
        public DateTime? TimeToStartWorking { get; set; }
        public string LogUser { get; set; }
        public DateTime? UserCreatedDate { get; set; }
        public string StatusID { get; set; }
        public string JobPositionID { get; set; }
    }
}
