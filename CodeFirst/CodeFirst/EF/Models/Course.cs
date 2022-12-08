using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirst.EF.Models
{
    public class Course
    {

        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [ForeignKey("Department")]
        public int OfferedBy { get; set; }
        public virtual Department Department { get; set; }

    }
}