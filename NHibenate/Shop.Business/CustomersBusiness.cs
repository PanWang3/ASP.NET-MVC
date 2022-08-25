using Shop.Data;
using Shop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Shop.Business
{
    public class CustomersBusiness
    {
        private CustomersData _customersData;
        public CustomersBusiness()
        {
            _customersData = new CustomersData();
        }

        /// <summary>
        /// 根据条件得到客户信息集合
        /// </summary>
        /// <param name="where">条件</param>
        /// <returns>客户信息</returns>
        public IList<Customers> GetCustomerList(Expression<Func<Customers, bool>> where)
        {
            return _customersData.GetCustomerList(where);
        }

        public Customers GetById(string id)
        {
            return _customersData.GetById(id);
        }

        public bool Insert(Customers customers)
        {
            return _customersData.Insert(customers);
        }

        public void Update(Customers customers)
        {
            _customersData.Update(customers);
        }
    }
}