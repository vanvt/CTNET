using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using log4net;
using NHibernate;
namespace JVL
{
    public class TinTucDaoTaoBL
    {
        private readonly ILog logger = LogManager.GetLogger(typeof(TinTucDaoTaoBL).Name);
        private ISession Session = SessionFactory.GetNewSession();
        public TinTucDaoTaoBL()
        {
            log4net.Config.XmlConfigurator.Configure();
        }
        public TinTucDaoTaoWSI CallBussinessLogic(TinTucDaoTaoWSI wsi)
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
        public TinTucDaoTaoWSI SaveObject(TinTucDaoTaoWSI wsi)
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
        public TinTucDaoTaoWSI DeleteObject(TinTucDaoTaoWSI wsi)
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
        public TinTucDaoTaoWSI SelectObject(TinTucDaoTaoWSI wsi)
        {
            //declare variable at here
            TinTucDaoTaoAccesser tinTucDaoTaoAccesser = new TinTucDaoTaoAccesser(Session);
            TheLoaiTin theLoaiTin = null;
            TheLoaiTinAccesser theLoaiTinAccesser = new TheLoaiTinAccesser(Session);
            CanBoGiaoVien canBoGiaoVien = null;
            CanBoGiaoVienAccesser canBoGiaoVienAccesser = new CanBoGiaoVienAccesser(Session);
            ChucVu chucVu = null;
            ChucVuAccesser chucVuAccesser = new ChucVuAccesser(Session);
            List<TinTucDaoTao> listTinTuc = new List<TinTucDaoTao>();
            List<CanBoGiaoVien> listCbgv = new List<CanBoGiaoVien>();
            List<TheLoaiTin> listTheLoaiTin = new List<TheLoaiTin>();
            List<ChucVu> listChucVu = new List<ChucVu>();
            try
            {
                listTinTuc = tinTucDaoTaoAccesser.GetNewestTinTucDaoTao(true).ToList();

                if (listTinTuc.Count > 0)
                {
                    foreach (var tmp in listTinTuc)
                    {
                        canBoGiaoVien = canBoGiaoVienAccesser.GetCanBoGiaoVienByMacbgv(tmp.Macbgv, true);
                        chucVu = chucVuAccesser.GetChucVuByMacv(canBoGiaoVien.Macv.ToString(), true);
                        //theLoaiTin = theLoaiTinAccesser.GetTheLoaiTinByMatlt(tmp.Matlt.ToString(), true);

                        listCbgv.Add(canBoGiaoVien);
                        listChucVu.Add(chucVu);
                        //listTheLoaiTin.Add(theLoaiTin);
                    }
                    wsi.TinTucDaoTao = listTinTuc;
                    //wsi.TheLoaiTin = listTheLoaiTin;
                    wsi.CanBoGiaoVien = listCbgv;
                    wsi.ChucVu = listChucVu;
                }
                else
                {
                    wsi = null;
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
