using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Datalayer.Repository;
namespace Datalayer.Services
{
    class SellRepository : ISellRepository
    {
        private coffeenetEntities db;

        public SellRepository( coffeenetEntities context)
        {
            db = context;
        }

        public bool DeletebySell(int sellid)
        {
            try
            {
                var sell = GetSellbyId(sellid);
                DeleteSell(sell);
                return true;
            }
            catch 
            {
                return false;
            }
            
            

        }

        public bool DeleteSell(sell sell)
        {
            try
            {
                db.Entry(sell).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<sell> GetAllsells()
        {
            return db.sell.ToList();
        }

        public sell GetSellbyId(int id)
        {
            return db.sell.Find(id);
        }

        public bool InsertSell(sell sell)
        {
            try
            {
                db.sell.Add(sell);
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

        public bool UpdateSell(sell sell)
        {
            try
            {
                var local = db.Set<sell>()
                         .Local
                         .FirstOrDefault(f => f.sellid == sell.sellid);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(sell).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
