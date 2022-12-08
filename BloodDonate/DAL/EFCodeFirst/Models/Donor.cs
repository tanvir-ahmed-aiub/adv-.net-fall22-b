using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFCodeFirst.Models
{
    public class Donor
    {

        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [ForeignKey("Group")]
        public int GrpId { get; set; }

        public virtual Group Group { get; set; }
    }
}
