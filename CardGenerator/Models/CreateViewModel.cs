using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGenerator.Models
{
    public class CreateViewModel
    {
        public ICollection<Software> Softwares { get; set; }
        
        public License license { get; set; }
    }
}
