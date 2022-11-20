using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CollectionReqDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public string AssignedEmp { get; set; }
        public System.DateTime PrevTime { get; set; }
    }
}
