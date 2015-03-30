using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class NganhAccesser
    {
        ISession session;
        
        public NganhAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertNganh(Nganh nganh)
        {
            session.Merge(nganh);
        }
        
        public void UpdateNganh(Nganh nganh)
        {
            session.Update(nganh);
        }
        
        public void DeleteNganh(Nganh nganh)
        {
            session.Delete(nganh);
        }
        
        public IList<Nganh> GetAllNganh(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from Nganh c");
            IList<Nganh> list = query.List<Nganh>();
            if (evict)
            {
                foreach (Nganh s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public Nganh GetNganhByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from Nganh as c where c.Id= :x");
            query.SetString("x", id);
            Nganh s = (Nganh)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxNganhId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from Nganh as c ");
            try
            {
                return (int)query.UniqueResult();
            }
            catch
            {
                return 0;
            }
        }
        
    }
}
