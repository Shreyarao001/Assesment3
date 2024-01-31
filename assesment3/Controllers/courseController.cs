using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace assesment3.Controllers
{
    public class courseController : Controller
    {
        static List<course> listcourse = new List<course>()
        {
        new course{ CId = 1, CName = "Shreya",CFee = 30000, Technology="Python",CStartDate=new DateTime(day:23, month:9, year:2019),CEndDate=new DateTime(day:23, month:11, year:2019)},
        new course{ CId = 2, CName = "reya",CFee = 40000, Technology="Java",CStartDate=new DateTime(day:23, month:10, year:2019),CEndDate=new DateTime(day:23, month:11, year:2019)},
        new course{ CId = 3, CName = "priya",CFee = 50000, Technology="c#",CStartDate=new DateTime(day:23, month:10, year:2019),CEndDate=new DateTime(day:23, month:11, year:2019)},
        new course{ CId = 4, CName = "nitya",CFee = 30000, Technology="c",CStartDate=new DateTime(day:23, month:10, year:2019),CEndDate=new DateTime(day:23, month:11, year:2019)},
        new course{ CId = 5, CName = "divya",CFee = 20000, Technology="c++",CStartDate=new DateTime(day:23, month:10, year:2019),CEndDate=new DateTime(day:23, month:11, year:2019)},
        new course{ CId = 6, CName = "navya",CFee = 10000, Technology="web technology",CStartDate=new DateTime(day:23, month:10, year:2019),CEndDate=new DateTime(day:23, month:11, year:2019)},
        new course{ CId = 7, CName = "piya",CFee = 40000, Technology="AI/ML",CStartDate=new DateTime(day:23, month:10, year:2019),CEndDate=new DateTime(day:23, month:11, year:2019)},
        new course{ CId = 8, CName = "siya",CFee = 20000, Technology="data science",CStartDate=new DateTime(day:23, month:10, year:2019),CEndDate=new DateTime(day:23, month:11, year:2019)},

        };
        // GET: course
        public ActionResult Index()
        {
            return View(listcourse);
        }
        [HttpGet]
        public ActionResult create()
        {
            return View(new course());
        }
        [HttpPost]
        public ActionResult Create(course c)
        {
            if (ModelState.IsValid)
            {
                listcourse.Add(c);
                return RedirectToAction("Index");
            }
            return View(c);
        }
    }
}