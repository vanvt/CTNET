using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class HocPhanAccesser
    {
        ISession session;
        
        public HocPhanAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertHocPhan(HocPhan hocPhan)
        {
            session.Merge(hocPhan);
        }
        
        public void UpdateHocPhan(HocPhan hocPhan)
        {
            session.Update(hocPhan);
        }
        
        public void DeleteHocPhan(HocPhan hocPhan)
        {
            session.Delete(hocPhan);
        }
        
        public IList<HocPhan> GetAllHocPhan(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from HocPhan c");
            IList<HocPhan> list = query.List<HocPhan>();
            if (evict)
            {
                foreach (HocPhan s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public HocPhan GetHocPhanByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from HocPhan as c where c.Id= :x");
            query.SetString("x", id);
            HocPhan s = (HocPhan)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxHocPhanId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from HocPhan as c ");
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
