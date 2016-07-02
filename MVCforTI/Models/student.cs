namespace MVCforTI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("student")]
    public partial class student
    {
        public int id { get; set; }

        [StringLength(50)]
        [Required]
        public string firstName { get; set; }

        [StringLength(50)]
        [Required]
        public string lastName { get; set; }

        [StringLength(50)]
        public string midName { get; set; }

        [Required]
        [StringLength(50)]
        public string userId { get; set; }

        [Required]
        [StringLength(50)]
        public string pswd { get; set; }

        [Required]
        [StringLength(50)]
        [Compare("pswd",ErrorMessage = "Passwords should match")]
        [NotMapped]
        public string confirmPswd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? firstLogin { get; set; }
    }
}
