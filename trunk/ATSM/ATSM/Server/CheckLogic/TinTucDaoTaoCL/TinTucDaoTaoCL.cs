using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using log4net;
using NHibernate;
namespace JVL
{
    public class TinTucDaoTaoCL
    {
        private readonly ILog logger = LogManager.GetLogger(typeof(TinTucDaoTaoCL).Name);
        private ISession Session = SessionFactory.GetNewSession();
        public TinTucDaoTaoCL()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
        public TinTucDaoTaoWSI CallCheckLogic(TinTucDaoTaoWSI wsi)
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
        public TinTucDaoTaoWSI CheckSaveObject(TinTucDaoTaoWSI wsi)
        {
        if (String.IsNullOrEmpty(wsi.TinTucDaoTao))
        {
            wsi.WsiError.Add("TinTucDaoTao must is not null or empty");
            wsi.IsWsiError = "true";
        }
        if (String.IsNullOrEmpty(wsi.TheLoaiTin))
        {
            wsi.WsiError.Add("TheLoaiTin must is not null or empty");
            wsi.IsWsiError = "true";
        }
        if (String.IsNullOrEmpty(wsi.CanBoGiaoVien))
        {
            wsi.WsiError.Add("CanBoGiaoVien must is not null or empty");
            wsi.IsWsiError = "true";
        }
        if (String.IsNullOrEmpty(wsi.ChucVu))
        {
            wsi.WsiError.Add("ChucVu must is not null or empty");
            wsi.IsWsiError = "true";
        }
            return wsi;
        }
        public TinTucDaoTaoWSI CheckDeleteObject(TinTucDaoTaoWSI wsi)
        {
            return wsi;
        }
        public TinTucDaoTaoWSI CheckSelectObject(TinTucDaoTaoWSI wsi)
        {
            return wsi;
        }
    }
}
