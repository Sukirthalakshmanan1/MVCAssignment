using MVCAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAssignment.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        



        static List<Product1> plist = new List<Product1>();
        static ProductController()
        {
            plist.Add(new Product1 { pid = 1, pname = "Rice", Cost = 550, Mfg_Date = new DateTime(2022, 01, 04) });

           // plist.Add(new Product1 { Productid = 2, Productname = "Ajay", Cost = "550.0", MfgDate = new DateTime(2022, 01, 04) });
           // plist.Add(new Product1 { Productid = 10, Productname = "Ajay", Cost = "550.0", MfgDate = new DateTime(2022, 01, 04) });



        }
        public ActionResult Index()
        {



            return View(plist);


        }


        public ActionResult Details(int id)
        {
            Product1 foundData = plist.Find(p => p.pid == id);
            return View(foundData);
        }
        public ActionResult AddOrderDetails(int id)
        {
            Product1 foundData = plist.Find(c => c.pid == id);
            return RedirectToAction("NowEditOrderDetails", new { id = foundData.pid });
        }



        public ActionResult Delete(int id)
        {
            Product1 foundData = plist.Find(c => c.pid == id);
            return View(foundData);
        }

        [HttpPost]
        public ActionResult Delete(int id, Product1 pp)
        {
            Product1 foundData = plist.Find(c => c.pid == id);
            plist.Remove(foundData);
           // return View(foundData);
           return RedirectToAction("Index");

        }






        public ActionResult NowEditOrderDetails(int id)
        {
            Product1 foundData = plist.Find(c => c.pid == id);


            return View(foundData);
        }

        [HttpPost]

        public ActionResult NowEditOrderDetails(int id, Product1 p2)
        {
            Product1 foundData = plist.Find(c => c.pid == id);
            plist.Remove(foundData);
            plist.Add(p2);
            return RedirectToAction("Index");
        }


        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Product1 p1)
        {
            plist.Add(p1);
            return RedirectToAction("Index");
        }
    }
}