using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace Datalayer.Repository
{
    public interface ISellRepository
    {
        List<sell> GetAllsells();
        sell GetSellbyId(int id);
        bool InsertSell(sell sell);
        bool UpdateSell(sell sell);
        bool DeleteSell(sell sell);
        bool DeletebySell(int sellid);
        void Save();

    }
}
