using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class LopHocPhanAccesser
    {
        ISession session;
        
        public LopHocPhanAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertLopHocPhan(LopHocPhan lopHocPhan)
        {
            session.Merge(lopHocPhan);
        }
        
        public void UpdateLopHocPhan(LopHocPhan lopHocPhan)
        {
            session.Update(lopHocPhan);
        }
        
        public void DeleteLopHocPhan(LopHocPhan lopHocPhan)
        {
            session.Delete(lopHocPhan);
        }
        
        public IList<LopHocPhan> GetAllLopHocPhan(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from LopHocPhan c");
            IList<LopHocPhan> list = query.List<LopHocPhan>();
            if (evict)
            {
                foreach (LopHocPhan s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public LopHocPhan GetLopHocPhanByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from LopHocPhan as c where c.Id= :x");
            query.SetString("x", id);
            LopHocPhan s = (LopHocPhan)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxLopHocPhanId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from LopHocPhan as c ");
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
