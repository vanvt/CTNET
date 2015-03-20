using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class UserAccesser
    {
        ISession session;
        
        public UserAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertUser(User user)
        {
            session.Merge(user);
        }
        
        public void UpdateUser(User user)
        {
            session.Update(user);
        }
        
        public void DeleteUser(User user)
        {
            session.Delete(user);
        }
        
        public IList<User> GetAllUser(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from User c");
            IList<User> list = query.List<User>();
            if (evict)
            {
                foreach (User s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public User GetUserByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from User as c where c.Id= :x");
            query.SetString("x", id);
            User s = (User)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxUserId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from User as c ");
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
