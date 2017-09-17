namespace Hust.Models.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaymentConfirmation")]
    public partial class PaymentConfirmation
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string PaymentID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string ProjectID { get; set; }

        [Required]
        [StringLength(100)]
        public string UserID { get; set; }

        public DateTime? DatePayment { get; set; }

        [StringLength(100)]
        public string AmountOfPayment { get; set; }

        [StringLength(250)]
        public string Notification { get; set; }

        [Required]
        [StringLength(100)]
        public string StatusID { get; set; }
    }
}
