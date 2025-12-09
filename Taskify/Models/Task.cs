using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Taskify.Models
{
    [Table("tasks")]
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; } = default!;

        [Column(TypeName = "text")]
        public string Description { get; set; } = default!;
        public int Priority { get; set; }
        public bool Finished { get; set; }
    }
}