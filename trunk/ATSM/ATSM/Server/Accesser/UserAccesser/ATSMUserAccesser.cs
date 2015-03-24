using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class ATSMUserAccesser
    {
        ISession session;
        
        public ATSMUserAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertATSMUser(ATSMUser aTSMUser)
        {
            session.Merge(aTSMUser);
        }
        
        public void UpdateATSMUser(ATSMUser aTSMUser)
        {
            session.Update(aTSMUser);
        }
        
        public void DeleteATSMUser(ATSMUser aTSMUser)
        {
            session.Delete(aTSMUser);
        }
        
        public IList<ATSMUser> GetAllATSMUser(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from ATSMUser c");
            IList<ATSMUser> list = query.List<ATSMUser>();
            if (evict)
            {
                foreach (ATSMUser s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public ATSMUser GetATSMUserByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from ATSMUser as c where c.Id= :x");
            query.SetString("x", id);
            ATSMUser s = (ATSMUser)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxATSMUserId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from ATSMUser as c ");
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
