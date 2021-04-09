using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_commerceAPI.Controllers
{
    public class OrderDataAccessController : Controller
    {
        // GET: OrderDataAccess
        public ActionResult Index()
        {
            OrderEntity entity = new OrderEntity();
            return View(from OrderTable in entity.OrderTables select OrderTable);
        }
    }
}