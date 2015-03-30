using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class ChinhSachAccesser
    {
        ISession session;
        
        public ChinhSachAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertChinhSach(ChinhSach chinhSach)
        {
            session.Merge(chinhSach);
        }
        
        public void UpdateChinhSach(ChinhSach chinhSach)
        {
            session.Update(chinhSach);
        }
        
        public void DeleteChinhSach(ChinhSach chinhSach)
        {
            session.Delete(chinhSach);
        }
        
        public IList<ChinhSach> GetAllChinhSach(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from ChinhSach c");
            IList<ChinhSach> list = query.List<ChinhSach>();
            if (evict)
            {
                foreach (ChinhSach s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public ChinhSach GetChinhSachByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from ChinhSach as c where c.Id= :x");
            query.SetString("x", id);
            ChinhSach s = (ChinhSach)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxChinhSachId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from ChinhSach as c ");
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
