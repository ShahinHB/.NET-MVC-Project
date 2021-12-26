using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Backend_Project.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string CommenterName { get; set; }

        public string Email { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        
        [ForeignKey("Blog")]
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
