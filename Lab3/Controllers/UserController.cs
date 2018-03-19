using Lab3.Data;
using Lab3.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        //public ActionResult Index()
        //{
        //return View();
        //}
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                //check if the user already exists
                foreach (var item in DB.Users)
                {
                    if (user.FirstName == DB.Users.FirstOrDefault().FirstName
                        && user.LastName == DB.Users.FirstOrDefault().LastName)
                    {
                        ModelState.AddModelError("FirstName", "the name already exist");
                        return View(user);


                    }
                }
                user.Id = DB.NextId();
                DB.Users.Add(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

           

        public ActionResult List()
        {
            var users = DB.Users;

            return View(users);
        }

        public ActionResult Delete(int id)
        {
            DB.DeleteUser(id);

            return RedirectToAction("List");
        }

    }
}