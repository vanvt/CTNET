using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class ChucVuAccesser
    {
        ISession session;
        
        public ChucVuAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertChucVu(ChucVu chucVu)
        {
            session.Merge(chucVu);
        }
        
        public void UpdateChucVu(ChucVu chucVu)
        {
            session.Update(chucVu);
        }
        
        public void DeleteChucVu(ChucVu chucVu)
        {
            session.Delete(chucVu);
        }
        
        public IList<ChucVu> GetAllChucVu(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from ChucVu c");
            IList<ChucVu> list = query.List<ChucVu>();
            if (evict)
            {
                foreach (ChucVu s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public ChucVu GetChucVuByMacv(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from ChucVu as c where c.Macv= :x");
            query.SetString("x", id);
            ChucVu s = (ChucVu)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxChucVuId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from ChucVu as c ");
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
