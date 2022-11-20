using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepo<CLASS,ID>
    {
        void Add(CLASS obj);
        List<CLASS> Get();
        void Edit(CLASS obj);
        CLASS Get(ID id);
        void Delete(ID id);  
    }
}
