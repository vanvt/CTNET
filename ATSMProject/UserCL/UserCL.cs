using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using log4net;
using NHibernate;
namespace JVL
{
    public class UserCL
    {
        private readonly ILog logger = LogManager.GetLogger(typeof(UserCL).Name);
        private ISession Session = SessionFactory.GetNewSession();
        public UserCL()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
        public UserWSI CallCheckLogic(UserWSI wsi)
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
        public UserWSI CheckSaveObject(UserWSI wsi)
        {
            return wsi;
        }
        public UserWSI CheckDeleteObject(UserWSI wsi)
        {
            return wsi;
        }
        public UserWSI CheckSelectObject(UserWSI wsi)
        {
            return wsi;
        }
    }
}
