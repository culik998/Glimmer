using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Glimmer.Models
{
    public class Category
    {
        public Category()
        {
            PostCategories = new HashSet<PostCategory>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<PostCategory> PostCategories { get; set; }
    }
}
