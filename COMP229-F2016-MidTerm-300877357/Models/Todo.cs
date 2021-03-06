namespace COMP229_F2016_MidTerm_300877357.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Todos")]
    public partial class Todo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TodoId { get; set; }

        [Required]
        [StringLength(50)]
        public string TodoDiscription { get; set; }

        public string TodoNotes { get; set; }

        public bool Completed { get; set; }
    }
}
