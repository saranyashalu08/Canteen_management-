using CanteenManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace CanteenManagementSystem.Controllers
{
    public class UserController : Controller
    {
        CanteenContex db=new CanteenContex();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ULogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ULogin(Login l)
        {
            Login login=db.Login.Where(x=>x.UserName == l.UserName && x.Password==l.Password).SingleOrDefault();
            if(login!=null)
            {
                Session["Waiter_Id"] = login.UserName.ToString();
                return RedirectToAction("Home");
            }
            else
            {
                ViewBag.error = "Invalid Credentials";
            }
            return View();
        }
        public ActionResult WaiterRegister()
        {
            return View();
        }
        [HttpPost]
        public ActionResult WaiterRegister(Login l)
        {
            if(ModelState.IsValid)
            {
                db.Login.Add(l);
                db.SaveChanges();
                ViewBag.Message = l.UserName + "Successfully Registered";
                return RedirectToAction("ULogin");
            }
            return View();
        }
        public ActionResult Admin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Admin()
        {

            return View();
        }

    }
}