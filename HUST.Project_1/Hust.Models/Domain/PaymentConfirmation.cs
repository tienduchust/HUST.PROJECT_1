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
        public string PaymentID { get; set; }
        public string ProjectID { get; set; }
        public string UserID { get; set; }
        public DateTime? DatePayment { get; set; }
        public string AmountOfPayment { get; set; }
        public string Notification { get; set; }
        public string StatusID { get; set; }
    }
}
