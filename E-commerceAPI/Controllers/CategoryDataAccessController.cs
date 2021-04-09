using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_commerceAPI.Controllers
{
    public class CategoryDataAccessController : Controller
    {
        // GET: CategoryDataAccess
        public ActionResult Index()
        {
            CategoryDataEntity entity = new CategoryDataEntity();
            return View(from CategoryTable in entity.CategoryTables  select CategoryTable);
        }
    }
}