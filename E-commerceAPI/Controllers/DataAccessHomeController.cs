using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_commerceAPI.Controllers
{
    public class DataAccessHomeController : Controller
    {
        // GET: DataAccessHome
        public ActionResult Index()
        {
            CustometDataEntity entity = new CustometDataEntity();
            return View(from CustomerTable in entity.CustomerTables select CustomerTable);
        }
    }
}