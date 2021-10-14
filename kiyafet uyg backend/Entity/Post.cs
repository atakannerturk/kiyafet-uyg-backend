using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace kiyafet_uyg_backend.Entity
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        public String Description { get; set; }
        public DateTime Upload { get; set; }
        public int TotalLikes { get; set; }
        public int TotalDislikes { get; set; }
        public bool IsDeleted { get; set; }

    }
}
