using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class LopHocPhanSinhVienAccesser
    {
        ISession session;
        
        public LopHocPhanSinhVienAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertLopHocPhanSinhVien(LopHocPhanSinhVien lopHocPhanSinhVien)
        {
            session.Merge(lopHocPhanSinhVien);
        }
        
        public void UpdateLopHocPhanSinhVien(LopHocPhanSinhVien lopHocPhanSinhVien)
        {
            session.Update(lopHocPhanSinhVien);
        }
        
        public void DeleteLopHocPhanSinhVien(LopHocPhanSinhVien lopHocPhanSinhVien)
        {
            session.Delete(lopHocPhanSinhVien);
        }
        
        public IList<LopHocPhanSinhVien> GetAllLopHocPhanSinhVien(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from LopHocPhanSinhVien c");
            IList<LopHocPhanSinhVien> list = query.List<LopHocPhanSinhVien>();
            if (evict)
            {
                foreach (LopHocPhanSinhVien s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public LopHocPhanSinhVien GetLopHocPhanSinhVienByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from LopHocPhanSinhVien as c where c.Id= :x");
            query.SetString("x", id);
            LopHocPhanSinhVien s = (LopHocPhanSinhVien)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxLopHocPhanSinhVienId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from LopHocPhanSinhVien as c ");
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
