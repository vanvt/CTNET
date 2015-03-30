using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class LopSinhHoatEntityAccesser
    {
        ISession session;
        
        public LopSinhHoatEntityAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertLopSinhHoatEntity(LopSinhHoatEntity lopSinhHoatEntity)
        {
            session.Merge(lopSinhHoatEntity);
        }
        
        public void UpdateLopSinhHoatEntity(LopSinhHoatEntity lopSinhHoatEntity)
        {
            session.Update(lopSinhHoatEntity);
        }
        
        public void DeleteLopSinhHoatEntity(LopSinhHoatEntity lopSinhHoatEntity)
        {
            session.Delete(lopSinhHoatEntity);
        }
        
        public IList<LopSinhHoatEntity> GetAllLopSinhHoatEntity(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from LopSinhHoatEntity c");
            IList<LopSinhHoatEntity> list = query.List<LopSinhHoatEntity>();
            if (evict)
            {
                foreach (LopSinhHoatEntity s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public LopSinhHoatEntity GetLopSinhHoatEntityByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from LopSinhHoatEntity as c where c.Id= :x");
            query.SetString("x", id);
            LopSinhHoatEntity s = (LopSinhHoatEntity)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxLopSinhHoatEntityId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from LopSinhHoatEntity as c ");
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
