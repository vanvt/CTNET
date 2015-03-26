using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using log4net;
using NHibernate;
namespace JVL
{
    public class LoginUserBL
    {
        private readonly ILog logger = LogManager.GetLogger(typeof(LoginUserBL).Name);
        private ISession Session = SessionFactory.GetNewSession();
        public LoginUserBL()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
        public LoginUserWSI CallBussinessLogic(LoginUserWSI wsi)
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
        public LoginUserWSI SaveObject(LoginUserWSI wsi)
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
        public LoginUserWSI DeleteObject(LoginUserWSI wsi)
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
        public LoginUserWSI SelectObject(LoginUserWSI wsi)
        {
            //declare variable at here
            LoginUser loginUser = new LoginUser();
            LoginUserAccesser loginUserAccesser = new LoginUserAccesser(Session);
            try
            {
                if (wsi.LoginUser != null)
                {
                    wsi.LoginUser = loginUserAccesser.CheckLogin(wsi.LoginUser.LoginUserId,wsi.LoginUser.Password,true);
                }
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
