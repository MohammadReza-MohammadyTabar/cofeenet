using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer.Repository;
using Datalayer.Services;
namespace DataLayer.Context
{
    public class UnitOfWork:IDisposable
    {
        private coffeenetEntities db = new coffeenetEntities();
        private ITypeRepository _typeRepository;
        public ITypeRepository TypeRepository {
            get
            {
                if (_typeRepository==null)
                {
                    _typeRepository = new TypeRepository(db);
                }
                return _typeRepository;
            }

        }
        private IPaymentmethodeRepository _paymentmethodeRepository;
        public IPaymentmethodeRepository PaymentmethodeRepository {
            get
            {
                if (_paymentmethodeRepository == null)
                {
                    _paymentmethodeRepository = new PaymentmethodeRepository(db);
                }
                return _paymentmethodeRepository;
            }

        }
        private ISellRepository _sellRepository;
        public ISellRepository SellRepository {
            get
            {
                if (_sellRepository == null)
                {
                    _sellRepository = new SellRepository(db);
                }
                return _sellRepository;
            }

        }
        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
