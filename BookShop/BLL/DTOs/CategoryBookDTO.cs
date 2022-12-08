using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CategoryBookDTO : CategoryDTO
    {
        public List<BookDTO> Books { get; set; }
        public CategoryBookDTO()
        {
            Books = new List<BookDTO>();
        }
    }
}
