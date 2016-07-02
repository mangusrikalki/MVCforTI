namespace MVCforTI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("qns")]
    public partial class qn
    {
        public int id { get; set; }

        public int? groupNum { get; set; }

        [StringLength(50)]
        public string groupName { get; set; }

        public int? questionTypeNum { get; set; }

        [StringLength(50)]
        public string questionType { get; set; }

        public string question { get; set; }

        public string option1 { get; set; }

        public string option2 { get; set; }

        public string option3 { get; set; }

        public string option4 { get; set; }

        public string option5 { get; set; }

        public string answer { get; set; }

        public int? answerOption { get; set; }
    }
}
