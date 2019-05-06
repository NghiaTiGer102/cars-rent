using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarNew.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(CarNew.Models.UserProfile objUser)
        {
            if (ModelState.IsValid)
            {
                using (ShiftEntities db = new ShiftEntities())
                {
                    var obj = db.tb_User.Where(a => a.Username.Equals(objUser.username) && a.Password.Equals(objUser.password)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.IDUser.ToString();
                        Session["UserName"] = obj.Username.ToString();
                        //return RedirectToRoute("Default", new { });
                        return RedirectToAction("UserDashBoard");
                    }
                }
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }






        // GET: User
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}