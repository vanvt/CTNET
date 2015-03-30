using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class SinhVienEntityAccesser
    {
        ISession session;
        
        public SinhVienEntityAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertSinhVienEntity(SinhVienEntity sinhVienEntity)
        {
            session.Merge(sinhVienEntity);
        }
        
        public void UpdateSinhVienEntity(SinhVienEntity sinhVienEntity)
        {
            session.Update(sinhVienEntity);
        }
        
        public void DeleteSinhVienEntity(SinhVienEntity sinhVienEntity)
        {
            session.Delete(sinhVienEntity);
        }
        
        public IList<SinhVienEntity> GetAllSinhVienEntity(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from SinhVienEntity c");
            IList<SinhVienEntity> list = query.List<SinhVienEntity>();
            if (evict)
            {
                foreach (SinhVienEntity s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public SinhVienEntity GetSinhVienEntityByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from SinhVienEntity as c where c.Id= :x");
            query.SetString("x", id);
            SinhVienEntity s = (SinhVienEntity)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxSinhVienEntityId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from SinhVienEntity as c ");
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
