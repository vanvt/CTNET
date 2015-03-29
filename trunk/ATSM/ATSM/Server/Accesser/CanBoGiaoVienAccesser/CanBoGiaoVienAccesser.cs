using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class CanBoGiaoVienAccesser
    {
        ISession session;
        
        public CanBoGiaoVienAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertCanBoGiaoVien(CanBoGiaoVien canBoGiaoVien)
        {
            session.Merge(canBoGiaoVien);
        }
        
        public void UpdateCanBoGiaoVien(CanBoGiaoVien canBoGiaoVien)
        {
            session.Update(canBoGiaoVien);
        }
        
        public void DeleteCanBoGiaoVien(CanBoGiaoVien canBoGiaoVien)
        {
            session.Delete(canBoGiaoVien);
        }
        
        public IList<CanBoGiaoVien> GetAllCanBoGiaoVien(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from CanBoGiaoVien c");
            IList<CanBoGiaoVien> list = query.List<CanBoGiaoVien>();
            if (evict)
            {
                foreach (CanBoGiaoVien s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public CanBoGiaoVien GetCanBoGiaoVienByMacbgv(String maCbgv, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from CanBoGiaoVien as c where c.Macbgv= :x");
            query.SetString("x", maCbgv);
            CanBoGiaoVien s = (CanBoGiaoVien)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxCanBoGiaoVienId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from CanBoGiaoVien as c ");
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
