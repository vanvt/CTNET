using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class PhuHuynhAccesser
    {
        ISession session;
        
        public PhuHuynhAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertPhuHuynh(PhuHuynh phuHuynh)
        {
            session.Merge(phuHuynh);
        }
        
        public void UpdatePhuHuynh(PhuHuynh phuHuynh)
        {
            session.Update(phuHuynh);
        }
        
        public void DeletePhuHuynh(PhuHuynh phuHuynh)
        {
            session.Delete(phuHuynh);
        }
        
        public IList<PhuHuynh> GetAllPhuHuynh(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from PhuHuynh c");
            IList<PhuHuynh> list = query.List<PhuHuynh>();
            if (evict)
            {
                foreach (PhuHuynh s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public PhuHuynh GetPhuHuynhByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from PhuHuynh as c where c.Id= :x");
            query.SetString("x", id);
            PhuHuynh s = (PhuHuynh)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxPhuHuynhId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from PhuHuynh as c ");
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
