using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class ChiTietLopHocPhanAccesser
    {
        ISession session;
        
        public ChiTietLopHocPhanAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertChiTietLopHocPhan(ChiTietLopHocPhan chiTietLopHocPhan)
        {
            session.Merge(chiTietLopHocPhan);
        }
        
        public void UpdateChiTietLopHocPhan(ChiTietLopHocPhan chiTietLopHocPhan)
        {
            session.Update(chiTietLopHocPhan);
        }
        
        public void DeleteChiTietLopHocPhan(ChiTietLopHocPhan chiTietLopHocPhan)
        {
            session.Delete(chiTietLopHocPhan);
        }
        
        public IList<ChiTietLopHocPhan> GetAllChiTietLopHocPhan(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from ChiTietLopHocPhan c");
            IList<ChiTietLopHocPhan> list = query.List<ChiTietLopHocPhan>();
            if (evict)
            {
                foreach (ChiTietLopHocPhan s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public ChiTietLopHocPhan GetChiTietLopHocPhanByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from ChiTietLopHocPhan as c where c.Id= :x");
            query.SetString("x", id);
            ChiTietLopHocPhan s = (ChiTietLopHocPhan)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxChiTietLopHocPhanId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from ChiTietLopHocPhan as c ");
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
