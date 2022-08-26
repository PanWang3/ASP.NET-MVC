using NHibernate;
using NHibernate.Linq;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Shop.Data
{
    public class CustomersData
    {
        /// <summary>
        /// 根据条件得到客户信息
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns>客户信息集合</returns>
        public List<Customers> GetCustomerList(Expression<Func<Customers, bool>> where)
        {
            try
            {
                using (ISession session = NHibernateHelper.SessionFactory.OpenSession())
                {
                    return session.Query<Customers>().Select(x => new Customers
                    {
                        CustomerID = x.CustomerID,
                        ContactName = x.ContactName,
                        City = x.City,
                        Address = x.Address,
                        Phone = x.Phone,
                        CompanyName = x.CompanyName,
                        Country = x.Country

                    }).Where(where).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Customers GetById(string id)
        {
            using (ISession session = NHibernateHelper.SessionFactory.OpenSession())
            {
                Customers customers = session.Get<Customers>(id);
                return customers;
            }
        }

        public bool Insert(Customers customers)
        {
            using (ISession session = NHibernateHelper.SessionFactory.OpenSession())
            {
                //插入新记录，返回记录主键值
                var identifier = session.Save(customers);

                //如果不存在就插入否则更新
                //session.SaveOrUpdate(customers);

                //将对象持久化写入数据库，如果不调用此方法，那么操作结束后修改记录不能写入数据库中
                session.Flush();
                return string.IsNullOrEmpty(identifier.ToString());
            }
        }

        public void Update(Customers customers)
        {
            using (var session = NHibernateHelper.SessionFactory.OpenSession())
            {
                session.SaveOrUpdate(customers);
                session.Flush();
            }
        }

        public void Delete(string id)
        {
            using (var session = NHibernateHelper.SessionFactory.OpenSession())
            {
                Customers customers = session.Get<Customers>(id);
                session.Delete(customers);
                session.Flush();
            }
        }
    }
}
