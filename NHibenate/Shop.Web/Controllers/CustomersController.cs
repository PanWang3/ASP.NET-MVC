using Shop.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Web.Controllers
{
    public class CustomersController : Controller
    {
        CustomersBusiness customersBusiness = new CustomersBusiness();
        // GET: Customers
        public ActionResult Index()
        {
            var result = customersBusiness.GetCustomerList(x => 1== 1);
            return View(result);
        }
    }
}