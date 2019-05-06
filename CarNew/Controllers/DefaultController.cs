using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarNew.Controllers
{
    public class DefaultController : Controller
    {
        public ShiftEntities data = new ShiftEntities();
        // GET: Default
        public ActionResult Index()
        {
            List<tb_Car> list = new List<tb_Car>();
            using (var DB = new ShiftEntities())
            {
                list = data.tb_Car.ToList();
                
            }

            return View(list);
        }

        
    }
}