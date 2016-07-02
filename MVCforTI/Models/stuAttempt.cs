namespace MVCforTI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("stuAttempts")]
    public partial class stuAttempt
    {
        public int id { get; set; }

        public int stuId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? attemptDate { get; set; }

        public string qns { get; set; }

        public string ans { get; set; }

        public string correctAns { get; set; }

        public int? correctAnsTotal { get; set; }
    }
}
