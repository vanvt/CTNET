using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class KhoaAccesser
    {
        ISession session;
        
        public KhoaAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertKhoa(Khoa khoa)
        {
            session.Merge(khoa);
        }
        
        public void UpdateKhoa(Khoa khoa)
        {
            session.Update(khoa);
        }
        
        public void DeleteKhoa(Khoa khoa)
        {
            session.Delete(khoa);
        }
        
        public IList<Khoa> GetAllKhoa(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from Khoa c");
            IList<Khoa> list = query.List<Khoa>();
            if (evict)
            {
                foreach (Khoa s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public Khoa GetKhoaByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from Khoa as c where c.Id= :x");
            query.SetString("x", id);
            Khoa s = (Khoa)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxKhoaId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from Khoa as c ");
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
