using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glimmer.Models
{
    public class Post
    {
        public Post()
        {
            PostCategories = new HashSet<PostCategory>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<PostCategory> PostCategories { get; set; }
    }
}
