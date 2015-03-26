using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JVL;

namespace JVL
{
    public class SessionFactory
    {

        public static NHibernate.ISessionFactory _SessionFactory;
        private static void Init()
        {
            NHibernate.Cfg.Configuration config;
            config = new NHibernate.Cfg.Configuration();
            config.Configure();


            //Cấu hình kết nối
            config.SetProperty("connection.provider", "NHibernate.Connection.DriverConnectionProvider");
            //config.SetProperty("connection.connection_string", "Data Source=112.213.89.173;Initial Catalog=BOSS11;User ID=adminboss11;Password=1234567890");
            config.SetProperty("connection.connection_string", "Data Source=222.255.167.6;Initial Catalog=ATSM;User ID=atsm;Password=abc@123$");
            //config.SetProperty("connection.connection_string", "Data Source=.;Initial Catalog=NTJ2_BAK;User ID=sa;Password=sa");
            
            config.SetProperty("dialect", "NHibernate.Dialect.MsSql2008Dialect");
            config.SetProperty("connection.driver_class", "NHibernate.Driver.SqlClientDriver");

            config.AddAssembly(typeof(ATSMUser).Assembly);
            config.AddAssembly(typeof(LoginUser).Assembly);
            _SessionFactory = config.BuildSessionFactory();

        }
        public static NHibernate.ISessionFactory GetSessionFactory()
        {

            if (_SessionFactory == null)
            {
                Init();
            }
            return _SessionFactory;
        }
        public static NHibernate.ISession GetNewSession()
        {
            return GetSessionFactory().OpenSession();
        }

    }
}