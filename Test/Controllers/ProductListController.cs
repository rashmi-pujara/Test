using Reader;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test.Controllers
{
    public class ProductListController : Controller
    {
        // GET: ProductList
        public ActionResult Index()
        {
            XMLReader readXML = new XMLReader();
            var data = readXML.RetrunListOfProducts();
            return View(data.ToList());
        }
    }
}