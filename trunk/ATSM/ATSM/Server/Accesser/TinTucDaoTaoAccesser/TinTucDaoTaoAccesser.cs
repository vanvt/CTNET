using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class TinTucDaoTaoAccesser
    {
        ISession session;
        
        public TinTucDaoTaoAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertTinTucDaoTao(TinTucDaoTao tinTucDaoTao)
        {
            session.Merge(tinTucDaoTao);
        }
        
        public void UpdateTinTucDaoTao(TinTucDaoTao tinTucDaoTao)
        {
            session.Update(tinTucDaoTao);
        }
        
        public void DeleteTinTucDaoTao(TinTucDaoTao tinTucDaoTao)
        {
            session.Delete(tinTucDaoTao);
        }
        
        public IList<TinTucDaoTao> GetAllTinTucDaoTao(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from TinTucDaoTao c");
            IList<TinTucDaoTao> list = query.List<TinTucDaoTao>();
            if (evict)
            {
                foreach (TinTucDaoTao s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }

        public IList<TinTucDaoTao> GetNewestTinTucDaoTao(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from TinTucDaoTao c");
            IList<TinTucDaoTao> list = query.List<TinTucDaoTao>();
            if (evict)
            {
                foreach (TinTucDaoTao s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }

        public TinTucDaoTao GetTinTucDaoTaoByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from TinTucDaoTao as c where c.Id= :x");
            query.SetString("x", id);
            TinTucDaoTao s = (TinTucDaoTao)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxTinTucDaoTaoId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from TinTucDaoTao as c ");
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
