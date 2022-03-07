using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datalayer;
using DataLayer;
using Datalayer.Repository;
namespace Datalayer.Services
{
    class TypeRepository : ITypeRepository
    {
        private coffeenetEntities db;

        public TypeRepository(coffeenetEntities context)
        {
            db = context;
        }
        public bool DeletebyType(int typeid)
        {
            try
            {
                var type = GetTypebyId(typeid);
                DeleteType(type);
                return true;
            }
            catch
            {
                return false;
            }

        }

        

        public bool UpdateType(type type)
        {
            try
            {
                var local = db.Set<type>()
                         .Local
                         .FirstOrDefault(f => f.typeid == type.typeid);
                if (local != null)
                {
                    db.Entry(local).State = EntityState.Detached;
                }
                db.Entry(type).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }
    

        public bool DeleteType(type type)
        {
            try
            {
                db.Entry(type).State = EntityState.Deleted;
                return true;
            }
            catch 
            {
                return false;
            }
        }

        public List<type> GetAllType()
        {
            return db.type.ToList();
        }

        public type GetTypebyId(int id)
        {
            return db.type.Find(id);
        }

        public bool InsertType(type type)
        {
            try
            {
                db.type.Add(type);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<type> GetTypesByFilter(string Parameter)
        {
            return db.type.Where(t => t.typename.Contains(Parameter)).ToList();
        }
    }

        
    
}
