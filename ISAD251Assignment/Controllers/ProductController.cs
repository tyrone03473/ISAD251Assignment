using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISAD251Assignment.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            List<Models.Product> result = new List<Models.Product>();

            using (Models.CartsEntities db = new Models.CartsEntities())

                result = (from s in db.Products select s).ToList();

                return View(result);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Create(Models.Product postback)
        {
            using (Models.CartsEntities db = new Models.CartsEntities())
            {
                db.Products.Add(postback);

                db.SaveChanges();
            }
            return View();
        }
    }
}