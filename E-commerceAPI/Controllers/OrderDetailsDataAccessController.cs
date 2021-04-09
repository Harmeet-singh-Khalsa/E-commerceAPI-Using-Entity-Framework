using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_commerceAPI.Controllers
{
    public class OrderDetailsDataAccessController : Controller
    {
        // GET: OrderDetailsDataAccess
        public ActionResult Index()
        {
            OrderDetailsEntity entity = new OrderDetailsEntity();
            return View(from Order_DetailsTable in entity.Order_DetailsTable select Order_DetailsTable);
        }
    }
}