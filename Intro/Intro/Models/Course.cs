using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Intro.Models
{
    public class Course
    {
        [Required]
        public string Id { get; set; }
        [Required]
        [StringLength(25,ErrorMessage ="Name should not exceeed 25 chars")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Provide name of teacher")]
        [StringLength(25)]
        public string Teacher { get; set; }
    }
}