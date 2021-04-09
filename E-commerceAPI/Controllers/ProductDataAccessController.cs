using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_commerceAPI.Controllers
{
    public class ProductDataAccessController : Controller
    {
        // GET: ProductDataAccess
        public ActionResult Index()
        {
            ProductDataEntity entity = new ProductDataEntity();
            return View(from ProductTable in entity.ProductTables select ProductTable);
        }
    }
}