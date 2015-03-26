using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class LoginUserAccesser
    {
        ISession session;
        
        public LoginUserAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertLoginUser(LoginUser loginUser)
        {
            session.Merge(loginUser);
        }
        
        public void UpdateLoginUser(LoginUser loginUser)
        {
            session.Update(loginUser);
        }
        
        public void DeleteLoginUser(LoginUser loginUser)
        {
            session.Delete(loginUser);
        }
        
        public IList<LoginUser> GetAllLoginUser(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from LoginUser c");
            IList<LoginUser> list = query.List<LoginUser>();
            if (evict)
            {
                foreach (LoginUser s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public LoginUser GetLoginUserByID(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from LoginUser as c where c.Id= :x");
            query.SetString("x", id);
            LoginUser s = (LoginUser)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxLoginUserId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from LoginUser as c ");
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
