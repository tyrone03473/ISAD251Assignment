using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISAD251Assignment.Controllers
{
    public class StockController : Controller
    {
        public ActionResult Index()
        {
            //return Content("Index");
            return View();
        }

        public ActionResult Index2(string id)
        {
            return Content(
                String.Format("id :{0}", id)
                );
        }

        public ActionResult Index3(string id, string page)
        {
            return Content(
                String.Format("id :{0}, page :{1}", id, page)
                );
        }




    }
}