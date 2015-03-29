using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
namespace JVL
{
    public class TheLoaiTinAccesser
    {
        ISession session;
        
        public TheLoaiTinAccesser(ISession session)
        {
            this.session = session;
        }
        
        public void InsertTheLoaiTin(TheLoaiTin theLoaiTin)
        {
            session.Merge(theLoaiTin);
        }
        
        public void UpdateTheLoaiTin(TheLoaiTin theLoaiTin)
        {
            session.Update(theLoaiTin);
        }
        
        public void DeleteTheLoaiTin(TheLoaiTin theLoaiTin)
        {
            session.Delete(theLoaiTin);
        }
        
        public IList<TheLoaiTin> GetAllTheLoaiTin(Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from TheLoaiTin c");
            IList<TheLoaiTin> list = query.List<TheLoaiTin>();
            if (evict)
            {
                foreach (TheLoaiTin s in list)
                {
                    session.Evict(s);
                }
            }
            return list;
        }
        
        public TheLoaiTin GetTheLoaiTinByMatlt(String id, Boolean evict)
        {
            IQuery query = session.CreateQuery("select c from TheLoaiTin as c where c.Matlt= :x");
            query.SetString("x", id);
            TheLoaiTin s = (TheLoaiTin)query.UniqueResult();
            if (evict)
            {
                session.Evict(s);
            }
            return s;
        }
        
        public int GetMaxTheLoaiTinId()
        {
            IQuery query = session.CreateQuery("select Max(c.Id) from TheLoaiTin as c ");
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
