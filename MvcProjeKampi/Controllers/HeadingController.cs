using BusinessLogicLayer.Concrete;
using BusinessLogicLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        public ActionResult Index()
        {
            var headingValues = hm.GetList();
            return View(headingValues);
        }
        [HttpGet]
        public ActionResult AddHeading()
        {
            // dropdown içine dataları yüklüyor. Viewbag ile tasıma işlemi yapılıyor.
            List<SelectListItem> valueCategory = (from c in cm.GetList() select new SelectListItem { Text = c.CategoryName, Value = c.CategoryId.ToString() }).ToList();
            ViewBag.vlc = valueCategory;
            //


            List<SelectListItem> valueWriter = (from c in wm.GetList() select new SelectListItem { Text = c.WriterName + " " + c.WriterSurname, Value = c.WriterId.ToString() }).ToList();
            ViewBag.vlw = valueWriter;
            return View();
        }
        [HttpPost]
        public ActionResult AddHeading(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            hm.HeadingAdd(p);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            // dropdown içine dataları yüklüyor. Viewbag ile tasıma işlemi yapılıyor.
            List<SelectListItem> valueCategory = (from c in cm.GetList() select new SelectListItem { Text = c.CategoryName, Value = c.CategoryId.ToString() }).ToList();
            ViewBag.vlc = valueCategory;
            //       

            var headingValue = hm.GetById(id);
            return View(headingValue);
        }
        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult DeleteHeading(int id)
        {
            var headingValue = hm.GetById(id);
            headingValue.HeadingStatus = false;
            hm.HeadingDelete(headingValue);

            return RedirectToAction("Index");
        }

    }
}