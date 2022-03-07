using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Datalayer.Repository;

namespace Datalayer.Services
{
    class PaymentmethodeRepository : IPaymentmethodeRepository
    {
        private coffeenetEntities db;

        public PaymentmethodeRepository(coffeenetEntities context)
        {
            db = context;
        }
        public bool DeletebyId(int id)
        {
            try
            {
                var paymentmethode = GetPaymentmethodebyId(id);
                DeletePaymentmethode(paymentmethode);
                return true;
            }
            catch 

            {
                return false;
            }
        }

        public bool DeletePaymentmethode(paymentmethode paymentmethode)
        {
            try
            {
                db.Entry(paymentmethode).State = EntityState.Deleted;
                return true;
            }
            catch

            {
                return false;
            }
        }

        public List<paymentmethode> GetAllPaymentmethode()
        {
            return db.paymentmethode.ToList();
        }

        public paymentmethode GetPaymentmethodebyId(int id)
        {
            return db.paymentmethode.Find(id);
        }

        public bool InsertPaymentmethode(paymentmethode paymentmethode)
        {
            try
            {
                db.paymentmethode.Add(paymentmethode);
                return true;
            }
            catch

            {
                return false;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public bool UpdatePaymentmethodel(paymentmethode paymentmethode)
        {
            try
            {
                var local = db.Set<paymentmethode>()
                         .Local
                         .FirstOrDefault(f => f.paymentmethodeid == paymentmethode.paymentmethodeid);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(paymentmethode).State = EntityState.Modified;
                return true;
            }
            catch

            {
                return false;
            }
        }
    }
}
