using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CardGenerator.Models
{
    public class License
    {
        public License()
        {
            Licenses = new HashSet<License>();
        }

        public int Id { get; set; }

        public string Number { get; set; }

        public Software Software { get; set; }

        [ForeignKey("Software")]
        public int SoftwareId { get; set; }

        public  ICollection<License> Licenses { get; set; }
    }
}
