using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using log4net;
using NHibernate;
namespace JVL
{
    public class LoginUserCL
    {
        private readonly ILog logger = LogManager.GetLogger(typeof(LoginUserCL).Name);
        private ISession Session = SessionFactory.GetNewSession();
        public LoginUserCL()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
        public LoginUserWSI CallCheckLogic(LoginUserWSI wsi)
        {
            switch (wsi.Mode)
            {
                case "SAV":
                wsi = CheckSaveObject(wsi);
                return wsi;
                case "DEL":
                wsi = CheckDeleteObject(wsi);
                return wsi;
                case "SEL":
                wsi = CheckSelectObject(wsi);
                return wsi;
            }
            return wsi;
        }
        public LoginUserWSI CheckSaveObject(LoginUserWSI wsi)
        {
            return wsi;
        }
        public LoginUserWSI CheckDeleteObject(LoginUserWSI wsi)
        {
            return wsi;
        }
        public LoginUserWSI CheckSelectObject(LoginUserWSI wsi)
        {
            return wsi;
        }
    }
}
