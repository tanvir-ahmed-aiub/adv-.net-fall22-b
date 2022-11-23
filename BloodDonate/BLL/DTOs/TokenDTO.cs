using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TokenDTO
    {
        public int Id { get; set; }
        public string TKey { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.DateTime> ExpirationTime { get; set; }
        public string Username { get; set; }
    }
}
