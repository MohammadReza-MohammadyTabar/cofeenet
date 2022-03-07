using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace Datalayer.Repository
{
    public interface ITypeRepository
    {
        List<type> GetAllType();
        IEnumerable<type> GetTypesByFilter(string Parameter);
        type GetTypebyId(int id);
        bool InsertType(type type);
        bool UpdateType(type type);
        bool DeleteType(type type);
        bool DeletebyType(int typeid);
        
    }
}
