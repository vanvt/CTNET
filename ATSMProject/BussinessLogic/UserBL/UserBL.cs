using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using log4net;
using NHibernate;
namespace JVL
{
    public class UserBL
    {
        private readonly ILog logger = LogManager.GetLogger(typeof(UserBL).Name);
        private ISession Session = SessionFactory.GetNewSession();
        public UserBL()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
        public UserWSI CallBussinessLogic(UserWSI wsi)
        {
            switch (wsi.Mode)
            {
                case "SAV":
                    wsi = SaveObject(wsi);
                    return wsi;
                case "DEL":
                    wsi = DeleteObject(wsi);
                    return wsi;
                case "SEL":
                    wsi = SelectObject(wsi);
                    return wsi;
            }
            return wsi;
        }
        public UserWSI SaveObject(UserWSI wsi)
        {
            //declare variable at here
            ITransaction tx = Session.BeginTransaction();
            try
            {
                //Insert code at here
                tx.Commit();
            }
            catch (Exception ex)
            {
                wsi.IsWsiError = "true";
                wsi.WsiError.Add(ex.ToString());
                tx.Rollback();
            }
            return wsi;
        }
        public UserWSI DeleteObject(UserWSI wsi)
        {
            //declare variable at here
            ITransaction tx = Session.BeginTransaction();
            try
            {
                //Insert code at here
                tx.Commit();
            }
            catch (Exception ex)
            {
                wsi.IsWsiError = "true";
                wsi.WsiError.Add(ex.ToString());
                tx.Rollback();
            }
            return wsi;
        }
        public UserWSI SelectObject(UserWSI wsi)
        {
            //declare variable at here
            try
            {
                //Insert code at here
            }
            catch (Exception ex)
            {
                wsi.IsWsiError = "true";
                wsi.WsiError.Add(ex.ToString());
            }
            return wsi;
        }
    }
}
