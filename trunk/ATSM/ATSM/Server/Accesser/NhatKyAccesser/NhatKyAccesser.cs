using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class NhatKyAccesser
    {
        ISession session;
        
        public NhatKyAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertNhatKy(NhatKy nhatKy)
        {
            session.Merge(nhatKy);
        }
        
        public void UpdateNhatKy(NhatKy nhatKy)
        {
            session.Update(nhatKy);
        }
        
        public void DeleteNhatKy(NhatKy nhatKy)
        {
            session.Delete(nhatKy);
        }
        
        public IList<NhatKy> GetAllNhatKy(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from NhatKy c");
            IList<NhatKy> list = query.List<NhatKy>();
            if (evict)
            {
                foreach (NhatKy s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public NhatKy GetNhatKyByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from NhatKy as c where c.Id= :x");
            query.SetString("x", id);
            NhatKy s = (NhatKy)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxNhatKyId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from NhatKy as c ");
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
