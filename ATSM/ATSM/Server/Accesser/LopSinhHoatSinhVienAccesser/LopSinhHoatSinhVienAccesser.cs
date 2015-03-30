using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class LopSinhHoatSinhVienAccesser
    {
        ISession session;
        
        public LopSinhHoatSinhVienAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertLopSinhHoatSinhVien(LopSinhHoatSinhVien lopSinhHoatSinhVien)
        {
            session.Merge(lopSinhHoatSinhVien);
        }
        
        public void UpdateLopSinhHoatSinhVien(LopSinhHoatSinhVien lopSinhHoatSinhVien)
        {
            session.Update(lopSinhHoatSinhVien);
        }
        
        public void DeleteLopSinhHoatSinhVien(LopSinhHoatSinhVien lopSinhHoatSinhVien)
        {
            session.Delete(lopSinhHoatSinhVien);
        }
        
        public IList<LopSinhHoatSinhVien> GetAllLopSinhHoatSinhVien(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from LopSinhHoatSinhVien c");
            IList<LopSinhHoatSinhVien> list = query.List<LopSinhHoatSinhVien>();
            if (evict)
            {
                foreach (LopSinhHoatSinhVien s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public LopSinhHoatSinhVien GetLopSinhHoatSinhVienByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from LopSinhHoatSinhVien as c where c.Id= :x");
            query.SetString("x", id);
            LopSinhHoatSinhVien s = (LopSinhHoatSinhVien)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxLopSinhHoatSinhVienId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from LopSinhHoatSinhVien as c ");
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
