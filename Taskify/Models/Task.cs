using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Taskify.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int Priority { get; set; }
        public bool Finished { get; set; }
    }
}