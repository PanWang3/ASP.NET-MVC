using NHibernate;
using NHibernate.Cfg;

namespace Shop.Data
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        public static ISessionFactory SessionFactory
        {
            get
            {
                return _sessionFactory == null ? (new Configuration()).Configure().BuildSessionFactory() : _sessionFactory;
            }
        }
    }
}