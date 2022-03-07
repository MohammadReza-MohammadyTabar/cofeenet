using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace Datalayer.Repository
{
    public interface IPaymentmethodeRepository
    {
        List<paymentmethode> GetAllPaymentmethode();
        paymentmethode GetPaymentmethodebyId(int id);
        bool InsertPaymentmethode(paymentmethode paymentmethode);
        bool UpdatePaymentmethodel(paymentmethode paymentmethode);
        bool DeletePaymentmethode(paymentmethode paymentmethode);
        bool DeletebyId(int id);
        void Save();
    }
}
