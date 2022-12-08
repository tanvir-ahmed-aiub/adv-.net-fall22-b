using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFCodeFirst.Models
{
    public class Group
    {
        public Group()
        {
            this.Donors = new HashSet<Donor>();
        }

        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Donor> Donors { get; set; }
    }
}
